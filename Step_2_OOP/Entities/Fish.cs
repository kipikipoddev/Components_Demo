namespace Step_2_OOP;

public class Fish : Animal
{
    public Fish(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Swim = true;
    }
}