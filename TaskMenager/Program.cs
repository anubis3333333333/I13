Console.WriteLine("Менеджер задач 1.0");

TaskItem task1 = new TaskItem("Купить веселую науку", "1 экземпляра");
TaskItem task2 = new TaskItem("Купить скиж плату", "4 экземпляра");
Console.WriteLine("НАчальный список задач");
task1.PrintInfo();
task2.PrintInfo();
Console.WriteLine();
task1.Complete();
task2.Complete();
Console.WriteLine("Итоговый список задач");
task1.PrintInfo();
task2.PrintInfo();

int total = 4;
int completed = 0;
if (task1.IsCompleted) completed++;
if (task2.IsCompleted) completed++;

Console.WriteLine();
Console.WriteLine($"{total} задач");
Console.WriteLine($"{completed} выполнено");
Console.WriteLine($"{total - completed} осталось");

// Console.WriteLine("Проблемы открытых полей");
// TaskItem task = new TaskItem("чтототам", "2 раза");
// task.PrintInfo();
// Console.WriteLine("меняет данные");
// task.Title = "";
// task.Description = null;
// task.IsCompleted = true;
// Console.WriteLine("после первого изменения полей");
// task.PrintInfo();