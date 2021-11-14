using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAlgorithms
{
    public class LinerSearch
    {
        //with constructor WIP
        //public  LinerSearch(ref int[] input, ref int n)
        // {


        // }


        // public int? FindValue()
        // {
        //     int[] input =null;
        //     int n = 0;
        //     LinerSearch linerSearch = new LinerSearch(ref input, ref n);

        //     foreach (int current in input)
        //     {

        //         if (n == current)
        //         {
        //             return n;
        //         }
        //     }

        //     return null;


        // }


        public int? LinerSearchFindingData(int[] input, int n)
        {
            foreach (int current in input)
            {
                if (n == current)
                {
                    return n;
                }

            }
            return null;

        }




    }
}
