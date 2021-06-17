using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Interfaces
{
   public interface IUnitOfWork
    {
        iCityRepository CityRepository { get; }

        IUserRepository UserRepository { get; }

        IPropertyRepository PropertyRepository { get; } 

        IPropertyTypeRepository PropertyTypeRespository { get; }

        IFurnishingTypeRepository FurnishingTypeRepository { get; }

        Task<bool> SaveAsync();
    }
}
