Console.WriteLine("Менеджер задач");

TaskItem task1 = new TaskItem("Купить молоко", "2 пакета");
TaskItem task2 = new TaskItem("Купить скиж плату", "2 платы");
TaskItem task3 = new TaskItem("Купить веселую науку", "2 экземпляра");

Console.WriteLine("Список задач:");
task1.Complete();
task3.Complete();
task1.PrintInfo();
task2.PrintInfo();
task3.PrintInfo();

task1.Reset();


Console.WriteLine("Независимости объектов");
TaskItem taskA = new TaskItem("Первый оюъект","A");
TaskItem taskB = new TaskItem("Второй объект","B");

taskA.Complete();
Console.WriteLine("Изменения");
taskA.PrintInfo();
Console.WriteLine();
taskB.PrintInfo();