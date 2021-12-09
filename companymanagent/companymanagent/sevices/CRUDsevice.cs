using System;
using System.Collections.Generic;
using System.Linq;
using companymanagent.employees;

namespace companymanagent.sevices
{
    public class CRUDsevice
    {
        public static List<IEmployee> EmployeeList = new List<IEmployee>();

        // show all date
        public void Show()
        {
            Console.WriteLine("list nhan vien");
            // duyệt qua từng phần tử.
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine($"Id nhan vien: {employee.Id}");
                Console.WriteLine($"ten cua nhan vien la: {employee.Name}");
                // tostring() chuyển kiểu dữ liệu datetime thành kiểu dữ liệu chữ.
                Console.WriteLine($"create date cua nhan vien: {employee.CreateDate.ToString()}");
                Console.WriteLine($"chuc vu cua nha vien la: {employee.Chucvu}");
            }

        }
        // tim kiem theo id

        public void FindId(int id)
        {
            var employees = from s in EmployeeList where s.Id == id select s;
            Console.WriteLine("list nhan vien");
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine($"Id nhan vien: {employee.Id}");
                Console.WriteLine($"ten cua nhan vien la: {employee.Name}");
                Console.WriteLine($"create date cua nhan vien: {employee.CreateDate.ToString()}");
                Console.WriteLine($"chuc vu cua nha vien la: {employee.Chucvu}");
            }

        }

        // tim kiem theo ten
        public void FindName(string name)
        {
            // trim loại bỏ mấy dấu khoảng cách, tolower chuyển về chữ cái bt dễ so sánh
            var employees = from s in EmployeeList where s.Name.ToLower().Trim() == name.ToLower().Trim() select s;
            Console.WriteLine("list nhan vien");
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine($"Id nhan vien: {employee.Id}");
                Console.WriteLine($"ten cua nhan vien la: {employee.Name}");
                Console.WriteLine($"create date cua nhan vien: {employee.CreateDate.ToString()}");
                Console.WriteLine($"chuc vu cua nha vien la: {employee.Chucvu}");
            }

        }
        // tim kiem theo chuc vụ
        public void FindChucvu(string chucvu)
        {
            var employees = from s in EmployeeList where s.Chucvu.ToLower().Trim() == chucvu.ToLower().Trim() select s;
            Console.WriteLine("list nhan vien");
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine($"Id nhan vien: {employee.Id}");
                Console.WriteLine($"ten cua nhan vien la: {employee.Name}");
                Console.WriteLine($"create date cua nhan vien: {employee.CreateDate.ToString()}");
                Console.WriteLine($"chuc vu cua nha vien la: {employee.Chucvu}");
            }
        }
        
        // add date
        // dùng để chọn 1,2 or 3 thì mình dùng switch case
        public void Add(int input)
        {
            int id;
            string name;
            DateTime createDate;
            string chucvu; 
            switch (input)
            {
                case 1:
                    Console.WriteLine("enter Employee Id: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter Employee Name: ");
                    name = Console.ReadLine();
                    Console.Write("enter employee create date: ");
                    createDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("enter enployee chuc vu: ");
                    chucvu = "Staff";
                    Staff staff = new Staff(id, name, createDate, chucvu);
                    // gọi cái list nó ra, khởi tạo 1 cái obj rồi mình add nó vào.
                    EmployeeList.Add((staff));
                    break;
                case 2:
                    Console.WriteLine("enter Employee Id: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter Employee Name: ");
                    name = Console.ReadLine();
                    Console.Write("enter employee create date: ");
                     createDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("enter enployee chuc vu: ");
                    chucvu = "Manager";
                    Manager manager = new Manager(id, name, createDate, chucvu);
                    // gọi cái list nó ra
                    EmployeeList.Add((manager));
                    break;
                case 3:
                    Console.WriteLine("enter Employee Id: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter Employee Name: ");
                    name = Console.ReadLine();
                    Console.Write("enter employee create date: ");
                    createDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("enter enployee chuc vu: ");
                    chucvu = "Boss";
                    Boss boss = new Boss(id, name, createDate, chucvu);
                    // gọi cái list nó ra
                    EmployeeList.Add((boss));
                    break;
            }
        }
        // update date
        public void Update(int id)
        {
            Console.WriteLine("nhap ten can sưa: ");
            // đầu tiên là tìm kiếm ở trong cái list, nhận vào 1 cái id 
            // fristordegault là hàm tìm kiếm
            // nhận vào 1 cái funtion e sau đó so sánh cái id của thằng e và kiểu dữ liệu nhập vào id có bằng cái id mình điền vào không .lấy đc cái name của nó. rồi sau đó mình thay thế nó bằng cách nhập dữ liệ vào.
            EmployeeList.FirstOrDefault(e => e.Id == id).Name = Console.ReadLine();
            Console.WriteLine("nhap vao createdate: ");
            EmployeeList.FirstOrDefault(e => e.Id == id).CreateDate = Convert.ToDateTime(Console.ReadLine());
        }
        // delete date
        public void Delete(int id)
        {
            EmployeeList.RemoveAll(r => r.Id == id);
        }
    }
}