// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Perro firulais = new Perro("Firulais", "negro", "cocker", 15);
//Perro pipo = new Perro("Pipo");

//firulais.Ladrar();

using EjercicioClases;

Persona persona1 = new Persona(true,"Keylor Navas");

bool estadoPersona = true;
string nombre = "Lewandowski";
Persona persona2 = new Persona(estadoPersona, nombre);

persona1.Dormir();
persona2.Comer();

string estadoCuenta = persona1.dineroBanco().ToString(); ;
Console.WriteLine("El saldo de la cuenta de " + persona1._nombre + " es de "+ estadoCuenta);
Console.WriteLine("El jugador internacional {0} siempre dice: {1}",persona2._nombre, persona2.Frase());

Estudiante est1 = new Estudiante(false,"Mendel");
Profesor prof1 = new Profesor();

est1.AprobarCurso("Programación 3");
prof1._nombre = "Bill Gates";
prof1.RecibirAguinaldo();

public class Perro
{
    //Atributos
    /*
     * Nombre
     * Color
     * Raza
     * Altura
     * Peso
     * fechaNacimiento
     */
    public string _nombre { get; set; }
    public string _color { get; set; }
    public string _raza { get; set; }
    public int _edad { get; set; }

    //Constructor

    public Perro(string nombre)
    {
        this._nombre = nombre;
    }
    public Perro(string nombre, string color, string raza, int edad){
        this._nombre = nombre;
        this._color = color;
        this._raza = raza;
        this._edad = edad;
    }

    public void Ladrar()
    {
        Console.WriteLine("Guau Guau" + _nombre);
    }

    public void Dormir()
    {
        Console.WriteLine("zzzzzz");
    }

    public void Comer()
    {
        Console.WriteLine("zzzzzz");
    }



    //METODOS
}
