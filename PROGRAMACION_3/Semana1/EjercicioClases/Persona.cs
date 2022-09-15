using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases
{
    public class Persona
    {
        //Atributos
        public int _edad { get; set; }
        public string _nombre { get; set; }
        public int _cedula { get; set; }
        public bool _vivo { get; set; }

        //Constructor
        public Persona(bool vivo, string nombre)
        {
            _vivo = vivo;
            _nombre = nombre;
        }

        public Persona()
        {
        }

        //Metodos
        public void Respirar()
        {
            Console.WriteLine(_nombre + " está respirando");
        }

        public void Comer()
        {
            Console.WriteLine(_nombre + " está comiendo");
        }

        public void Dormir()
        {
            Console.WriteLine(_nombre + " está durmiendo");
        }

        public string Frase()
        {
            string fraseCelebre = "Quien tenga miedo a morir, que no nazca";
            return fraseCelebre;
        }

        public int dineroBanco()
        {
            Random numeroAleatorio = new Random();
            int saldoCuenta = numeroAleatorio.Next();
            return saldoCuenta;
        }
    }

    //Estudiantes - notas, carreras - Realizar el examen

    //Profesor salario, vacaciones - Dar clases

    //Seguridad

    //Rector

    public class Estudiante : Persona
    {
        public int notaCurso { get; set; }
        public string curso { get; set; }
        public Estudiante(bool vivo, string nombre):base()
        {
            _vivo = vivo;
            _nombre = nombre;
        } 

        public void AprobarCurso(string nombreCurso)
        {
            Console.WriteLine("El estudiante {0} aprobó el curso {1}",this._nombre,nombreCurso);
        }
    }

    public class Profesor : Persona
    {
        public int salario { get; set; }

        public void RecibirAguinaldo()
        {
            Console.WriteLine("El profesor {0} ha recibido el aguinaldo ",this._nombre);
        }
    }
}
