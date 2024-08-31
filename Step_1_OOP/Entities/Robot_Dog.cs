namespace Step_1_OOP;

public class Robot_Dog : Robot
{
    protected override Sounds Sound => Sounds.Barking;

    public Robot_Dog(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Walk = true;
        Can_Make_Sound = true;
        Can_Swim = true;
    }
}