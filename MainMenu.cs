using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectCSharp
{
    
    public class MainMenu
    {
        int choice;

        public void Display()
        {
            Console.WriteLine("Press the Following keys to take the Action:");
            Console.WriteLine("");
            Console.WriteLine("Press 1: To Add a task");
            Console.WriteLine("Press 2: To View all tasks");
            Console.WriteLine("Press 3: To View a Specific task (By ID of the Task)");
            Console.WriteLine("Press 4: To mark a task as Completed");
            Console.WriteLine("Press 5: To Update a Task (By ID of the Task)");
            Console.WriteLine("Press 6: To Delete a Task");
            Console.WriteLine("Press 7: To Save a task to the File");
            Console.WriteLine("Press 8: To Load tasks from a File");
            Console.WriteLine("Press 0: To EXIT");
            Console.WriteLine("");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                
                TodoManager addTask1 = new TodoManager();
                //addTask1.AddTask();

                Display();
                
                

            }

            else if (choice == 2)
            {
                Console.WriteLine("You have Chosen to view All tasks");
                Console.WriteLine("");
                //calling the class TaskItem

                TodoManager obj2 = new TodoManager();
                //obj2.ViewTask();

            }

            else if (choice == 3)
            {
                Console.WriteLine("You have chosen to view a Specific task by its ID");
            }

            else if (choice == 4)
            {
                Console.WriteLine("You have chosen to Mark a task as Completed by its ID");
            }

            else if (choice == 5)
            {
                Console.WriteLine("You have chosen to Update a Task by its ID");
            }

            else if(choice == 6)
            {
                Console.WriteLine("You have chosen to Delete a Task by its ID");
            }

            else if( choice == 7)
            {
                Console.WriteLine("You have chosen to Save task to a File");
            }

            else if(choice == 8)
            {
                Console.WriteLine("You have chosen to Load task from the File");
            }

            else if (choice == 0)
            {
                Console.WriteLine("Exiting Now !!! Happy to see you Again :-)");
            }

            else
            {
                Console.WriteLine("Please enter correct Input");
            }
        }

    }
}
