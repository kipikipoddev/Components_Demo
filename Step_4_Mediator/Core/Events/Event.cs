using System.Text;

namespace Step_4_Mediator.Core;

public record Event
{
    protected static int Indentation { get; private set; }

    public object? Object { get; private set; }

    public Event(IComponent? @object = null, bool auto_send = true)
    {
        Object = @object;
        if (auto_send)
            Send();
    }

    public virtual void Send()
    {
        Start();
        Mediator.Send(this);
        End();
    }

    protected virtual void Start()
    {
        Write_log("Started");
        Indentation++;
    }

    protected virtual void End()
    {
        Indentation--;
        Write_log("Ended");
    }

    protected void Write_log(string message)
    {
        var sb = new StringBuilder();
        sb.Append(DateTime.Now.ToString("HH:mm:ss:ff"));
        for (int i = 0; i < Indentation; i++)
            sb.Append('\t');
        Console.WriteLine($"{sb} {GetType().Name} {message}");
    }
}