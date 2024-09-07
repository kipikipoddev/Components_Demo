namespace Step_5_Complex;

public class Bark_Component : Action_Component<Bark_Command>, IValidator<Meow_Command>
{
    public override void Handle(Bark_Command cmd)
    {
        new Print_Action_Command(Parent, cmd.Action, cmd.Volume);
    }

    public bool Is_Valid(Meow_Command cmd)
    {
        if (Parent.Has<IInjure_Component>())
            if (Parent.Get<IInjure_Component>().Is_Injured)
                return cmd.Volume == Volume.Quiet;
        return true;
    }
}