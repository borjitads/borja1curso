using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1cesap
{
    class Program
    {
        static void Main(string[] args)
        { 
            //tipos de variables
            
            /* 
             * esto es un comentraio
             * de muchas lineas
             */ 
             

             byte n1 =0;
             short n2 = 1;
            int n3 = n2 + n1; //(integer)
            long n4;
   //LAS VARIABLES NO ESTAN INICIALIZADAS

            Console.WriteLine(n1); //Al parecer los comandos tipo "console" deben escribirse con la prime letra en mayuscula 




          
            // COn string utilizar la funcion Parse
            n2 = (short)n3;

            n1 = Convert.ToByte(n2);
            String telefono = "986755432";
                short numtelefono = Int16.Parse(telefono);
            int numtelefono2 = Int32.Parse(telefono);


            //Numeros decimales
            float n5 = 9.5f; //(single) Convertir un numero decimal a float
            double n6;
            double n7;

         

            bool n8;
            char n9;
            string n10; String n105; //con la primera letra en mayuscala supuestamente solo vcambia en color, es lo que se por ahora

            float nota1, nota2, nota3, media;
            Console.WriteLine("Nota 1: ");
            nota1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            nota2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Nota 3: ");
            nota3 = Single.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) /3;

            Console.WriteLine("La media 1 es: " + media);

            if (media >= 5)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Suspenso");
            }

            Console.ReadLine();

            //Operadores c# diferentes a VB
            //operdor Mod es %
            int resto = 10 % 2; // Resto de 10 entre 2
            // Operador incrementado: ++ y decrementado --
            int x = 1;
            int y = ++x;
            int z = --x;



            //operador de comparacion ==

            if (z == 0)
            {


            }
            // y logico &&
            //O logico ||
            //not Logico !



        }
    }
}
