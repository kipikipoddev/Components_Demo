namespace Step_4_Files;

public class Bark_Component : Action_Component, IBark_Component
{
    public void Bark()
    {
        if (Can_Bark())
            Print_Was(Actions_Description.Barking);
        else
            Print_Cant(Actions.Bark);
    }

    public bool Can_Bark()
    {
        return !Is_Disabled;
    }
}