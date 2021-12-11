using hashBasedStructures.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashBasedStructures
{
    public class Findemployee
    {
        Dictionary<int, Employee> employeeById = new Dictionary<int, Employee>();
        


        public Dictionary<int, Employee> searchForemployee( Employee employee)
        {

            employeeById.Add(employee.id, employee);

            return employeeById;


        }


        public static List<int> findMissingElements(int [] first, int[] second)
        {
            var list = new List<int>();
            var secondArrayElements = new HashSet<int>();  

            foreach(int item in second)
            {
                secondArrayElements.Add(item);
            }

            foreach (int item in first)
            {
                if(!secondArrayElements.Contains(item))
                {
                    list.Add(item);
                }
            }

            return list;
        }

        internal static void findMissingElements()
        {
            throw new NotImplementedException();
        }
    }
}
