using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.library
{
     public class UploadImage
    {
        private OpenFileDialog fd = new OpenFileDialog();
        public void CargarImagen(PictureBox pictureBox)
        {
            //Se establece la propiedad WaitOnload a true siginifa que la imagen
            //se carga de forma sincronica.
            pictureBox.WaitOnLoad = true;
            //tipos de archivos soportados
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp";
            //abre una ventana de dialogo
            fd.ShowDialog();
            //Si el nombre del archivo es diferente a vacio ,invocamos el metodo para subir la imagen.
            if(fd.FileName != String.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }

        public byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public Image byteArrayToImage(byte[] byteArrayin)
        {
            return Image.FromStream(new MemoryStream(byteArrayin));
        }
    }
}
