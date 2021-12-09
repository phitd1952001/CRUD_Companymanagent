using System;
using companymanagent.sevices;

namespace companymanagent
{
    class Program
    {
        // tạo 1 cái biến ans để hỏi ng dùng có muốn tiếp túc hay không
        private static char ans;
        static void Main(string[] args)
        {
            //chương trình quản lý sinh viên
            //role:boss, staff, manger
            //crud(create, read, update, delete) nhân viên.
            CRUDsevice service = new CRUDsevice();
            do
            {
                //clear console
                Console.Clear();
                //app area
                Console.WriteLine("********************************* Employee Managerment System *********************************");
                Console.WriteLine("1. Add an employee");
                Console.WriteLine("2. View employees");
                Console.WriteLine("3. Search employee");
                Console.WriteLine("4. Update employee");
                Console.WriteLine("5. Delete employee");
                Console.WriteLine("6. Exist");
                Console.WriteLine("******************************************************************");
                Console.WriteLine("Enter your choice here-");
                int choose_number = Convert.ToInt32(Console.ReadLine());
                int search_Id;

                switch (choose_number)
                {
                    case 1:
                        Console.WriteLine("Add staff input 1");
                        Console.WriteLine("Add manager input 2");
                        Console.WriteLine("Add boss input 3");
                        int input = Convert.ToInt32(Console.ReadLine());
                        service.Add(input);
                        break;
                    case 2:
                        service.Show();
                        break;
                    case 3:
                        Console.WriteLine("Type to search");
                        Console.WriteLine("Search theo id input 1");
                        Console.WriteLine("Search theo name input 2");
                        Console.WriteLine("Search theo chuc vu input 3");
                        
                        int searchInput = Convert.ToInt32(Console.ReadLine());
                        switch (searchInput)
                        {
                           case 1:
                               Console.WriteLine("Enter id");
                               int id = Convert.ToInt32(Console.ReadLine());
                               service.FindId(id);
                               break;
                           case 2:
                               Console.WriteLine("Enter Name");
                               string name = Console.ReadLine();
                               service.FindName(name);
                               break;
                           case 3:
                               Console.WriteLine("Enter chucVu");
                               string chucvu = Console.ReadLine();
                               service.FindChucvu(chucvu);
                               break;
                           default:
                               Console.WriteLine("Invalid choice.... please choose again");
                               break;
                        }
                        break;
                    
                    case 4:
                        Console.WriteLine("Enter your Id");
                        var idUpdate = Convert.ToInt32(Console.ReadLine());
                        service.Update(idUpdate);
                        break;
                    
                    case 5:
                        Console.WriteLine("Enter your Id");
                        var idDelete = Convert.ToInt32(Console.ReadLine());
                        service.Delete(idDelete);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.... please choose again");
                        break;
                }
            
                 // verify coninue
                Console.Write("Would you like to continue (Y/N):");
                ans = Convert.ToChar(Console.ReadLine()); 
            } while (ans == 'y' || ans == 'Y');
            
            // 3 role : boss staff manage
            // func
            // tìm kiếm: timef kiếm theo tên, theo id, theo chức vu
            // thêm nhân viên 
            // sửa thôn tin nhân viên
            // xóa nhân viên
            // show ra tất cả nhân viên
            // CRUD : create / read / update / delete 
        }
    }
}