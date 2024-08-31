namespace Step_2_OOP;

public class Cat : Animal
{
    protected override Sounds Sound => Sounds.Meowing;

    public Cat(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Walk = true;
        Can_Make_Sound = true;
    }
}