
namespace Step_2_OOP;

public class Fish : Animal
{
    public override bool Can_Swim => !Is_Injured;
    public override bool Can_Walk => false;
    public Fish(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }
}