using Components_Demo;

namespace Step_1_OOP_Tests;

public class Animal_Tests : UnitTest_Base<IAnimal>
{
    [Test]
    public void Test_Injure()
    {
        Subject.Injure();
        Test_Was_Action(Actions.Injured);
    }

    [Test]
    public void Test_Injure_Again()
    {
        Subject.Injure();
        Subject.Injure();
        Test_Cannot_Action(Actions.Injure);
    }

    [Test]
    public void Test_Heal()
    {
        Subject.Heal();
        Test_Cannot_Action(Actions.Heal);
    }

    [Test]
    public void Test_Heal_After_Injure()
    {
        Subject.Injure();
        Subject.Heal();
        Test_Was_Action(Actions.Healed);
    }
}