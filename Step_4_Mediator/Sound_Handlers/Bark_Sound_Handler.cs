using Step_4_Mediator.Commands;
using Step_4_Mediator.Core;

namespace Step_4_Mediator.Sound_Handlers;

public class Bark_Sound_Handler : IHandler<Sound_Command>
{
    public void Handle(Sound_Command evnt)
    {
        evnt.Components.Write("Barking");
    }
}
