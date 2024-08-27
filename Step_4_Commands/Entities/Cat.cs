using Step_4_Commands.Core;
using Step_4_Commands.Sound_Handlers;
using Step_4_Commands.Walk_Handlers;

namespace Step_4_Commands.Entities;

public class Cat : Components
{
    public Cat()
    {
        Add(new Name_Component());
        Add(new Meow_Sound_Handler());
        Add(new Cat_Walk_Handler());
    }
}