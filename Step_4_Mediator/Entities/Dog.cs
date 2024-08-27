using Step_4_Mediator.Core;
using Step_4_Mediator.Sound_Handlers;
using Step_4_Mediator.Walk_Handlers;

namespace Step_4_Mediator.Entities;

public class Dog : Components
{
    public Dog()
    {
        Add(new Name_Component());
        Add(new Bark_Sound_Handler());
        Add(new Dog_Walk_Handler());
        Add(new Dog_Swim_Handler());
    }
}