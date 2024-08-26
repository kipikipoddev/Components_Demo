namespace Step_2_OOP;

public class Cat_Dog : Cat
{
    private readonly Dog dog;

    public Cat_Dog()
    {
        dog = new Dog() { Name = Name };
    }

    public override void Make_Sound()
    {
        base.Make_Sound();
        dog.Make_Sound();
    }
}