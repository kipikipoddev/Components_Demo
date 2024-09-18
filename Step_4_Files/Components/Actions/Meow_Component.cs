namespace Step_4_Files;

public class Meow_Component : Action_Component, IMeow_Component
{
    public void Meow()
    {
        if (Can_Meow())
            Print_Was(Actions_Description.Meowing);
        else
            Print_Cant(Actions.Meow);
    }

    public bool Can_Meow()
    {
        return !Is_Disabled;
    }
}