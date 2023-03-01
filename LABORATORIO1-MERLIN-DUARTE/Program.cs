using LABORATORIO1_MERLIN_DUARTE.Entidades;
using LABORATORIO1_MERLIN_DUARTE.Negocio;

Console.WriteLine("Escribe tu nombre: ");
String nombre = Console.ReadLine();

Console.WriteLine("Escribe tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escribe tu sexo: ");
String sexo = Console.ReadLine();

Console.WriteLine("Escribe tu peso: ");
Double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escribe tu altura: ");
Double altura = Convert.ToDouble(Console.ReadLine());

Persona persona = new Persona();
persona.nombre = nombre;
persona.edad = edad;
persona.sexo = sexo;
persona.peso = peso;
persona.altura = altura;

ClsPersona clsP = new ClsPersona();

Console.WriteLine("\n" + clsP.calcularIMC(persona));
Console.WriteLine("\n" + clsP.esMayorDeEdad(persona));
