using Newtonsoft.Json;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectCSharp
{
    public class FileHandler
    {
        public static string FilePath = "C:\\Users\\DevwratTamrakar\\source\\repos\\ConsoleProjectCSharp\\tasks.json";
        

        public static void SaveTask(List<TaskItem> tasks)
        {
            string json = JsonConvert.SerializeObject(tasks);
            File.WriteAllText(FilePath, json);
        }

        public static List<TaskItem> LoadTasks()
        {
            string json1 = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<TaskItem>>(json1);
            //List<TaskItem> loadedtasks = JsonSerializer.Deserialize<List<TaskItem>>(json1);
            //return loadedtasks;
            



        }
        //public void totextfile()
        //{
        //    List<string> lines = new List<string>
        //    {
        //        "Line 1",
        //        "Line 2",
        //        "Line 3"
        //    };

        //    string filePath = "output.txt";

        //    using (StreamWriter writer = new StreamWriter(filePath))
        //    {
        //        foreach (string line in lines)
        //        {
        //            writer.WriteLine(line);
        //        }
        //    }

        //    Console.WriteLine("List contents have been written to the file.");
        //}

    }

}
