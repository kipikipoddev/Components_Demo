
namespace Components_Demo;

public class Fish : Animal, IFIsh
{
    public override bool Can_Swim => !Is_Injured;
    public override bool Can_Walk => false;
    public Fish(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
    }
}