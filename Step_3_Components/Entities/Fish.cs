namespace Step_3_Components;

public class Fish : Components
{
    public Fish()
    {
        Add(new Name_Component());
        Add(new Fish_Swim_Component());
    }
}