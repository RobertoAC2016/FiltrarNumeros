//Codigo para introducir numeros manualmente y filtrarlos


List<int> numeros = new List<int>();
bool continuar = true;
while (continuar && numeros.Count < 10)
{
    Console.Write("Ingrese un numero:");
    var input = Console.ReadLine();
    try
    {
        numeros.Add(int.Parse(input));
    }
    catch
    {
        Console.WriteLine("Opcion no valida");
    }
    Console.Write("Desea seguir ingresando numeros S/N?\n\nolo se permiten Maximo 10\n\nEscriba: ");
    var opc = Console.ReadLine();
    if (!opc.Equals("S"))
        if (opc.Equals("N"))
            continuar = false;
        else
            Console.WriteLine("Opcion no valida");
    Console.Clear();
}
//Lista antes de eliminar los numeros mayores a 15
foreach (var numero in numeros)
    Console.WriteLine(numero);


//  Con la siguiente funcion de quierie usando LinQ se puede filtrar rapidamente
numeros = numeros.Where(
    x => x < 15                 //esta es un funcion lampda requerida dentro de linq para hacer su funcion de filtrado
    ).ToList();



Console.WriteLine();
//Lista despues de eliminar los numeros mayores a 15
foreach (var numero in numeros)
    Console.WriteLine(numero);

