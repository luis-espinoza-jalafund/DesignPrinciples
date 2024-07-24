 public class TaskManager
    {
        private List<Task> tasks;
        private int nextId;

        public TaskManager()
        {
            tasks = new List<Task>();
            nextId = 1;
        }

        public void AddANewTask(string description)
        {
            Task newTask = new Task(nextId, description);
            tasks.Add(newTask);
            nextId++;
            Console.WriteLine("Task added");
        }

        public void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("empty list");
            }
            else
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
        }
    }
