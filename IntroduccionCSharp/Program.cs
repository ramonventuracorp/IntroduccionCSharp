// RAMON HUMBERTO VENTURA RODRIGUEZ
// Lugar de residencia: Comayagua
// COMIDA FAVORITA: Papas fritas

// LINK PARA PRACTICAR COMANDOS: https://ohmygit.org/

// TIPOS DE DATOS EN C#
int numeroEntero = 10;
string texto = "Hola, Mundo!";
double numeroDecimal = 3.14;
decimal numeroDecimalMasPreciso = 19.99m;
bool valorBooleano = true;
DateTime fechaActual = DateTime.Now;

// IMPRESION EN CONSOLA (Concatenacion)
Console.WriteLine("Impresion con concatenacion");
Console.WriteLine("Valor de tipo entero: " + numeroEntero);
Console.WriteLine("Valor de tipo string: " + texto);
Console.WriteLine("Valor de tipo double: " + numeroDecimal);

// Impresion en consola (format)
Console.WriteLine("");
Console.WriteLine("Impresion con string.format");
Console.WriteLine(string.Format("Valor de tipo entero: {0}", numeroEntero));
Console.WriteLine(string.Format("Valor de tipo string: {0}", texto));
Console.WriteLine(string.Format("Entero {0} y Decimal {1}", numeroEntero, numeroDecimal));

// Impresion con template string o interpolacion
Console.WriteLine("");
Console.WriteLine("Impresion con interpolacion");
Console.WriteLine($"Valor de tipo entero: {numeroEntero}");
Console.WriteLine($"Valor de tipo string: {texto}");
Console.WriteLine($"Valor de tipo double: {numeroDecimal}");

// OPERADORES

// Operador de suma
int suma = 2 + 3;
int resta = 3 - 2;
int division = 6 / 2;
int residuo = 6 % 2;

Console.WriteLine("");
Console.WriteLine("Estructuras condicionales");
// Estructuras condicionales
if (suma > 0)
{
    Console.WriteLine("La suma es mayor a cero");
}

if (resta == 0)
{
    Console.WriteLine("La resta ha sido 0");
}else
{
    Console.WriteLine("La resta ha sido distinta a 0");
}

// Switch 
Console.WriteLine("");
Console.WriteLine("Estructura switch");

int dia = 10;

switch (dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    default:
        Console.WriteLine("Otro dia");
        break;

}

// Bucles 
Console.WriteLine("");
Console.WriteLine("Bucles");

// FOR
for (int x = 0; x < 5; x++)
{
    Console.WriteLine($"Valor del numero: {x}");
}

//WHILE
int contador = 0;
while (contador <= 10)
{
    Console.WriteLine($"Valor de contador: {contador}");
    contador ++;
}


// Arreglos 
Console.WriteLine("");
Console.WriteLine("Arreglos");

int[] numeros = [1, 2, 3, 4, 5];
string[] personajes = ["Goku", "Naruto", "Vegeta", "Luffy"];

// FOR EACH
Console.WriteLine("");
Console.WriteLine("FOR EACH");

// Imprimir numeros
foreach (var numero in numeros)
{
    Console.WriteLine($"Valor de numero: {numero}");
}

// Imprimir personajes
foreach (var personaje in personajes)
{
    Console.WriteLine($"Nombre del personaje: {personaje}");
}

// LISTAS
Console.WriteLine("");
Console.WriteLine("Listas");

List<int> listaEnteros = [1, 2, 3];
List<string> listaPersonajes = ["Goku", "Vegeta", "Naruto"];

foreach (var entero in listaEnteros)
{
    Console.WriteLine($"Valor del entero: {entero}");
}

listaPersonajes.Add("Gaara");

foreach (var personaje in listaPersonajes)
{
    Console.WriteLine($"Nombre del personaje: {personaje}");
}

// Funciones
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("FUNCIONES");
ImprimirMensaje();
int sumaDeNumeros = SumarNumeros(2, 5);
Console.WriteLine(sumaDeNumeros);

// Funcion sin valor de retorno
void ImprimirMensaje()
{
    Console.WriteLine("Imprimiendo mensaje desde funcion.");
}

// Funcion con valor de retorno
int SumarNumeros(int numero1, int numero2) {

    int suma = numero1 + numero2;
    return suma;
}

