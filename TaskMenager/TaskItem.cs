class TaskItem
{
    private string Title;
    private string Description;
    private bool IsCompleted;

    
    public bool IsCompletedStatus => IsCompleted; 

    public TaskItem(string title, string description)
    {
        this.Title = title;
        this.Description = description;
        this.IsCompleted = false;
    }

    public void PrintInfo()
    {
        string status = IsCompleted ? "+Выполнена" : "-Не Выполнена";
        Console.WriteLine($"[{status}] {Title}");
        Console.WriteLine(Description);
    }

    public void Complete()
    {
        IsCompleted = true;
        Console.WriteLine($"{Title} выполнена");
    }

    public void Reset()
    {
        IsCompleted = false;
        Console.WriteLine($"{Title} сброшена");
    }

    public string GetStatus()
    {
        if (IsCompleted) return "+Выполнена";
        else return "- Не выполнена";
    }

    public string GetTitle()
    {
        return Title;
    }

    public string GetDescription()
    {
        return Description; 
    }

    public bool GetIsComplete(){
        return IsCompleted;
    }

    public void SetTitle(string value)
    {
        if (value == null || value.Trim() == "")
        {
            Console.WriteLine("заголовок не может быть пустым");
            return;
        }
        Title = value; 
    }

    public void SetDescription(string? value)
    {
        if (value == null)
        {
            Console.WriteLine("описание не может быть пустым");
            return;
        }
        Description = value; 
    }
}