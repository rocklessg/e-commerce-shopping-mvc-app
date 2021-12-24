using Core.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Implementation
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public Task<Actor> GetById()
        {
            throw new NotImplementedException();
        }

        public Task<Actor> Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
