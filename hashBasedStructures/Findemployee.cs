using hashBasedStructures.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashBasedStructures
{
    class Findemployee
    {
        Dictionary<int, Employee> employeeById = new Dictionary<int, Employee>();
        
        
        public void searchForemployee( Employee employee)
        {
           
           

            employeeById.Add(employee.id, employee);


        }


    }
}
