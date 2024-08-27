using Step_4_Mediator.Commands;
using Step_4_Mediator.Core;
using Step_4_Mediator.Sound_Handlers;
using Step_4_Mediator.Walk_Handlers;

namespace Step_4_Mediator.Entities;

public class Robot_Dog : Components
{
    public Robot_Dog()
    {
        Add(new Name_Component());
        Add(new Bark_Sound_Handler());
        Add(new Recharge_Handler<Make_Sound_Command>());
        Add(new Dog_Walk_Handler());
        Add(new Recharge_Handler<Walk_Command>());
        Add(new Dog_Swim_Handler());
        Add(new Recharge_Handler<Swim_Command>());
    }
}