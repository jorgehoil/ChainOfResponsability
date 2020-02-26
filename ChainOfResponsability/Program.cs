using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Procesador proc = new Procesador();
            Console.WriteLine("Ingrese el concepto de la compra");
            string cConcepto = Console.ReadLine();
            Console.WriteLine("Ingrese el importe de la compra");
            double dImporte = Convert.ToDouble(Console.ReadLine());
            proc.procesar(dImporte,cConcepto);
            Console.ReadKey();
        }
    }
}
