using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasXML
{
    [Serializable]
    public class Estudiante
    {
        public string Carne { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"{Carne} - {Nombre}";
        }
    }
}
