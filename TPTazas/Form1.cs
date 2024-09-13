using BE;
using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenta

{
    public partial class Form1 : Form
    {
        private Cliente cliente;
        private DataTable dataTable1;
        private DataTable dataTable2;
        public static string PassedData { get; internal set; }

        public Form1()
        {
            InitializeComponent();

          
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");
           
            dataGridView1.Columns.Add("DNI", "DNI");
            dataGridView1.Columns.Add("CP", "CP");
           
           cliente = new Cliente();///

            

        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            PedidoPlanilla pedidoPlanilla = new PedidoPlanilla();
            pedidoPlanilla.Show();
          
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            #region cargo los TextBox
         
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string dni = textBox3.Text;
            string cp = textBox4.Text;

            dataGridView1.Rows.Add(nombre, apellido, dni,cp);

            #endregion

            #region limpio los textbox

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            #endregion

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            // Verificar si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la primera fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Confirmar la eliminación
                var result = MessageBox.Show("¿Está seguro de que desea eliminar la fila seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Eliminar la fila seleccionada
                    dataGridView1.Rows.Remove(selectedRow);
                }
            }
            else
            {
                // Mostrar un mensaje si no hay filas seleccionadas
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
    
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Eliminar la fila seleccionada
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
            else
            {
                // Muestra un mensaje si no hay filas seleccionadas
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)

        {
            
            // Verificar si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
               
                // Obtener los valores de los TextBox
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                string dni = textBox3.Text;
                string cp = textBox4.Text;


                // Modificar los valores de la fila seleccionada
                selectedRow.Cells["Nombre"].Value = nombre;
            selectedRow.Cells["Apellido"].Value = apellido;
            selectedRow.Cells["DNI"].Value = dni;
                selectedRow.Cells["CP"].Value = cp;

                // Limpiar los TextBox después de modificar
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
    else
    {
        // Mostrar un mensaje si no hay filas seleccionadas
        MessageBox.Show("Por favor, seleccione una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
         }
            private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su Pedido llegara en 15 dias, Gracias por su compra !");
        }
    }
}