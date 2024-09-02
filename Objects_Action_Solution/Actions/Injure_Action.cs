namespace Objects_Solution;

public class Injure_Action : Action
{
    private readonly IAnimal animal;

    protected override Actions Name => Actions.Injured;
    protected override Actions Cannot => Actions.Injure;

    public Injure_Action(IAction_Printer printer, IAnimal animal)
        : base(printer, animal)
    {
        this.animal = animal;
    }

    public override void Do()
    {
        base.Do();
        animal.Is_Injured = true;
    }
}