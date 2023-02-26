using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencia.CapaModelo
{
    class ClsImage
    {
        public byte[] ImageToByteArray(Image imagenUser)
        {
            using (var stream = new MemoryStream())
            {
                imagenUser.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        public Image byteArrayToImage(byte[] bytesImagenUser)
        {
            using (MemoryStream memstr = new MemoryStream(bytesImagenUser))
            {
                Image img = Image.FromStream(memstr);
                return img;

            }
        }


    }
}
