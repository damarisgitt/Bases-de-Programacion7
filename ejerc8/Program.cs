using System;

namespace ejerc8
{
    class Program
    {
        static void Main(string[] args)
        {
          // HACER UN PROGRAMA QUE PERMITA INGRESAR UNA LISTA DE NUMEROS QUE CORTA CUANDO SE INGRESA UN CERO. 
          //A PARTIR DE DICHOS DATOS INFORMAR:
          // A. EL MAYOR DE LOS NUMEROS PARES.
          // B. LA CANTIDAD DE NUMEROS IMPARES.
          // C. EL MENOR DE LOS NUMEROS PRIMOS.
          // HACER USO DE LAS FUNCIONES ANTERORMENTE DESARROLLADAS.

          int NUMEROS, impares, mayor, maximopar, banderapar, banderaprimo, menorprimo, menor;
          
          banderapar = 0;
          maximopar = 0;
          impares = 0;
          banderaprimo = 0;
          menorprimo = 0;

          Console.WriteLine("INGRESA NUMEROS, Y CERO CUANDO YA NO MAS");
          NUMEROS = int.Parse(Console.ReadLine());


         while(NUMEROS != 0){

            mayor = mayorpares(NUMEROS);

                if(mayor == 1){
                    if(banderapar == 0){
                        maximopar = NUMEROS;
                        banderapar = 1;
                    }else if(NUMEROS > maximopar){
                        maximopar = NUMEROS;
                    }
                }else{
                    impares++;
                }

            menor = primo(NUMEROS);
                if(menor == 1){
                    if(banderaprimo == 0){
                        menorprimo = NUMEROS;
                        banderaprimo = 1;
                    }else if(NUMEROS < menorprimo){
                        menorprimo = NUMEROS;
                    }
                }
            

                Console.WriteLine("INGRESA NUMEROS, Y CERO CUANDO YA NO MAS");
                NUMEROS = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("DE TODOS LOS NUMEROS QUE INGRESASTE, EL MAYOR DE LOS NUMEROS PARES ES: " + maximopar);
            Console.WriteLine("DE TODOS LOS NUMEROS QUE INGRESASTE: " + impares + " SON IMPARES");
            Console.WriteLine("DE TODOS LOS NUMEROS QUE INGRESASTE: EL MENOR PRIMO ES: " + menorprimo);
              
        }    
              
            static int mayorpares(int n){
            if(n % 2 == 0){
                return 1;
            }else{
                return 0;
            }
            }

            static int primo(int A){
            int contador; 
            contador = 0;
            for(int x = 1; x <= A; x++){
                if (A %  x == 0){
                    contador++;
                }
            }
            if(contador == 2){
                return 1;
            }else{
                return 0;
            }

        }
    }
}
