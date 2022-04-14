using Classwork.Models;
using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User("test testov");
            bool check = true;
            do
            {
                Console.WriteLine("====MENU====");
                Console.WriteLine("1. Share status");
                Console.WriteLine("2. Get status by id");
                Console.WriteLine("3. Filter status by date");
                Console.WriteLine("0. Quit");

                Console.WriteLine("====Sechim ediniz ====");
                string choice = Console.ReadLine();

                switch (choice)
                {

                    case "1":
                        Console.WriteLine("Title elave edin :");
                        string title = Console.ReadLine();
                        Console.WriteLine("Content elave edin :");
                        string content = Console.ReadLine();

                        Status status = new Status( content, title);
                        user.ShareStatus(status);
                        break;
                    case "2":
                        Console.WriteLine("Id daxil edin :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        user.GetStatusById(id).GetStatusInfo();
                        break;
                    case "3":
                        Console.WriteLine("Tarix qeyd edin :");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        foreach (var item in user.FilterStatusByDate(date))
                        {
                            item.GetStatusInfo();
                        }
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        Console.WriteLine("duzgun secim ediniz...");
                        break;
                }


            } while (check);

        }
    }
}
