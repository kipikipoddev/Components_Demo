using Step_5_Files.Core;
using Step_5_Files.Interfaces;

namespace Step_5_Files;

public class Name_Component : Component, IName_Component
{
    public string Name { get; }

    public Name_Component(string name)
    {
        Name = name;
    }
}