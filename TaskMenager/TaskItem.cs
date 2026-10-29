class TaskItem{
    public string Title;
    public string Description;
    public bool IsCompleted;

    public TaskItem(string title, string description){
        Title = title;
        Description = description;
        IsCompleted = false;
    }

    public void PrintInfo(){
        string status  = IsCompleted ? "+Выполнена" : "-Не Выполнена";
        Console.WriteLine($"[{status}] {Title}");
        Console.WriteLine(Description);
    }

    public void Complete(){
        IsCompleted = true;
        Console.WriteLine($"{Title} выполнена");
    }

    public void Reset(){
        IsCompleted = false;
        Console.WriteLine($"{Title} сброшена");
    }
    
}
