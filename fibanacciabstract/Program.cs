using fibanacciabstract;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество чисел в ряду: ");
        IFibanacci.Fibanacci<dynamic>(Convert.ToInt64(Console.ReadLine()));
        
    }
}