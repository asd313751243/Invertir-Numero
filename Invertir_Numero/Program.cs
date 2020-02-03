using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertir_Numero
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool identificar;
            bool repetir = true;
            while (repetir == true)
            {
                String valor = "";
                String rolav = "";
                short total = 0;

                Console.WriteLine("Inserta un numero de dos digitos");
                valor = (Console.ReadLine());
                for (int i = valor.Length - 1; i >= 0; i--)
                {
                    rolav += valor[i];
                }
                
                identificar = short.TryParse(rolav, out total);

                if(identificar == true)
                {
                    total = short.Parse(rolav);

                    if (total > 9 && total < 100)
                    {
                        repetir = false;
                        Console.WriteLine(rolav);
                    
                    }  
                }
            }
            Console.ReadKey();
        }
    }
}
