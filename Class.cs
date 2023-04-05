using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lb4_var4
{
    class Person
    {
        public string Id { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Salary { get; set; } = 0;
        public string SurnameID { get; set; } = string.Empty;
    }
    class Department
    {
        public string DepartmentName { get; set; } = String.Empty;
        public int CountEmployees { get; set; } = 0;
        public List<Person> Employees { get; set; } = new List<Person>();
    }
}
