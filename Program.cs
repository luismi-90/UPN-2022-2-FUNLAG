// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
bool esPrimo;
int n = 100;
string primos = "";
for (int x = 2; x <= n; x++)
{
    esPrimo = true;
    for (int y = 2; y < x; y++)
    {
        if (x % y == 0)
        {
            esPrimo = false;
            break;
        }
    }
    if (esPrimo) primos += x + "-";
}
Console.WriteLine("Los numeros primos son: " + primos);
Console.ReadKey();