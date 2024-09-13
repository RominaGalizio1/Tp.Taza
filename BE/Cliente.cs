using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public int CP { get; set; }

        public List<Tazas> TazasCompradas { get; set; } = new List<Tazas>();

        #endregion

        public void ComprarTaza(Tazas taza)
        {
            TazasCompradas.Add(taza);
        }



       

        #region Constructor SobreCargado
        public Cliente (string Linea)// constructor SobreCargado
        {
            if(Linea != "") 
            {
                string[] lines = Linea.Split('-');
                this.Nombre = lines[0];
                this.Apellido = lines[1];
                this.DNI = int.Parse(lines[2]);
                this.CP = int.Parse(lines[3]);

            }

         }

        public Cliente()
        {
        }
        #endregion

        #region Metodo
        public string GenerarRegistro() 
        {
            return Nombre + "-"+Apellido +"-"+ DNI +"-"+ CP + "-";
        }

        #endregion


    }
}
