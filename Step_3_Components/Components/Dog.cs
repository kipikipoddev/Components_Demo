namespace Step_3_Components;

public class Dog : Components
{
    public Dog()
    {
        Add(new Name_Component());
        Add(new Walk_Component());
        Add(new Bark_Sound_Component());
    }
}