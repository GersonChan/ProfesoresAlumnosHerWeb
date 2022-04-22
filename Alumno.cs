using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProfesoresAlumnosHerWeb
{
    public class Alumno : Persona
    {
        public int numeroCarnet { get; set; }
        public List<int> numeroNotas { get; set; }
    }
}