namespace Step_2_OOP;

public class Robot_Cat_Dog : Robot_Dog
{
    private readonly Cat cat;

    public Robot_Cat_Dog()
    {
        cat = new Cat { Name = Name };
    }

    public override void Make_Sound()
    {
        Recharge();
        cat.Make_Sound();
        Dog.Make_Sound();
    }
}