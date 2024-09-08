namespace Step_5_Complex;

public class Meow_Component : Action_Component<Meow_Command>, IValidator<Meow_Command>
{
    public override void Handle(Meow_Command cmd)
    {
        new Print_Action_Command(Parent, cmd.Action, true, cmd.Volume);
    }

    public bool Is_Valid(Meow_Command cmd)
    {
        if (Parent.Has<IHp_Component>())
            if (Parent.Get<IHp_Component>().Is_Injured)
                return cmd.Volume == Volume.Quiet;
        return true;
    }
}