using Step_1_OOP;

namespace Step_1_OOP_Tests;

public class Fish_Tests : UnitTest_Base<IAnimal>
{
    [Test]
    public void Test_Actions()
    {
        Cannot(Subject.Can_Walk);
        Can(Subject.Can_Injure);
        Can(Subject.Can_Swim);
        Cannot(Subject.Can_Heal);
    }

    [Test]
    public void Test_Get_Actions()
    {
        Test_Actions(Actions.Swim, Actions.Injure);
    }

    protected override IAnimal Get_Subject()
    {
        return new Fish(Priner, Speed.Fast);
    }
}