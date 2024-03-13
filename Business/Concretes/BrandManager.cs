using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using DataAccess.Abstract;
using Entities.Concretes;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal= brandDal;
        }
        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {

            Brand brand = new Brand();
            brand.Name = createBrandRequest.Name;
            brand.CreatedDate = DateTime.Now;
            _brandDal.Add(brand);

            //mapping
            CreatedBrandResponse createBrandResponse = new CreatedBrandResponse();
            createBrandResponse.Name = brand.Name;
            createBrandResponse.Id = brand.Id;
            createBrandResponse.CreatedDate = brand.CreatedDate;

            return createBrandResponse;
        }

        public List<GetAllBrandResponse> GetAll()
        {
            List<Brand> brands=_brandDal.GetAll();  
            List<GetAllBrandResponse>getAllBrandResponses=new List<GetAllBrandResponse>();

            foreach (var brand in  brands)
            {
                GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
                getAllBrandResponse.Name=brand.Name;
                getAllBrandResponse.Id=brand.Id;    
                getAllBrandResponse.CreatedDate=brand.CreatedDate;

                getAllBrandResponses.Add(getAllBrandResponse);
            }

            return getAllBrandResponses;
        }
    }
}
