namespace Step_1_OOP;

public class Fish_Robot : Robot
{
    public Fish_Robot(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Make_Sound = true;
        Can_Swim = true;
    }
}