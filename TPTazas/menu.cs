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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informes informes = new informes();
            informes.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidoPlanilla pedidoPlanilla = new PedidoPlanilla();
            pedidoPlanilla.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
