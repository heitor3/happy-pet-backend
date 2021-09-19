using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Web.Api.HappyPet.Context;
using Web.Api.HappyPet.Models;

namespace Web.Api.HappyPet.Repositories
{
    public class PetRepository : IPet
    {
        private readonly AppDbContext _appDbContext;

        public PetRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Create(Pet pet)
        {
            _appDbContext.Pet.Add(pet);
            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var pet = _appDbContext.Pet.FirstOrDefault(x => x.PetId == id);
            _appDbContext.Set<Pet>().Remove(pet);
            _appDbContext.SaveChanges();
        }

        public Pet Details(int id)
        {
            return _appDbContext.Pet
                .Include(x => x.Especie)
                .Include(x => x.Porte)
                .FirstOrDefault(x => x.PetId == id);
        }

        public IEnumerable<Pet> List()
        {
            return _appDbContext.Pet
                .Include(x => x.Especie)
                .Include(x => x.Porte)
                .ToList();

        }

        public IEnumerable<Pet> ListById(int id)
        {
            return _appDbContext.Pet
                .Include(x => x.Especie)
                .Include(x => x.Porte)
                .Where(x => x.UsuarioId == id);
        }
    }
}
