using Step_4_Mediator.Core;
using Step_4_Mediator.Sound_Handlers;
using Step_4_Mediator.Walk_Handlers;

namespace Step_4_Mediator.Entities;

public class Cat : Components
{
    public Cat()
    {
        Add(new Name_Component());
        Add(new Meow_Sound_Handler());
        Add(new Cat_Walk_Handler());
    }
}