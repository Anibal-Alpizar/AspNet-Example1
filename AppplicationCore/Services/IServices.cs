﻿using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppplicationCore.Services
{
    public interface IServices
    {
        Autor GetAutorById(int id);
        IEnumerable<Autor> GetAutor();
    }
}