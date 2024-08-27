namespace Step_3_Components;

public class Dog : Components
{
    public Dog()
    {
        Add(new Name_Component());
        Add(new Dog_Walk_Component());
        Add(new Bark_Component());
        Add(new Dog_Swim_Component());
    }
}