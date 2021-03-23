using System;

namespace examen_parte_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("regristro de sueldo \n ingrese los nombre de los enpleados ");

            string A = Convert.ToString(Console.ReadLine());
            Console.WriteLine("sigiente");
            string b = Convert.ToString(Console.ReadLine());
            Console.WriteLine("sigiente");
            string c = Convert.ToString(Console.ReadLine());
            Console.WriteLine("sigiente");
            string d = Convert.ToString(Console.ReadLine());
            Console.WriteLine("sigiente");
            string e = Convert.ToString(Console.ReadLine());
            Console.WriteLine("sigiente");

            Console.WriteLine("introduzca sueldo de cada uno");
            int[] datos = new int[5];
            int i, mayor = 0, j = 0;


            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("dijite el valor de la posiscion {0}", (i + 1));
                datos[i] = Convert.ToInt32(Console.ReadLine());
            }

            while (j < 5)
            {
                if (datos[j]> mayor)
                        mayor = datos[j];
                j++;
            }
            Console.WriteLine("el mayor suledo es : {0}",mayor);


            Console.WriteLine("..................................");

            Console.WriteLine("los enpleados son ");
            Console.WriteLine(A 
                + " ............."
                + b
                + ".............."
                + c
                + ".............."
                + d
                + ".............."
                + e);
                

        }
    }
}
