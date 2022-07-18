using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //importado para capturar evento


namespace Logica.library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //1º Condicion que solo nos permite ingresar datos de tipo de texto.
            //si es un caracter alfabetico ,es metodo devuelve boolean.
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }

            //Condicion que permite no dar un salto de linea cuando se oprime el enter.
            else if(e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }

            //Condicion que nos permite eleminar caracteres ,con la tecla de retroceso o backspace.
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }

            //Condicion que nos permite utilizar la tecla espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            //Ultima condicion que elimina la posibilidad de ingresar cualquier otro tipo de dato en ese campo
            else { e.Handled = true; }
        }

        public void numberKeyPress(KeyPressEventArgs e)
        {
            //1º Condicion que solo nos permite ingresar datos de tipo de texto.
            //si es un caracter alfabetico ,es metodo devuelve boolean.
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }

            //Condicion que permite no dar un salto de linea cuando se oprime el enter.
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            
            //Condicion que no permite introducir datos de tipo texto,true niega el acceso
            else if (Char.IsLetter(e.KeyChar)) {e.Handled = true; }

            //Condicion que nos permite eleminar caracteres ,con la tecla de retroceso o backspace.
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }

            //Condicion que nos permite utilizar la tecla espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }

            //Ultima condicion que elimina la posibilidad de ingresar cualquier otro tipo de dato en ese campo
            else { e.Handled = true; }
        }

        public bool comprobarFormatoEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

    }
}
