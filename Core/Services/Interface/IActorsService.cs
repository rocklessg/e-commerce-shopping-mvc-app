using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Interface
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Task<Actor> GetById();
        void Add(Actor actor);
        Task<Actor> Update(int id, Actor actor);
        void Delete(int id);
    }
}
