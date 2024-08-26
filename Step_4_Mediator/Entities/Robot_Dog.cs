using Step_4_Mediator.Core;
using Step_4_Mediator.Sound_Handlers;
using Step_4_Mediator.Walk_Handlers;

namespace Step_4_Mediator.Entities;

public class Robot_Dog : Components
{
    public Robot_Dog()
    {
        Add(new Name_Component());
        Add(new Charge_Component());
        Add(new Bark_Sound_Handler());
        Add(new Charge_Sound_Handler());
        Add(new Robot_Walk_Handler());
    }
}