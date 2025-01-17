using System;

namespace ejerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un 
            //número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:

            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.

            // hacer un programa main que permita ingresar 100 numeros y emita por pantalla cuantos son positivos, cuantos negativos,
            // y cuantos ceros.

            int positivos, negativos, ceros, numeros;
            positivos = 0;
            negativos = 0;
            ceros = 0;
        
            for (int x = 0; x < 100; x++){

                Console.WriteLine("INGRESE UN NUMERO");
                numeros = int.Parse(Console.ReadLine());
                  
                  int estado = 0;

                  positivonegativocero(numeros, ref estado);

                 switch(estado){
                    case 0:
                    ceros++;
                        break;
                    case 1:
                    positivos++;
                        break;
                    case -1:
                    negativos++;
                        break;
                 }
            }

            Console.WriteLine("DE LOS 100 NUMEROS: " + positivos + " SON POSITIVOS");
            Console.WriteLine("DE LOS 100 NUMEROS: " + negativos + " SON NEGATIVOS");
            Console.WriteLine(" DE LOS 100 NUMEROS: " + ceros + " SON CEROS");


        }
           
            static void positivonegativocero(int n, ref int estado){

            if(n == 0){
                estado = 0;
            }else if(n > 0){
                estado = 1;
            }else{
                estado = -1; 
            }
        }
    }
}
