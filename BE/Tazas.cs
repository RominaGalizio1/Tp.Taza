using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public abstract class Tazas
    {
        public string Marca { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }

        // Método abstracto que debe ser implementado por las clases derivadas
        public abstract string ObtenerDescripcion();
    }
}

