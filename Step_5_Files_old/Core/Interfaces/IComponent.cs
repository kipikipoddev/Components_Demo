namespace Step_5_Files.Core;

public interface IComponent
{
    IComponents Parent { get; set; }
}