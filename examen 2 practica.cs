using System;

namespace examen_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // atributos y produdctos 
            
                productos cosa1 = new productos();

                cosa1.nombre = "cocacola";
                cosa1.precio = 25;
                cosa1.exitencia = 3;

                productos cosa2 = new productos();

                cosa2.nombre = "galletas atuey";
                cosa2.precio = 15;
                cosa2.exitencia = 10;

                productos cosa3 = new productos();
                cosa3.nombre = "fanta naranja";
                cosa3.precio = 30;
                cosa3.exitencia = 3;

            
            // funcionamiento del programa 

            Console.WriteLine("bienbenido a maquinas dispensadoras del itla");

            Console.WriteLine("selecione 1 de tres productos\n cocacola (25)=1\n galletas(15)=2\n fanta(30)=3\n o pulse 4 para ver ociones adminstrativas ");

            int producto = Convert.ToInt32(Console.ReadLine());

            switch (producto)
            {
                case 1: Console.WriteLine("haz eliegido "
                    + cosa1.nombre 
                    + "por"
                    + cosa1.precio); break;

                case 2: Console.WriteLine("haz alegido"
                    + cosa2.nombre 
                    +"por"
                    + cosa2.precio);break;


                case 3: Console.WriteLine("haz alegido" 
                    + cosa3.nombre 
                    + "por" 
                    + cosa3.precio); break;

                case 4: Console.WriteLine("informacion de la maquina\n exitencia " 
                    + cosa1.nombre
                    +",exitencia de "
                    + cosa1.exitencia
                    + "............................"
                    + cosa2.nombre
                    +",exintencia de "
                    + cosa2.exitencia
                    + "....................."
                    + cosa3.nombre
                    +",exintencia de "
                    + cosa3.exitencia);break;

                default: Console.WriteLine("ELIJA UNA OBCION VALIDA");break;
            }
            

            


        }
    }
}
