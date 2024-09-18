namespace Step_3_Commands;

public class Bark_Component : Action_Component<Bark_Command>, IBark_Component
{
    public void Bark()
    {
        new Bark_Command(Parent).Send();
    }

    public bool Can_Bark()
    {
        return new Bark_Command(Parent).Is_Valid();
    }
}