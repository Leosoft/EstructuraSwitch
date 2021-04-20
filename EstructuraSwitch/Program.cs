using System;

namespace EstructuraSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;

            Console.WriteLine("\tMENU");
            Console.WriteLine("\t----\n");
            Console.WriteLine("Opcion 1");
            Console.WriteLine("Opcion 2");
            Console.WriteLine("Opcion 3");
            Console.WriteLine("Opcion 4\n");
            Console.WriteLine("Selecciona una opcion");

            opcion = Convert.ToInt16(Console.ReadLine());
            

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Elegiste la primera opcion");
                    break;
                case 2:
                    Console.WriteLine("Elegiste la segunda opcion");
                    break;
                case 3:
                    Console.WriteLine("Elegiste la tercera opcion");
                    break;
                case 4:
                    Console.WriteLine("Elegiste la cuarta opcion");
                    break;
                default:
                    Console.WriteLine("OPCION INCORRECTA");
                    break;
            }



            Console.ReadKey();
        }
    }
}
