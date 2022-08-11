using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static semana3_proyecto_de_menu_con_estructuras.Ejemplo_If;
using static semana3_proyecto_de_menu_con_estructuras.Ejemplo_Switch;
using static semana3_proyecto_de_menu_con_estructuras.Ejemplo_For;
using static semana3_proyecto_de_menu_con_estructuras.Ejemplo_DoWhile;
using static semana3_proyecto_de_menu_con_estructuras.Ejemplo_While;


namespace semana3_proyecto_de_menu_con_estructuras
{
    class Principal
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Proyecto de Menu");
            System.Console.WriteLine("Primer Programa Usando Estructuras");
            System.Console.WriteLine("Presione ENTER para continuar");

            System.Console.ReadKey();

            int repetir;

            do
            {
                Console.Clear();
                menu_interno();

                System.Console.WriteLine("Ingrese 1 para repetir menú");
                System.Console.WriteLine("Ingrese 2 para salir del menú");
                repetir = Int32.Parse(Console.ReadLine());

            } while (repetir == 1);

        } 

        static void menu_interno()
        {
            string opcion;
            int opcionint;

            System.Console.WriteLine("Menú Principal");
            System.Console.WriteLine("1-) Ejemplo If");
            System.Console.WriteLine("2-) Ejemplo Switch");
            System.Console.WriteLine("3-) Ejemplo For");
            System.Console.WriteLine("4-) Ejemplo Wor");
            System.Console.WriteLine("5-) Ejemplo Do While");

            System.Console.WriteLine("Selecciona tu opcion: ");
            opcion = Console.ReadLine();
            opcionint = Int32.Parse(opcion);

            switch (opcionint)
            {
                case 1:

                    programa_if();

                    break;

                case 2:

                    programa_switch();
                    break;

                case 3:

                    programa_for();
                    break;

                case 4:

                    programa_while();
                    break;
                case 5:

                    programa_dowhile();
                    break;

                default:
                    System.Console.WriteLine("opcion no valida");
                    break;

            }

        }

        static void programa_if()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo If");

        }

        static void programa_switch()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo Switch");
        }

        static void programa_for()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo For");
        }

        static void programa_while()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo While");
        }

        static void programa_dowhile()
        {
            System.Console.WriteLine("Aqui llamo el ejemplo DoWhile");
        }

    }
}
