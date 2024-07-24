class Program {
    public static void Main() {
        TaskManager taskManager = new TaskManager();
        taskManager.AddANewTask("pass the test");
        taskManager.AddANewTask("make my homework");
        taskManager.AddANewTask("assist the class");

        taskManager.ListTasks();

    }
}