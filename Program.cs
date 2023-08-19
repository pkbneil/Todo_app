using System.ComponentModel.DataAnnotations;

namespace ConsoleProjectCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Let's see how it goes !!!");
            Console.WriteLine("This is My Console Project :-)");
            Console.WriteLine("Will apply the SOLID and Observer Design Pattern in the code");
            Console.WriteLine("Can use thread also");
            Console.WriteLine("Have to use async and await also");
            Console.WriteLine("");


            

            //MainMenu obj1 = new MainMenu();
            //obj1.Display();

            TodoManager obj2 = new TodoManager();
            obj2.AddTask();
            

            
            



            //Console.WriteLine("Enter the title of Task:");
            //string title1 = Console.ReadLine();

            //Console.WriteLine("Enter the Description of the Task:");
            //string description1 = Console.ReadLine();

            //Console.WriteLine("Enter Completed or Incompleted as the Task Status");
            //string taskcompletionstatus = Console.ReadLine();

            
     


            //List<TaskItem> taskitem1 = new List<TaskItem>();
            //taskitem1.Add(new TaskItem());
            //taskitem1[0].Title = title1;
            //taskitem1[0].Description = description1;
            //taskitem1[0].CompletionStatus = taskcompletionstatus;

            //foreach (TaskItem item in taskitem1)
            //{
            //    Console.WriteLine("The Task is:"+item.getTitle());
            //    Console.WriteLine("Description:"+item.getDescription());
            //    Console.WriteLine("Completion Status:"+item.getCompletionStatus());
            //}

            
            


        }
    }
}