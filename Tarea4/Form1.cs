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
            txt5.Enabled = false;
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
            txtTarea.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuario usu;
            usu = new usuario();
            // int busqueda = int.Parse(buscar.Text);
            //usu.avance = Convert.ToInt32(buscar.Text);
            arbolito.buscar(usu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt5.Text = "";
            txt5.Text = ArbolBinarioBusqueda.inorden(arbolito.raizArbol());
        }
    }
}
