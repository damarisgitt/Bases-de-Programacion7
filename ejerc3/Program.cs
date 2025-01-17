using System;

namespace ejerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            //HACER UNA FUNCION LLAMADA "PAR" QUE RECIBA UN NUMERO ENTERO Y DEVUELTA "1" SI ES PAR O "0" SI NO LO ES.
            //HACER UNN PROGRAMA PARA INGRESAR 20 NUMEROS Y MOSTRAR POR PANTALLA CUANTOS SON PARES.
             
            int contador, n, sino;
            contador = 0;

            for (int x = 0; x < 20; x++){
              Console.WriteLine("INGRESE UN NUMERO");
              n = int.Parse(Console.ReadLine());

              sino= Par(n);

              if(sino == 1){
                contador++;}
            }

            Console.WriteLine("DE LOS 20 NUMEROS QUE INGRESASTE: " + contador + " SON PARES");
            
        }
        static int Par(int A){
            if(A % 2 == 0){
                return 1;
            }else{
                return 0;
            }
        }
    }
}
