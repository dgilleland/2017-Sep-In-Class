using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DemoData
{
    [DataObject]
    public class TaskManager
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public IEnumerable<Task> ListTasks()
        {
            yield return new Task { TaskId = 1, Name = "Mark CQRS In-Class", DueDate = new DateTime(2017, 12, 12) };
            yield return new Task { TaskId = 2, Name = "Create ListView Demo" };
            yield return new Task { TaskId = 3, Name = "Create GridView Demo" };
            yield return new Task { TaskId = 4, Name = "Create Repeater Demo" };
        }
    }
    public enum TaskStatus { Todo, OnHold, Blocked, Complete, Restarted }
    public class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Done { get; set; }
        public TaskStatus Status { get; set; }
    }
}