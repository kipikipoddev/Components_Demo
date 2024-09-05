namespace Step_5_Complex;

public class Meow_Component : Action_Component<Meow_Command>, IValidator<Meow_Command>
{
    public bool Is_Valid(Meow_Command cmd)
    {
        var is_injured = Parent.Get<IInjure_Component>().Is_Injured;
        if (is_injured)
            return cmd.Volume == Volume.Quiet;
        return true;
    }
}