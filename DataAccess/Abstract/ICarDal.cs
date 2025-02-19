﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDto> GetAllDto();
        CarDto GetDto(int carId);
        CarDetailDto GetDetailDto(int carId);
    }
}
