namespace MiniApi.Model
{
    public class Employee
    {
        public string EmproyeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Citizenship { get; set; }
    }

    //public class EmployeeCollection
    //{
    //    public List<Employee> Employees { get; set; }

    //    public List<Employee> GetEmployees()
    //    {
    //        return new List<Employee>()
    //        {
    //            new Employee()
    //            {
    //                EmployeeName = "TesteName",
    //                Citizenship = "Brazil",
    //                EmproyeeId = "1"
    //            },
    //            new Employee()
    //            {
    //                EmployeeName = "TesteName2",
    //                Citizenship = "EUA",
    //                EmproyeeId = "2"
    //            }
    //        };
    //    }
    //}


}
