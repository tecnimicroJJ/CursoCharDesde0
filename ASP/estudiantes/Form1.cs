using Logica;
using Logica.library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudiantes
{
    public partial class Form1 : Form
    {
        private LEstudiantes estudiantes;
        //private Library librarys;
        public Form1()
        {
            InitializeComponent();
            //librarys = new Library();
            //Coleccion de objetos TextBox.
            var listTextBox = new List<TextBox>();

            //añadimos cada uno de los campos de texto a la coleccion.
            listTextBox.Add(textBoxDni);
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellidos);
            listTextBox.Add(textBoxEmail);
           
            //añadimos las etiquetas labels
            var listLabel = new List<Label>();
            listLabel.Add(labelDni);
            listLabel.Add(labelNombre);
            listLabel.Add(labelApellidos);
            listLabel.Add(labelEmail);
            listLabel.Add(labelPaginas);

            Object[] objectos = { pictureBoxFoto,
                                  Properties.Resources.images1,
                                  dataGridView1,
                                  numericUpDown1
            };

            estudiantes = new LEstudiantes(listTextBox,listLabel, objectos);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            estudiantes.uploadImage.CargarImagen(pictureBoxFoto);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDni.Text.Equals(""))
            {
                labelDni.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelDni.ForeColor = Color.Green;
                labelDni.Text = "DNI";
            }

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Equals(""))
            {
                labelNombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNombre.ForeColor = Color.Green;
                labelNombre.Text = "Nombre";
            }
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellidos_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApellidos.Text.Equals(""))
            {
                labelApellidos.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApellidos.ForeColor = Color.Green;
                labelApellidos.Text = "Apellidos";
            }
        }

        private void textBoxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiantes.textBoxEvent.textKeyPress(e);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "Email";
            }
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            estudiantes.Registrar();
        }

        private void textBoxBuscar_TextChanged_1(object sender, EventArgs e)
            
        {
            estudiantes.SearchEstudiante(textBoxBuscar.Text);
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Primero");
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Anterior");
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Siguiente");
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            estudiantes.Paginador("Ultimo");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            estudiantes.Registro_Paginas();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                estudiantes.GetEstudiante();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
                estudiantes.GetEstudiante();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            estudiantes.Restablecer();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            estudiantes.Eliminar();
        }
    }
}
