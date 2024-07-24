public class Contact
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Contact(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"ID: {Id}, name: {Name}, email: {Email}";
        }
    }
