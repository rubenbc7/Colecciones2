using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo matematicas = new Grupo("Matematicas", "M1");
            Grupo historia = new Grupo("Historia", "H1");
            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno pancho = new Alumno("pancho", "p1");
            Alumno pancha = new Alumno("pancha", "p2");
            Alumno lupe = new Alumno("lupe", "l1");
            Alumno conchita = new Alumno("conchita", "c1");
            Alumno chuy = new Alumno("chuy", "c2");

            historia.Alumnos.Add(pancho);
            historia.Alumnos.Add(pancha);
            historia.Alumnos.Add(lupe);

            matematicas.Alumnos.Add(pancho);
            matematicas.Alumnos.Add(pancha);
            matematicas.Alumnos.Add(lupe);
            matematicas.Alumnos.Add(conchita);
            matematicas.Alumnos.Add(chuy);

            foreach(Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo: " + grupo.Codigo);
                Console.WriteLine("Materia: " + grupo.Materia);
                Console.WriteLine(" ");
                Console.WriteLine("Lista de alumnos: ");
                foreach(Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("° " + alumno.Nombre);
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
