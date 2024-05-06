class ClassEvent
{
    public event Action <string> Event;
    public string Message { get; set; }

    public ClassEvent(string message)
    {
        Message = message;
    }

    public void TriggerEvent()
    {
        Event?.Invoke(Message);
    }
}

class ProcessingEvent
{
    public void ProcessinEvent(string message)
    {
        Console.WriteLine($"Событие - {message}");
    }
}
class Program
{
    static void Main()
    {
        ProcessingEvent handler = new();

        ClassEvent object1 = new("Объект 1");
        ClassEvent object2 = new("Объект 2");

        object1.Event += handler.ProcessinEvent;
        object2.Event += handler.ProcessinEvent;

        object1.TriggerEvent();
        object2.TriggerEvent();
    }
}