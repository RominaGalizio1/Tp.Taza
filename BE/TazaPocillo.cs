using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TazaPocillo : Tazas
    {
        public int Medida { get; set; } // e.g., 60 mm, 90 mm

        public override string ObtenerDescripcion()
        {
            return $"Taza Pocillo: Marca={Marca}, Color={Color}, Precio={Precio}, Medida={Medida} mm";
        }
    }
}
