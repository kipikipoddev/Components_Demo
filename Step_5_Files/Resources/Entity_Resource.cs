using Step_5_Files.Data;

namespace Step_5_Files.Resources;

public class Entity_Resource : Named_Resource
{
    public string[]? Sounds { get; set; }
    public string? Walk { get; set; }
    public bool? Charge { get; set; }

    public Entity_Data Map()
    {
        return new Entity_Data(Name, Sounds, Walk, Charge ?? false);
    }
}