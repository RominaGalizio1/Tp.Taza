using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    internal class ErrorPersonalizado : Exception
        {
            public override string Message => "Error al modificar, crear o eliminar";
        }
    
}
