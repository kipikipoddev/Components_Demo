namespace Step_2_OOP;

public class Human_Robot : Robot
{
    protected override Sounds Sound => Sounds.Beeping;

    public Human_Robot(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Walk = true;
        Can_Make_Sound = true;
    }
}