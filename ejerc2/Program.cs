using System;

namespace ejerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            // HACER UNA FUNCION LLAMADA "MAYOR", QUE RECIBA DOS NUMEROS ENTEROS Y DEVUELVA EL MAYOR DE ELLOS 
            // O "CERO" SI SON IGUALES.

            int N1, N2, RESULTADO;
            Console.WriteLine("INGRESARAS DOS NUMEROS Y TE DEVOLVERE EL MAYOR DE ELLOS, O TE DEVOLVERE CERO, EN CASO DE QUE SEAN IGUALES");
            Console.WriteLine("INGRESE UN NUMERO");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE OTRO NUMERO");
            N2 = int.Parse(Console.ReadLine());

            RESULTADO = mayor(N1, N2);

            Console.WriteLine("EL MAYOR DE ELLOS FUE: " + RESULTADO + "");
        }

        static int mayor(int a, int b){
            if(a == b){
                return 0;
            }else if(a > b){
                return a;
            }else{
                return b;
            }
        }
    }
}
