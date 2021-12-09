using System;

namespace companymanagent.employees
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime CreateDate { get; set; }
        string Chucvu { get; set; }
        
        void working()
        {
            Console.WriteLine("management");
        }
    }
}    
    