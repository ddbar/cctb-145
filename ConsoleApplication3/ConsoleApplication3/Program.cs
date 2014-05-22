using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        enum OfficeDepartment { Accounting, HumanResources, InformationTechnology, Shipping, MailRoom, Management }
        
        static void Main(string[] args)
        {

            Random r = new Random();

            Array officeDepartments = Enum.GetValues(typeof(OfficeDepartment));

            foreach (OfficeDepartment OfficeDepartment in officeDepartments)
            {
                int officeEmployees = r.Next(1, 10);
                string departmentName = GetDepartmentName(OfficeDepartment);
                Console.WriteLine("Department: {0} has {1} Employees", departmentName, officeEmployees);

            }

        }

        static string GetDepartmentName(OfficeDepartment officeDepartment)
        {
            string departmentName = "";
            switch (officeDepartment)
            {
                case OfficeDepartment.Accounting:
                    departmentName = "Accounting";
                    break;

                case OfficeDepartment.HumanResources:
                    departmentName = "Human Resources";
                    break;

                case OfficeDepartment.InformationTechnology:
                    departmentName = "information technology.";
                    break;

                case OfficeDepartment.Shipping:
                    departmentName = "Shipping";
                    break;

                case OfficeDepartment.MailRoom:
                    departmentName = "Mail Room";
                    break;

                case OfficeDepartment.Management:
                    departmentName = "Management";
                    break;

            }

            return departmentName;
        }

    
    }
}
