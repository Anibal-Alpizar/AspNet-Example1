using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppplicationCore.Services.ServiceAutor;

namespace AppplicationCore.Services
{
        public class ServiceAutor : IServiceAutor
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
