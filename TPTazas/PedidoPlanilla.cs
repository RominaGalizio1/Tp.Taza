using Presenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PedidoPlanilla : Form
    {
        #region Contadores
        static int ContSubli = 0;
        static int ContJarra = 0;
        static int ContPocilo = 0;
        #endregion

        public PedidoPlanilla()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Activacion del Combobox
            if (this.Cbxodelo.SelectedItem.ToString() == "Taza Ceramica Sublimada")
            {
                this.groupBox1.Enabled = true;
                ContSubli++;
            }

            else if (this.Cbxodelo.SelectedItem.ToString() == "Taza Jarron Mug")
            {
                this.groupBox1.Enabled = false;
                ContJarra++;
            }

            else if (this.Cbxodelo.SelectedItem.ToString() == "Taza Pocillo Americano")
            {
                this.groupBox1.Enabled = false;
                ContPocilo++;
            }
            #endregion



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            

            Form1.PassedData = Cbxodelo.SelectedItem.ToString();
            Form1.PassedData = comboBox2.SelectedItem.ToString();
            Form1.PassedData = comboBox3.SelectedItem.ToString();
            Form1.PassedData = textBox1.Text;
            Form1.PassedData = textBox2.Text;


            form1.Show();





        } 

        private void PedidoPlanilla_Load(object sender, EventArgs e)
        {


        }
        
      static void Contadores() 
        {

        }  
    }
}


