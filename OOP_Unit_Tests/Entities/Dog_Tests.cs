using Components_Demo;

namespace OOP_Unit_Tests;

public class Dog_Tests : UnitTest_Base<IDog>
{
    [Test]
    public void Test_Actions()
    {
        Can(base.Subject.Can_Walk);
        Can(Subject.Can_Bark);
        Can(Subject.Can_Injure);
        Can(Subject.Can_Swim);
        Cannot(Subject.Can_Heal);
    }

    [Test]
    public void Test_Get_Actions()
    {
        Test_Actions(Actions.Bark, Actions.Walk, Actions.Swim, Actions.Injure);
    }

    [Test]
    public void Test_Bark()
    {
        Subject.Bark();
        Test_Action_Message(Actions.Barking);
    }
}