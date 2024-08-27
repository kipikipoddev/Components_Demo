using Step_4_Commands.Core;
using Step_4_Commands.Walk_Handlers;

namespace Step_4_Commands.Entities;

public class Fish : Components
{
    public Fish()
    {
        Add(new Name_Component());
        Add(new Fish_Swim_Handler());
    }
}