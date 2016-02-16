using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace numerosP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }


       

        

         private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
         {
             SaveFileDialog saveFileDialog1 = new SaveFileDialog();

             label1.Text = "Escriba el texto a gurdar";
             //Muestra la extension del texto a guardar por default
             saveFileDialog1.Filter = " text |*.txt";


             //Rotulo de ventana
             saveFileDialog1.Title = "Archivos de Texto";

             //Muestra ventana emergente para guardar  y a la ves lo crea
             if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {

                 using (var savef = new System.IO.StreamWriter(saveFileDialog1.FileName + ".txt"))

                 { savef.Write(richTextBox1.Text); }

             }


             richTextBox1.Clear();
             MessageBox.Show("Guardad correctamente!!");
             
         }

         private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
         {
             richTextBox1.Clear();
             label1.Text = "Texto contenido ";
             OpenFileDialog openfle1 = new OpenFileDialog();
             //Rotulo ventana "Abrir"
             openFileDialog1.Title = "Escoja el archivo";

             //Fitro para archivos con extension txt
             openfle1.Filter = "Texto|*.txt";

                          if (openfle1.ShowDialog() == DialogResult.OK)
                          {
                             var archivo = openfle1.FileName;
                              using (StreamReader leer = new StreamReader(archivo))
                              { richTextBox1.Text = leer.ReadToEnd(); }
                          }
           
                          

         }

         private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             MessageBox.Show("Adiosin!!!!   *-*");
             this.Close();
             
         }
    }


}
