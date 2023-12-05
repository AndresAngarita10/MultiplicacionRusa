// See https://aka.ms/new-console-template for more information

//Punto 1
using System.Data;

Console.WriteLine("Multiplicacion Rusa!");
/* int numero = 10;
if (numero%2==0)
{
    Console.WriteLine("Par");
} */
int Rta = 0; bool impar;; bool mostrar = false;
Console.WriteLine("Ingrese el Multiplicador!");
int Multiplicador = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el Multiplicando!");
int Multiplicando = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Multiplicador  Multiplicando  Multiplicador-Impar  ");

while (Multiplicador > 0)
{
    if(Multiplicador %2 != 0)
    {
        impar = true;
        mostrar = true;
        Rta += Multiplicando;
    }else 
    {
        mostrar = false;
        impar = false;
    }
    Console.WriteLine(Multiplicador + "               " + Multiplicando + "                " + impar + "         " /* + mostrar ? Rta : "-" */);
    if (impar == true)
    {
        Console.WriteLine("  ");
        Console.WriteLine("Suma: "+Rta);
        Console.WriteLine("  ");
    }
    Multiplicador /= 2;
    Multiplicando *= 2;
}



