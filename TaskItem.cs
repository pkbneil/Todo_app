using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectCSharp
{
    public class TaskItem
    {
        public string Title;
        public string Description;
        public string CompletionStatus;
        //take input from the user and store it in list

        public string getTitle()
        {
            return this.Title;
        }
        public string getDescription()
        {
            return this.Description;
        }

        public string getCompletionStatus()
        {
            return this.CompletionStatus;
        }
        
    }
}
