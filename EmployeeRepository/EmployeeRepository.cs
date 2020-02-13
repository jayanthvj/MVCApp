using EmployeeEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeDAL
{
    public class EmployeeRepository
    {
        public static List<Employee> employee = new List<Employee>();
         static EmployeeRepository()
        {
            employee.Add(new Employee { EmployeeName = "Jayanth", EmployeeId =12, EmployeePhoneNumber = 9086453623,EmployeeDesigination="java" });
            employee.Add(new Employee { EmployeeName = "Hari", EmployeeId =13, EmployeePhoneNumber = 9500706230 ,EmployeeDesigination=".net"});
            employee.Add(new Employee { EmployeeName = "Madhu", EmployeeId = 14, EmployeePhoneNumber = 6381517883,EmployeeDesigination="csharp" });
        }
        public static IEnumerable<Employee> GetValue()
        {
            return employee;
        }
    }
}
