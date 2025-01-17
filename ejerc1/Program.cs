using System;

namespace ejerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            // HACER UNA FUNCION LLAMADA "PRODUCTO" QUE RECIBA DOS NUMEROS ENTEROS Y QUE DEVUELVA EL PRODUCTO DE AMBOS.
            // LUEGO HACER UN PROGRAMA QUE PIDA EL PRECIO DE UN ARTICULO Y LA CANTIDAD VENDIDA  Y MUESTRE POR PANTALLA 
            // EL MONTO TOTAL A PAGAR. USAR LA FUNCION.

            int precio, cantidad, producto;

            Console.WriteLine("INGRESE EL PRECIO DEL ARTICULO");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA CANTIDAD VENDIDA");
            cantidad = int.Parse(Console.ReadLine());

            producto = produc(precio, cantidad);

            Console.WriteLine("EL MONTO TOTAL A PAGAR ES DE: " + producto + "");


        }
        static int produc(int n1, int n2){
            int r;
            r = n1 * n2;
            return r;
        }
    }

}
