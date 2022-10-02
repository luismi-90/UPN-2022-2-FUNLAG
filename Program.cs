int f, c;
string n;
Console.Write("Ingrese numero de COLUMNAS: ");
f = int.Parse(Console.ReadLine());
Console.Write("Ingrese numero de FILAS: ");
c = int.Parse(Console.ReadLine());
Console.Write("Ingrese el numero a mostar: ");
n = (Console.ReadLine());
for (int i = 0; i < c; i++)
{
    for (int j = 0; j < f; j++)
    {
        Console.Write("" + n + "");
    }
    Console.Write("\n");
}