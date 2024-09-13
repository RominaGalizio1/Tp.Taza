using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TazaSublimada: Tazas
    {
        public string TipoSublimacion { get; set; } // e.g., "Térmica", "Personalizada", "Disney"

        public override string ObtenerDescripcion()
        {
            return $"Taza Sublimada: Marca={Marca}, Color={Color}, Precio={Precio}, Tipo de Sublimación={TipoSublimacion}";
        }
    }
}
