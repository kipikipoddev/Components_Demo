using Step_4_Mediator.Core;
using Step_4_Mediator.Interfaces;

namespace Step_4_Mediator;

public class Name_Component : Component, IName_Component
{
    public string Name { get; private set; }

    protected override void Parent_Set()
    {
        Name = Parent!.GetType().Name;
    }
}