using System;

namespace ejerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            // HACER UNA FUNCION LLAMADA "SUMARESTA" QUE RECIBA DOS NUMEROS Y QUE DEVUELVA LA SUMA Y LA RESTA DEL PRIMER NUMERO CON 
            // CON EL SEGUNDO.

            int n1, n2, n3, suma;
            n3 = 0;

            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());

            suma = sumar(n1, n2, ref n3);

            Console.WriteLine("EL VALOR DE LA SUMA DEL PRIMER NUMERO CON EL SEGUNDO ES: " + suma);
            Console.WriteLine("EL VALOR DE RESTAR EL PRIMER NUMERO CON EL SEGUNDO ES: " + n3);

        }

        static int sumar(int n1, int n2, ref int n3){
           int r;
           r = n1 + n2;
           n3 = n1 - n2;
           return r;
        }
        
        
    }
}
