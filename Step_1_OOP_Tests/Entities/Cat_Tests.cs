using Components_Demo;

namespace Step_1_OOP_Tests;

public class Cat_Tests : UnitTest_Base<ICat>
{
    [Test]
    public void Test_Actions()
    {
        Can(Subject.Can_Walk);
        Can(Subject.Can_Meow);
        Can(Subject.Can_Injure);
        Cannot(Subject.Can_Swim);
        Cannot(Subject.Can_Heal);
    }

    [Test]
    public void Test_Get_Actions()
    {
        Test_Actions(Actions.Meow, Actions.Walk, Actions.Injure);
    }

    [Test]
    public void Test_Meow()
    {
        Subject.Meow();
        Test_Action_Message(Actions.Meowing);
    }
}