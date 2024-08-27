namespace Step_3_Components;

public class Fish : Components
{
    public Fish()
    {
        Add(new Name_Component());
        Add(new Swim_Component());
    }
}