using Objects_Solution;

namespace Objects_Solution_Tests;

public class Fish_Tests : UnitTest_Base<IFIsh>
{
    [Test]
    public void Test_Actions()
    {
        Assert_True(Subject.Can_Swim);
        Assert_True(Subject.Can_Injure);
        Assert_False(Subject.Can_Heal);
    }

    [Test]
    public void Test_Actions_After_Injure()
    {
        Subject.Injure();

        Assert_False(Subject.Can_Swim);
        Assert_False(Subject.Can_Injure);
        Assert_True(Subject.Can_Heal);
    }

    [Test]
    public void Test_Swim()
    {
        Subject.Swim();

        Assert_Was_Printed(Actions.Swiming);
    }

    [Test]
    public void Test_cant_Swim()
    {
        Subject.Injure();
        
        Subject.Swim();

        Assert_Cant_Printed(Actions.Swim);
    }
}