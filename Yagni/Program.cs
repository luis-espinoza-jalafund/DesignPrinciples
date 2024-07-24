class Program {
    public static void Main() {
        ContactManager contactManager = new ContactManager();
        contactManager.AddContact("Pancho Sancho", "panch.sanch41@gmail.com");
        contactManager.AddContact("Martin Cardenaz", "marti.carde@gmail.com");
        contactManager.AddContact("Daniela Quizpe", "massita_bonita@gmail.com");
        contactManager.ListContacts();

        contactManager.DeleteContact(2);
        contactManager.ListContacts();

        contactManager.DeleteContact(1);
        contactManager.DeleteContact(3);
        contactManager.ListContacts();

    }
}