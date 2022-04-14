using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Models
{
   public  class Status
    {
        private static int _id;
        public int Id { get; set; }
        public Status(string content, string title)
        {
            _id++;
            Id = _id;
            SharedDate = DateTime.Now;
            Content = content;
            Title = title;
        }
        public string  Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; }

        public void GetStatusInfo()
        {
            Console.WriteLine($"Id - {Id}, Content {Content} , Title - {Title}  shared  {(DateTime.Now-SharedDate).TotalSeconds} seconds ago ");
        }

    }
}
