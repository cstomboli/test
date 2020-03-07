using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Class1
    {
        private string a;
        private string b;

        public Class1(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public int Solutions()
        {
            a = a.ToLower();
            b = b.ToLower();
            //if (a.Length >= b.Length)
            //{
                
            /*for(int i=0; a.Length>=i; )
                {

                   */
                    Console.WriteLine("la contiene{0}", a.Length);
                    Console.WriteLine("la contiene{0}", b.Length);
                    if (String.Compare(a, b, true) == 0) //Esto compara si es exactamente esa palabra!
                    {
                        Console.WriteLine("la contiene");
                    }
                    
                    //break;
                
                
                /*
                Console.WriteLine("la contiene{0}", a.Length);
                Console.WriteLine("la contiene{0}", b.Length);
                for (int i = b.Length; a.Length >= i; i++)
                {
                    Console.WriteLine("la for{0}",a.Length);
                    Console.WriteLine("la for{0}",i);
                    if (String.Compare(a,b)==0)
                    {
                        Console.WriteLine("la contiene");
                    }
                    bool result = a.Equals(b);
                    if (result)
                    {
                        Console.WriteLine("la contiene");
                    }
                    else
                    {
                        Console.WriteLine("No la contiene");
                    }
                    // if(strcmp())
                    
                }*/

           // }

            /* Esto no me anda!!
            while(b.Length<=0)
            {
                if (String.Compare(a, b) == 0)
                {
                    Console.WriteLine("la contiene");
                }

            }*/
            
            return 0;

        }
    }
}
