namespace Step_2_OOP;

public class Dog : Animal
{
    protected override Sounds Sound => Sounds.Barking;
    
    public Dog(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Walk = true;
        Can_Make_Sound = true;
        Can_Swim = true;
    }
}