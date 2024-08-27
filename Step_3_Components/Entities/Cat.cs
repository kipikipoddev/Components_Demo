namespace Step_3_Components;

public class Cat : Components
{
    public Cat()
    {
        Add(new Name_Component());
        Add(new Cat_Walk_Component());
        Add(new Meow_Component());
    }
}