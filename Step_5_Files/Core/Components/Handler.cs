
using Step_5_Files.Enums;

namespace Step_5_Files.Core;

public abstract class Handler<T> : Component, IHandler<T>
    where T : Command
{
    public abstract void Handle(T cmd);

    protected void Write(string message)
    {
        Console.WriteLine($"{Parent.Name()} is {message}");
    }

    protected static string Get_Speed(Speed speed)
    {
        return speed switch
        {
            Speed.Slow => "slowly ",
            Speed.Fast => "fast ",
            _ => string.Empty,
        };
    }
}