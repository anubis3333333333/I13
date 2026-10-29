Console.WriteLine("Менеджер задач");

TaskItem task1 = new TaskItem("Купить молоко", "2 пакета");
TaskItem task2 = new TaskItem("Купить скиж плату", "2 платы");
TaskItem task3 = new TaskItem("Купить веселую науку", "2 экземпляра");

Console.WriteLine("Список задач:");
task1.PrintInfo();
task2.PrintInfo();
task3.PrintInfo();
