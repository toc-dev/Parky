using ParkyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyAPI.Repository.IRepository
{
    public interface INationalParkRepository
    {
        ICollection<NationalPark> GetNationalParks();
        NationalPark GetNationalPark(int nationalParkId);
        bool NationaParkExists(string name);
        bool NationaParkExists(int id);
        bool CreateNationaPark(NationalPark nationalPark);
        bool UpdateNationaPark(NationalPark nationalPark);
        bool DeleteNationaPark(NationalPark nationalPark);
        bool Save();
    }
}
