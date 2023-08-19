using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleProjectCSharp
{
    public class TodoManager
    {
        //string CompletionStatus = "Incompleted";
        enum UserChoice
        {
            AddNewTask = 1,
            ViewAllTask = 2,
            ViewSpecificTask = 3,
            MarkComplete = 4,
            UpdateTask = 5,
            DeleteTask = 6,
            SaveToFile = 7,
            LoadTask = 8,
            Exit = 0

        }


        public void AddTask()
        {

            List<TaskItem> taskitem1 = new List<TaskItem>();

            while (true)
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
                

                

                int choice = int.Parse(Console.ReadLine());

                if(choice == (int)UserChoice.AddNewTask)
                {

                    Console.WriteLine("Enter the title of Task:");
                    string title1 = Console.ReadLine();

                    Console.WriteLine("Enter the Description of the Task:");
                    string description1 = Console.ReadLine();

                    //Console.WriteLine("Enter Completed or Incompleted as the Task Status");
                    //string taskcompletionstatus = Console.ReadLine();
                    string taskcompletionstatus = "Incomplete";



                    taskitem1.Insert(0,new TaskItem());
                    taskitem1[0].Title = title1;
                    taskitem1[0].Description = description1;
                    taskitem1[0].CompletionStatus = taskcompletionstatus;

                    Console.WriteLine("Task successfully added");
                    Console.WriteLine("");

                    Console.WriteLine("You have " + taskitem1.Count() + " Items in the List");
                    Console.WriteLine("");

                    
                }

                else if(choice == (int)(UserChoice.ViewAllTask))
                {
                    Console.WriteLine("To-do List is as:");
                    Console.WriteLine("");
                    for (int i = 0;i< taskitem1.Count;i++)
                    {
                        Console.WriteLine("Task "+(i+1)+" is");
                        Console.WriteLine("Title:"+taskitem1[i].Title);
                        Console.WriteLine("Description:" + taskitem1[i].Description);
                        Console.WriteLine("Status:"+taskitem1[i].CompletionStatus);
                        Console.WriteLine("");

                    }
                }

                else if(choice== (int)(UserChoice.ViewSpecificTask))
                {
                    Console.WriteLine("Enter the ID of the task ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Task " + (id) + " is");
                    Console.WriteLine("Title:" + taskitem1[id-1].Title);
                    Console.WriteLine("Description:" + taskitem1[id-1].Description);
                    Console.WriteLine("Completion Status" + taskitem1[id-1].CompletionStatus);
                    Console.WriteLine("");
                }

                else if(choice == (int)(UserChoice.MarkComplete))
                {
                    Console.WriteLine("Enter the ID of the task to mark complete:");
                    int markcompleteid = int.Parse(Console.ReadLine());
                    string markcompletestatus = "Completed";
                    taskitem1[markcompleteid - 1].CompletionStatus = markcompletestatus;
                    Console.WriteLine("This task has been marked completed");
                }

                else if(choice ==(int)UserChoice.UpdateTask)
                {
                    Console.WriteLine("Enter the ID of the task you want to Update");
                    int updateid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the New title of the Task");
                    string updatedtitle = Console.ReadLine();
                    Console.WriteLine("Enter the new description of the task");
                    string updateddesc = Console.ReadLine();
                    Console.WriteLine("Enter the task status as Completed or Incompleted");
                    string updatedcompletionstatus = Console.ReadLine();

                    taskitem1[updateid + 1].Title = updatedtitle;
                    taskitem1[updateid + 1].Description = updateddesc;
                    taskitem1[updateid + 1].CompletionStatus = updatedcompletionstatus;
                    Console.WriteLine("This Task has been Updated");
                }

                else if (choice == (int)UserChoice.DeleteTask)
                {
                    Console.WriteLine("Enter the ID of the task you want to Delete");
                    int deleteid = int.Parse(Console.ReadLine());
                    taskitem1.RemoveAt(deleteid);
                    Console.WriteLine("This item has been Deleted");
                }
                else if (choice == (int)UserChoice.SaveToFile)
                {
                    Console.WriteLine("You have chosen to Save task to the file");

                    FileHandler.SaveTask(taskitem1);

                    Console.WriteLine("Tasks have been loaded in the file");

                    //writinginfile writing1 = new writinginfile();
                    //writing1.totextfile();

                    
                }

                else if (choice == (int)UserChoice.LoadTask)
                {
                    Console.WriteLine("You have chosen to Load all tasks from the file");
                    Console.WriteLine("");
                    List<TaskItem> taskitemsfromjson =  FileHandler.LoadTasks();

                    foreach (var item in taskitemsfromjson)
                    {
                        Console.WriteLine("Title:"+item.Title);
                        Console.WriteLine("Description:"+item.Description);
                        Console.WriteLine("Status:"+item.CompletionStatus);
                        Console.WriteLine("");
                    }
                }

                else if (choice == (int)UserChoice.Exit)
                {
                    Console.WriteLine("You are Exiting !!! See you Again ;-)");
                    break;
                }

                else 
                {
                    Console.WriteLine("Please Enter correct input");
                    continue;
                }

            }

        }
    }
}

//class writinginfile
//{
//    static void totextfile()
//    {
//        List<string> lines = new List<string>
//            {
//                "Line 1",
//                "Line 2",
//                "Line 3"
//            };

//        string filePath = "output.txt";

//        using (StreamWriter writer = new StreamWriter(filePath))
//        {
//            foreach (string line in lines)
//            {
//                writer.WriteLine(line);
//            }
//        }

//        Console.WriteLine("List contents have been written to the file.");
//    }
//}
