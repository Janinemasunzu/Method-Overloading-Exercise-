using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int a, int b) 
        { 
            return a + b;
        }


        public static decimal Add(decimal c, decimal d) 
        {   
            return c + d;
        }

        public static string Add(int e, int f, bool withDollars) 
        {
            if (withDollars && (e + f) != 1)
            { 
                return $"{e + f} dollars";
            }
            else if(withDollars && (e + f) == 1) 
            { 
                return $"{e + f} dollar";
            
            }
            else 
            { 
                return $"{e + f}";
            }
        }
        
    }
}
