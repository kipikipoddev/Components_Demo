using Step_4_Mediator.Core;
using Step_4_Mediator.Walk_Handlers;

namespace Step_4_Mediator.Entities;

public class Fish : Components
{
    public Fish()
    {
        Add(new Name_Component());
        Add(new Fish_Swim_Handler());
    }
}