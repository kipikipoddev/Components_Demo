using Step_1_OOP;

namespace OOP_Unit_Tests;

public class Fish_Tests : UnitTest_Base<IFIsh>
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
}