﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistencia.CapaModelo
{
    public class ClsOpenDialogPicture
    {

        public string cadenaArchivo { get; set; }
        public Image imagenArchivo { get; set; }

        public ClsOpenDialogPicture(string cadenaArchivo, Image imagenArchivo)
        {
            this.cadenaArchivo = cadenaArchivo;
            this.imagenArchivo = imagenArchivo;
        }

        public string AbrirCadena(string cadenaArchivo) 
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    cadenaArchivo = "";
                    cadenaArchivo = dialog.FileName;
                    return cadenaArchivo;
                }
                else
                {
                    return null;

                }


            }
        }

        public Image MostrarImagen(string cadenaArchivo)
        {
            return imagenArchivo = Image.FromFile(cadenaArchivo);
        }
    }
}
