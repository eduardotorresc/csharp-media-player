using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class Form2 : Form
    {
        //bool Play = false;
        string[] Archivos;
        string[] Rutas;
        public Form2()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            var cajaDeBusqueda = new OpenFileDialog
            {
                Multiselect = true
            };

            if (cajaDeBusqueda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Archivos = cajaDeBusqueda.SafeFileNames;
                Rutas = cajaDeBusqueda.FileNames;
                foreach (var Archivo in Archivos)
                {
                    lstSongs.Items.Add(Archivo);
                }
                axWindowsMediaPlayer1.URL = Rutas[0];
                lstSongs.SelectedIndex = 0;
            }
        }

        private void LstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Rutas[lstSongs.SelectedIndex];
        }
    }
}
