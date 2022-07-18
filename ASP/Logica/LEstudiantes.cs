using DataEstudiantes;
using LinqToDB;
using Logica.library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LEstudiantes : Library
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;
        private Bitmap imagBitmap;
        private DataGridView _dataGridView;
        private NumericUpDown _numericUpDown;
        private Paginador<Estudiante> _paginador;
        private string _accion = "insert";
        // private Library librarys;


        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabel, object[] objectos)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            //librarys = new Library();
            this.image = (PictureBox)objectos[0];
            this.imagBitmap = (Bitmap)objectos[1];
            _dataGridView = (DataGridView)objectos[2];
            _numericUpDown = (NumericUpDown)objectos[3];
            Restablecer();
           
        }
        public void Registrar()
        {
            if (listTextBox[0].Text.Equals(""))
            {
                listLabel[0].Text = "El campo DNI es requerido";
                listLabel[0].ForeColor = Color.Red;
                listTextBox[0].Focus();
            }
            else
            {
                if (listTextBox[1].Text.Equals(""))
                {
                    listLabel[1].Text = "El campo nombre es requerido";
                    listLabel[1].ForeColor = Color.Red;
                    listTextBox[1].Focus();
                }
                else
                {
                    if (listTextBox[2].Text.Equals(""))
                    {
                        listLabel[2].Text = "El campo apellido es requerido";
                        listLabel[2].ForeColor = Color.Red;
                        listTextBox[2].Focus();
                    }
                    else
                    {
                        if (listTextBox[3].Text.Equals(""))
                        {
                            listLabel[3].Text = "El campo email es requerido";
                            listLabel[3].ForeColor = Color.Red;
                            listTextBox[3].Focus();
                        }
                        else
                        {
                            if (textBoxEvent.comprobarFormatoEmail(listTextBox[3].Text))
                            {
                                //Crear una lista de la tabla estudiante y consultar su email y si existe
                                var user = _Estudiante.Where(u => u.email.Equals(listTextBox[3].Text)).ToList();

                                if (user.Count.Equals(0))
                                {
                                    Save();
                                }
                                else
                                {
                                    if (user[0].id.Equals(_idEstudiante))
                                    {
                                        Save();
                                    }
                                    else
                                    {
                                        listLabel[3].Text = "!Error! El email ya existe";
                                        listLabel[3].ForeColor = Color.Red;
                                        listTextBox[3].Focus();
                                    }
                                    
                                }


                               
                            }
                            else
                            {
                                listLabel[3].Text = "Email no valido";
                                listLabel[3].ForeColor = Color.Red;
                                listTextBox[3].Focus();
                            }      
                        }
                    }
                }
            }
        }
        private void Save()
        {
            //Utilizamos este metodo para insertar datos,utilizar una expresion de datos
            //es mas simple y comodo
            //Se agrega una nueva columna a la base de datos sql
            //Ejecutamos esta sentencia en la base de datos.
            //ALTER TABLE Estudiante ADD image VARBINARY(MAX)
            BeginTransactionAsync(); //indicamos al programa que las inserciones la controlara las
                                     //transaction.
            try
            {
                var imageArray = uploadImage.ImageToByte(image.Image);
                
                switch (_accion)
                {
                    case "insert":
                        _Estudiante.Value(e => e.dni, listTextBox[0].Text)
                            .Value(e => e.nombre, listTextBox[1].Text)
                            .Value(e => e.apellidos, listTextBox[2].Text)
                            .Value(e => e.email, listTextBox[3].Text)
                            .Value(e => e.image, imageArray)
                            .Insert();
                        break;
                    
                    case "update":
                        _Estudiante.Where(u => u.id.Equals(_idEstudiante))
                            .Set(u => u.dni, listTextBox[0].Text)
                            .Set(u => u.nombre, listTextBox[1].Text)
                            .Set(u => u.apellidos, listTextBox[2].Text)
                            .Set(u => u.email, listTextBox[3].Text)
                            .Set(u => u.image, imageArray)
                            .Update();
                        break;
                }
                
    
                //hace definitiva la insercion del estudiante.
                CommitTransaction();
                Restablecer();

            }
            catch (Exception)
            {
                RollbackTransaction();
            }


            //Creamos un procedimiento nuevo  y mas simplificado.
            //var db = new Conexion();
            //db.Insert(new Estudiante()
            //{
            //    dni = listTextBox[0].Text,
            //    nombre = listTextBox[1].Text,
            //    apellidos = listTextBox[2].Text,
            //    email = listTextBox[3].Text,
            //}) ;
        }

        private int _reg_por_pagina = 2, _num_pagina = 1;
        public void SearchEstudiante(string campo)
        {
            List<Estudiante> query = new List<Estudiante>();
            int inicio = (_num_pagina - 1) * _reg_por_pagina;
            if(campo.Equals(""))
            {
                query = _Estudiante.ToList();
            }
            else 
            {
                query = _Estudiante.Where(c => c.dni.StartsWith(campo) || c.nombre.StartsWith(campo) ||
                                          c.apellidos.StartsWith(campo)).ToList();
            }
            if(0 < query.Count)
            {
                _dataGridView.DataSource = query.Select(c => new
                {
                    c.id,
                    c.dni,
                    c.nombre,
                    c.apellidos,
                    c.email,
                    c.image
                }).Skip(inicio).Take(_reg_por_pagina).ToList();
                //Ocultar la columna de id
                _dataGridView.Columns[0].Visible = false;
                _dataGridView.Columns[5].Visible = false;

                //Dar estilos a las columnas.
                _dataGridView.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                _dataGridView.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;

            }
            else
            {
                _dataGridView.DataSource = query.Select(c => new
                {

                    c.dni,
                    c.nombre,
                    c.apellidos,
                    c.email,
                }).ToList();


            }
        }

        private List<Estudiante> listEstudiante;
        private int _idEstudiante = 0;

        public void GetEstudiante()
        {
            _accion = "update";
            _idEstudiante = Convert.ToInt16(_dataGridView.CurrentRow.Cells[0].Value);
            listTextBox[0].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[1].Value);
            listTextBox[1].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[2].Value);
            listTextBox[2].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[3].Value);
            listTextBox[3].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[4].Value);
            try
            {
                byte[] arrayImage = (byte[])_dataGridView.CurrentRow.Cells[5].Value;
                image.Image = uploadImage.byteArrayToImage(arrayImage);

            }
            catch (Exception) 
            {
                image.Image = imagBitmap;
                Console.WriteLine("Fallo");
                throw;
            }
        }



        public void Paginador(string metodo) 
        {
            switch (metodo)
            {
                case "Primero":
                    _num_pagina = _paginador.primero();
                    break;
                case "Anterior":
                    _num_pagina = _paginador.anterior();
                    break;
                case "Siguiente":
                    _num_pagina = _paginador.siguiente();
                    break;
                case "Ultimo":
                    _num_pagina = _paginador.ultimo();
                    break;
            }
            SearchEstudiante("");

        }
        public void Registro_Paginas()
        {
            _num_pagina = 1;
            _reg_por_pagina = (int)_numericUpDown.Value;
            var list = _Estudiante.ToList();
            if(0 < list.Count)
            {
                _paginador = new Paginador<Estudiante>(listEstudiante, listLabel[4], _reg_por_pagina);
                SearchEstudiante("");
            }
        }

        public void Eliminar()
        {
            if (_Estudiante.Equals(0))
            {
                MessageBox.Show("Seleccione un estudiante");
            }
            else
            {
                if(MessageBox.Show("Esta seguro de eliminar este estudiante?", "Eliminar Estudiante",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _Estudiante.Where(c => c.id.Equals(_idEstudiante)).Delete();
                    Restablecer();
                }
            }
        }



        public void Restablecer()
        {
            _accion = "insert";
            _num_pagina = 1;
            _idEstudiante = 0;
            image.Image = imagBitmap;
            listLabel[0].Text = "Dni";
            listLabel[1].Text = "Nombre";
            listLabel[2].Text = "Apellidos";
            listLabel[3].Text = "Email";
            listLabel[0].ForeColor = Color.LightSlateGray;
            listLabel[1].ForeColor = Color.LightSlateGray;
            listLabel[2].ForeColor = Color.LightSlateGray;
            listLabel[3].ForeColor = Color.LightSlateGray;
            listTextBox[0].Text = "";
            listTextBox[1].Text = "";
            listTextBox[2].Text = "";
            listTextBox[3].Text = "";
            listEstudiante = _Estudiante.ToList();
            if(0 < listEstudiante.Count) 
            {
                _paginador = new Paginador<Estudiante>(listEstudiante, listLabel[4], _reg_por_pagina);
            
            }
            SearchEstudiante("");

        }

    }
}
