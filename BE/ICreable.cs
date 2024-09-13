using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    internal interface ICreable
    {
        DateTime FechaCreacion { get; set; }

        string FechaEntrega(ICreable otroObjeto);

    }
}
