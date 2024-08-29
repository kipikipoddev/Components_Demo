namespace Step_1_OOP;

public class Cat : Animal
{
    protected override Actions Sound => Actions.Meowing;

    public Cat(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Walk = true;
        Can_Make_Sound = true;
    }
}