 public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Task(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public override string ToString()
        {
            return $"ID: {Id}, DESC: {Description}";
        }
    }
