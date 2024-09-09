namespace Step_5_Complex;

public class Bark_Component : Action_Component<Bark_Command>, IValidator<Bark_Command>
{
    public Bark_Component()
    {
        Mediator.Add_Validator(this);
    }

    public override void Set_Parent(IComponents parent)
    {
        new Change_Action_Command(parent, Actions.Bark, true);
    }

    public override void Handle(Bark_Command cmd)
    {
        new Print_Action_Command(Parent, cmd.Action, true, cmd.Volume);
    }

    public bool Is_Valid(Bark_Command cmd)
    {
        if (Parent.Has<IHp_Component>())
            if (Parent.Get<IHp_Component>().Is_Injured)
                return cmd.Volume == Volume.Quiet;
        return true;
    }
}