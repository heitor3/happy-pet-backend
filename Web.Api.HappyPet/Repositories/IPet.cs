using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.HappyPet.Models;

namespace Web.Api.HappyPet.Repositories
{
    public interface IPet
    {
        void Create(Pet pet);

        void Delete(int id);

        IEnumerable<Pet> List();

        IEnumerable<Pet> ListById(int id);

    }
}
