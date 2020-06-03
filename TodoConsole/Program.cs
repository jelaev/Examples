using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using TodoLibrary;

namespace TodoConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            TodoList<TodoItem> MyList = new TodoList<TodoItem>();       
            var handle = true;
            while (handle)
            {
                Console.WriteLine($"Элементов в списке {MyList.Count}.");
                Console.WriteLine($"1 - Добавить задание\t 2 - Выполнить задание\t 3 - Посмотреть задание");
                Console.WriteLine($"4 - Удалить задание\t 5 - Все задания\t 6 - Выйти");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.WriteLine("Введите текст задания: ");
                            var z = Console.ReadLine();
                            var todo = new TodoItem(MyList.Count, z, false);
                            MyList.Add(todo);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Введите номер задания: ");
                            var n = Console.ReadLine();
                            MyList.Where(x => x.GetNumber().Equals(n)).FirstOrDefault().Checked = true;
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Номер задания: ");
                            var n = Console.ReadLine();
                            Console.WriteLine(MyList.Where(x => x.GetNumber().Equals(x)).FirstOrDefault());
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Номер задания для удаления: ");
                            var n = Console.ReadLine();
                            Console.Write("Удалено - " + MyList.RemoveAll(x => x.GetNumber().Equals(n)));
                            break;
                        }
                    case "5":
                        {
                            MyList.ForEach(x => Console.WriteLine(x));
                            break;
                        }
                    case "6":
                        {
                            handle = false;
                            break;
                        }
                }

            }
            
        }
    }
}
