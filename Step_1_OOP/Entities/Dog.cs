namespace Step_1_OOP;

public class Dog : Animal
{
    protected override Actions Sound => Actions.Barking;
    public Dog(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Walk = true;
        Can_Make_Sound = true;
        Can_Swim = true;
    }
}