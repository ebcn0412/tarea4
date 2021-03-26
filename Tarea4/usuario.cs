using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class usuario : Comparador
    {
        public string nombreTarea { get; set; }
        public int duracion { get; set; }
        public double avance { get; set; }
        public string nombreProgramador{ get; set; }

        public usuario()
        {

        }

        public usuario(string tarea, int dura, double avan, string programador)
        {
            nombreTarea = nombreTarea;
            duracion = duracion;
            avance = avance;
            nombreProgramador = nombreProgramador;
        }

        bool Comparador.igualQue(object op2)
        {
            usuario p2 = (usuario)op2;
            return duracion == p2.duracion;
        }

        bool Comparador.menorQue(object op2)
        {
            usuario p2 = (usuario)op2;
            return duracion < p2.duracion;
        }

        bool Comparador.menorIgualQue(object op2)
        {
            throw new NotImplementedException();

        }

        bool Comparador.mayorQue(object op2)
        {
            usuario p2 = (usuario)op2;
            return duracion > p2.duracion;
        }

        bool Comparador.mayorIgualQue(object op2)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "(" + nombreTarea + " - " + duracion + " - " + avance + " " + nombreProgramador + ")";
        }



    }
}
