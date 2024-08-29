namespace Step_1_OOP;

public class Human_Robot : Robot
{
    public Human_Robot(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Walk = true;
        Can_Make_Sound = true;
    }
}