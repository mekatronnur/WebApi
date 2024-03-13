﻿using Business.Dtos.Request;
using Business.Dtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
       CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);

       List<GetAllBrandResponse> GetAll();

    }
}
//responses amd request 
//--> yanıtlar ve istekler 