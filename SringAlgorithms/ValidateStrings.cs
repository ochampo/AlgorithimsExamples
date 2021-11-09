using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SringAlgorithms
{
    public class ValidateStrings
    {

     public Boolean IsUppercase(string s)
        {
         return s.All(char.IsUpper);
        }

      public  Boolean IsLowercase(string s)
        {
            
                return s.All(char.IsLower);
        }
                




    }
}
