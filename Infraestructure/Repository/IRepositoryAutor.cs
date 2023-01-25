using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryAutor 
    {
        Autor GetAutorById(int id);
        IEnumerable<Autor> GetAutor();
    }
}
