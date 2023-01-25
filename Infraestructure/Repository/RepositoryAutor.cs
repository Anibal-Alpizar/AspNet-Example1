using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RepositoryAutor : IRepositoryAutor
    {
        public IEnumerable<Autor> GetAutor()
        {
            try
            {
                IEnumerable<Autor> list = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    // select * from autor
                    list = ctx.Autor.ToList<Autor>();
                    // list = ctx.Autor.ToList();

                }
                return list;
            }
            catch {
                throw;
            }
        }

        public Autor GetAutorById(int id)
        {
            try
            {
                Autor oAutor = null;
                using (MyContext ctx = new MyContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;

                    // Syntaxis linq Query
                    //var infoAutor = from a in ctx.Autor
                    //                where a.IdAutor == id
                    //                select a;
                   // oAutor = infoAutor.FirstOrDefault();

                    // Syntaxis Linq Method
                    // Find Method
                    oAutor = ctx.Autor.Find(id);

                    // Permite combinar o crer consultas mas complejas
                    // Dar formato
                   // oAutor = ctx.Autor.Where(x => x.IdAutor == id).FirstOrDefault();


                }
                return oAutor;
            }
            catch
            {
                throw;
            }
        }
    }
}
