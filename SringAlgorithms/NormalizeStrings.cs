using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SringAlgorithms
{
    public class NormalizeStrings
    {
        public string NormalizeStr(string input)
        {
            //  string lowercased= input.ToLower();
            // string trimmed = lowercased.Trim();
            // return trimmed.Replace(" ", "");

            return input.ToLower().Trim().Replace(",", "");

        }



    }
}
