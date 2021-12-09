﻿using System;

namespace companymanagent.employees
{
    public class Manager : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string Chucvu { get; set; }
        public Manager()
        {
            
        }

        public Manager(int id, string name, DateTime createDate, string chucvu)
        {
            this.Id = id;
            this.Name = name;
            this.CreateDate = createDate;
            this.Chucvu = chucvu;
        }
        

        public void working()
        {
            Console.WriteLine("leading");
        }

    }
}