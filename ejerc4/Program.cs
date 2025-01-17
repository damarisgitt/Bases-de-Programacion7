using System;

namespace ejerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            // HACER UNA FUNCION LLAMADA "PRIMO" QUE RECIBA UN NUMERO ENTERO, Y DEVUELVA "1" SI EL NUMERO ES PRIMO
            // O "0" SI NO LO ES.
            // HACER UN PROGRAMA PARA INGRESAR NUMEROS. EL LOTE CORTA CUANDO SE INGRESA UN NUMERO "0". INFORMAR EL PROMEDIO
            // TENIENDO EN CUANTA SOLO LOS NUMEROS PRIMOS.

            int N, contad, acumul, resultado, promedio; 
            
            contad = 0;
            acumul = 0;
            promedio = 0;

            Console.WriteLine("INGRESE UN NUMERO, Y CERO CUANDO NO VA A INGRESAR MAS NUMEROS");
            N = int.Parse(Console.ReadLine());

            while(N != 0){
                resultado = primo(N);
                if(resultado == 1){
                    contad++;
                    acumul += N;
                }

             Console.WriteLine("INGRESE UN NUMERO, Y CERO CUANDO NO VA A INGRESAR MAS NUMEROS");
             N = int.Parse(Console.ReadLine());
                
            }
            
            promedio =  acumul / contad;

            Console.WriteLine("EL PROMEDIO DE NUMEROS PARES ES DE: " + promedio + " DE TODOS LOS NUMEROS QUE ME INGRESASTE");

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
