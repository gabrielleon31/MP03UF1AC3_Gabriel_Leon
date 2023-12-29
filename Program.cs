using System;

class Program
{
    static void Main()
    {

        //Codifica un programa que demani 6 números a l’usuari i després els imprimeixi de manera inversa.
        int[] numeros = new int[6];

        Console.WriteLine("Introduce 6 números:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros en orden inverso:");

        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }

        //Codifica un programa que prepari espai per desar un màxim de 100 noms. 
        //L'usuari haurà d'anar introduint un nom cada cop, fins que es teclegi stop, moment en què deixaran de demanar-se més noms i es mostrarà a la pantalla la llista dels noms que s'han introduït. 

        string[] nombres = new string[100];
        int contador = 0;

        Console.WriteLine("Introduce nombres (escribe 'stop' para terminar):");

        while (true)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            if (nombre.ToLower() == "stop" || contador >= 100)
                break;

            nombres[contador] = nombre;
            contador++;
        }

        Console.WriteLine("\nLista de nombres introducidos:");

        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine(nombres[i]);
        }

        //Codifica un programa que emmagatzemi en una taula el nombre de dies que té cada mes, demaneu a l'usuari que us indiqui un mes (1=gener, 12=desembre) 
        //i mostri a la pantalla el nombre de dies que té aquest mes. 
        
        int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.Write("Introduce el número del mes (1=enero, 12=diciembre): ");
        int mes = Convert.ToInt32(Console.ReadLine());

        if (mes >= 1 && mes <= 12)
        {
            int dias = diasPorMes[mes - 1];
            Console.WriteLine($"El mes {mes} tiene {dias} días.");
        }
        else
        {
            Console.WriteLine("Mes no válido.");
        }

        //Codifica un programa que permita al usuario ingresar 7 valores decimales y luego muestre esos valores ordenados de mayor a menor. 

        double[] valores = new double[7];

        Console.WriteLine("Introduce 7 valores decimales:");

        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            valores[i] = Convert.ToDouble(Console.ReadLine());
        }

        Array.Sort(valores);
        Array.Reverse(valores);

        Console.WriteLine("\nValores ordenados de mayor a menor:");

        foreach (var valor in valores)
        {
            Console.WriteLine(valor);
        }

        //Codifica un programa que solicite al usuario el ingreso de 10 números y determine cuántos de ellos son pares. 

        int[] numeros = new int[10];
        int pares = 0;

        Console.WriteLine("Introduce 10 números:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                pares++;
            }
        }

        Console.WriteLine($"Cantidad de números pares: {pares}");

    }
}

