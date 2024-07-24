 public class ContactManager
    {
        private List<Contact> contacts;
        private int nextId;

        public ContactManager()
        {
            contacts = new List<Contact>();
            nextId = 1;
        }

        public void AddContact(string name, string email)
        {
            Contact newContact = new Contact(nextId, name, email);
            contacts.Add(newContact);
            nextId++;
            Console.WriteLine("contact added");
        }

        public void ListContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("empty list");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
        }

        public void DeleteContact(int id)
        {
            Contact contactToRemove = contacts.FirstOrDefault(c => c.Id == id);
            if (contactToRemove != null)
            {
                contacts.Remove(contactToRemove);
                Console.WriteLine("contact removed");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
    }