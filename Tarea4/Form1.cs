using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4
{
    public partial class Form1 : Form
    {
        ArbolBinarioBusqueda arbolito = new ArbolBinarioBusqueda();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Comentario XD
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insertar los datos de los txt al arbolbinario :v
            usuario usu;
            usu = new usuario();
            usu.nombreTarea = txtTarea.Text;
            usu.duracion = Convert.ToInt32(txt2.Text);
            usu.avance = Convert.ToDouble(txt3.Text);
            usu.nombreProgramador = txt4.Text;
            arbolito.insertar(usu);
            
        }
    }
}
