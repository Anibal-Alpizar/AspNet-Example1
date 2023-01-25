using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppplicationCore.Services
{
    internal class ServiceAutor : IServices
    {
        public IEnumerable<Autor> GetAutor()
        {
            IRepositoryAutor repository = new RepositoryAutor();
            return repository.GetAutor();
        }

        public Autor GetAutorById(int id)
        {
            IRepositoryAutor repository = new RepositoryAutor();
            return repository.GetAutorById(id);
        }
    }
}
