using System;

namespace companymanagent.employees
{
    public class Boss : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string Chucvu { get; set; }
        
        /* tạo ra 1 contracter bình thường để tránh lỗi khi mình khởi tạo mình gán biến sau 
        hoặc là mình gán biến luôn */
        public Boss()
        {
            
        }

        public Boss(int id, string name, DateTime createDate, string chucvu)
        {
            this.Id = id;
            this.Name = name;
            this.CreateDate = createDate;
            this.Chucvu = chucvu;
        }
        

        public void working()
        {
            Console.WriteLine("management");
        }
        
    }
    
}