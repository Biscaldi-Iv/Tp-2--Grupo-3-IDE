﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Web
{
     public interface ICursosService
    {
        Task<IEnumerable<cursos>> GetCursos();
    }
}
