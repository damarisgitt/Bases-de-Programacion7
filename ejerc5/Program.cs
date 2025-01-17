using System;

namespace ejerc5
{
    class Program
    {
        static void Main(string[] args)
        {
            //HACER UNA FUNCION LLAMADA PAGOS, QUE RECIBA UN MONTO FLOAT, Y UNA CANTIDAD DE PAGOS (ENTEROS)
            //Y DEVUELVA EL MONTO DE CADA PAGO.
            // HACER UN PROGRAMA PARA INGRESAR 10 VENTAS. PARA CADA VENTA SE CONOCE
            // EL MONTO Y LA CANTIDAD DE PAGOS. EL PROGRAMA DEVERA MOSTRAR LA CANTIDAD DE PAGOS Y EL MONTO DE PAGO
            // PARA CADA UNA DE LAS VENTAS.

            int CANTIDAD;
            float MONTO, RESULTADO;

            for(int x = 0; x < 10; x++){
            
                Console.WriteLine("INGRESA EL MONTO DE TU COMPRA");
                MONTO = int.Parse(Console.ReadLine());
                Console.WriteLine("INGRESA LA CANTIDAD DE PAGOS");
                CANTIDAD = int.Parse(Console.ReadLine());

                RESULTADO = pagos(MONTO, CANTIDAD);

                Console.WriteLine("LA CANTIDAD DE PAGOS QUE DEBE REALIZAR ES: " + CANTIDAD + " DE: " + RESULTADO + "");
                }

        }
             static float pagos(float a, int b){
             return a / b;
             
             }
    }
}
