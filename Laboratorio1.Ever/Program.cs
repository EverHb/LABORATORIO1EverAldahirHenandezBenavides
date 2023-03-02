using LABORATORIO1EverAldahirHernandezBenavides.Entidades;
using LABORATORIO1EverAldahirHernandezBenavides.Negocio;
using System.Drawing;


Persona personas = new Persona ();
ClsPersona clsPersonas = new ClsPersona(); 


Console.WriteLine("Ingrese su nombre");
string Nombre = Console.ReadLine();


Console.WriteLine("Ingrese su edad");
string Edad = Console.ReadLine();
int E = Convert.ToInt32(Edad);


Console.WriteLine("Ingrese su sexo,M(Hombre),M(MUJER)");
string Sexo = Console.ReadLine();


Console.WriteLine("Ingrese su peso");
string Peso = Console.ReadLine();
int P = Convert.ToInt32(Peso);


Console.WriteLine("Ingrese su altura");
string Altura = Console.ReadLine();
double A = Convert.ToDouble(Altura);


personas.Nombre = Nombre;
personas.Edad = E;
personas.Peso = P;
personas.Altura = A;


String Resultado = clsPersona.calcularIMC(personas);
Console.WriteLine(Resultado);


String Result = clsPersona.EsMayorDeEdad(personas);
Console.WriteLine(Result);

