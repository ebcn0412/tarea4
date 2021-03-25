using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4
{
    class Usuario : Comparador
    {
        string Tarea { get; set; }
        int Duracion { get; set; }
        double Avance { get; set; }
        string Programador { get; set; }

        public Usuario(string tarea, int duracion, double avance, string programador)
        {
            Tarea = tarea;
            Duracion = duracion;
            Avance = avance;
            Programador = programador;
        }

        bool Comparador.igualQue(object op2)
        {
            Usuario p2 = (Usuario)op2;
            return Tarea == p2.Tarea;
        }

        bool Comparador.menorQue(object op2)
        {
            Usuario p2 = (Usuario)op2;
            return Tarea == p2.Tarea;
        }

        bool Comparador.menorIgualQue(object op2)
        {
            Usuario p2 = (Usuario)op2;
            return Tarea == p2.Tarea;
        }

        bool Comparador.mayorQue(object op2)
        {
            Usuario p2 = (Usuario)op2;
            return Tarea == p2.Tarea;
        }

        bool Comparador.mayorIgualQue(object op2)
        {
            Usuario p2 = (Usuario)op2;
            return Tarea == p2.Tarea;
        }

        public override string ToString()
        {
            return "(" + Tarea + " - " + Duracion + " - " + Avance + " " + Programador + ")";
        }



    }
}
