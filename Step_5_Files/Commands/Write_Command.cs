namespace Step_5_Files.Commands;

public class Write_Command : Command
{
    public Write_Commad_Types Type { get; }
    public string Action { get; }


    public Write_Command(IComponents component, Write_Commad_Types type, string? action = null)
        : base(component)
    {
        Type = type;
        Action = action ?? string.Empty;
        Send(this);
    }
}