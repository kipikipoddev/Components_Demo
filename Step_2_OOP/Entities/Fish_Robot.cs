namespace Step_2_OOP;

public class Fish_Robot : Robot
{
    protected override Sounds Sound => Sounds.Beeping;

    public Fish_Robot(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Make_Sound = true;
        Can_Swim = true;
    }
}