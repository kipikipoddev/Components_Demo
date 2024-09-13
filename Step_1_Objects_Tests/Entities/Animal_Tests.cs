using Step_1_Objects;

namespace Step_1_Objects_Tests;

public class Animal_Tests : UnitTest_Base<IAnimal>
{
    [Test]
    public void Test_Actions()
    {
        Assert_True(Subject.Can_Injure);
        Assert_False(Subject.Can_Heal);
        Assert_False(Subject.Is_Injured);
    }

    [Test]
    public void Test_Injure()
    {
        Subject.Injure();

        Assert_False(Subject.Can_Injure);
        Assert_True(Subject.Can_Heal);
        Assert_True(Subject.Is_Injured);
        Assert_Was_Printed(Actions_Description.Injured);
    }

    [Test]
    public void Test_Injure_Again()
    {
        Subject.Injure();

        Subject.Injure();

        Assert_True(Subject.Is_Injured);
        Assert_Cant_Printed(Actions.Injure);
    }

    [Test]
    public void Test_Heal()
    {
        Subject.Heal();

        Assert_False(Subject.Is_Injured);
        Assert_Cant_Printed(Actions.Heal);
    }

    [Test]
    public void Test_Heal_After_Injure()
    {
        Subject.Injure();

        Subject.Heal();

        Assert_False(Subject.Is_Injured);
        Assert_Was_Printed(Actions_Description.Healed);
    }
}