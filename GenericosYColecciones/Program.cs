using GenericosYColecciones;

int[] enteros = { 1, 2, 3 };

string[] nombres = { "Felipe", "Claudia", "Pedro", "Janna" };

DateTime[] fechas = { DateTime.Today, DateTime.Today.AddDays(1) };

Console.WriteLine($"logitus de arreglos de enteros {CalcualrLongitudArray(enteros)}");
Console.WriteLine($"logitus de arreglos de enteros {CalcualrLongitudArray(nombres)}");
Console.WriteLine($"logitus de arreglos de enteros {CalcualrLongitudArray(fechas)}");

Console.WriteLine($"El primer elemento del arreglo es: {PrimerElementoOValorPorDefecto(enteros)}");
Console.WriteLine($"El primer elemento del arreglo es: {PrimerElementoOValorPorDefecto(nombres)}");
Console.WriteLine($"El primer elemento del arreglo es: {PrimerElementoOValorPorDefecto(fechas)}");


//Se usa "T", como una convecion, ya que viene de Type o tipo
int CalcualrLongitudArray<T>(T[] arreglo)
{
    return arreglo.Length;
}


T? PrimerElementoOValorPorDefecto<T>(T[] arreglo)
{
    if (arreglo.Length == 0)
    {
        return default;
    }

    return arreglo[0]; 
}


var utilidadesArregloStrings = new UtilidadesArreglos<string>();
utilidadesArregloStrings.PrimerElementoOValorPorDefecto(nombres);


////Listas
///

List<int> enterosLista = new List<int>();
enterosLista.Add(1);
enterosLista.Add(5);
enterosLista.Add(15);
Console.WriteLine();

List<int> enterosLista2 = new List<int>() { 1, 5, 15 };
// var enterosLista2 = new List<int>() { 1, 5, 15 };
// List<int> enterosLista2 = new() { 1, 5, 15 };

var cantidad = enterosLista2.Count; //como length de una arreglo

enterosLista2[1] = 75; //modificando el valor de un indice de una lista


//remover elementos de una lista 

enterosLista2.Remove(15);   //remover el elemento de valor
 
enterosLista2.RemoveAt(0);  //remover el elemento respecto a su indice

enterosLista2.Clear(); //limpiar toda la lista


//ordenar elemetos de la lista

enterosLista2.Sort();


//Diccionarios

//inicializar un diccionario
Dictionary<string, int> diccionario = new Dictionary<string, int>();

var diccionario2 = new Dictionary<string, int>()
{
    { "Uno", 1 },
    { "Dos", 2 },
    { "Tres", 3 }
};


//formas de agregar valores a un diccionario
diccionario.Add("uno", 1); //Solamente agregar
diccionario["Dos"] = 2; //Agregar y modificar valores

//verificar si la llave esta dentro del diccionario

if (diccionario.ContainsKey("Tres"))
{
    Console.WriteLine(diccionario["Tres"]);
}
else
{
    Console.WriteLine("La llave no se encuentra en el diccionario");
}

Console.WriteLine("Llaves:");
foreach (var llave in diccionario.Keys)
{
    Console.WriteLine(llave);
}

Console.WriteLine();

Console.WriteLine("Valores:");
foreach (var valor in diccionario.Values)
{
    Console.WriteLine(valor);
}

Console.WriteLine();

var diccionarioParimpar = new Dictionary<string, List<int>>();
diccionarioParimpar.Add("Par", new List<int>());
diccionarioParimpar.Add("Impar", new List<int>());

diccionarioParimpar["Par"].Add(12);
//Console.WriteLine(diccionarioParimpar["Par"]);

for (int i = 1; i <= 10; i++)
{
    var llave = i % 2 == 0 ? "Par" : "Impar";
    diccionarioParimpar[llave].Add(i);
}


foreach (var llaveValores in diccionarioParimpar)
{
    Console.WriteLine(llaveValores.Key);
    foreach (var valor in llaveValores.Value)
    {
        Console.WriteLine($" - {valor}");
    }
}

var par = diccionarioParimpar["Par"];
var impar = diccionarioParimpar["Impar"];