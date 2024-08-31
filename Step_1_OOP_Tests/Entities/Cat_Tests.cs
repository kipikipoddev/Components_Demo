using Step_1_OOP;

namespace Step_1_OOP_Tests;

public class Cat_Tests : UnitTest_Base
{
    [Test]
    public void Test_Actions()
    {
        var cat = new Cat(Priner, Speed.Fast);
        Can(cat.Can_Walk);
        Can(cat.Can_Meow);
        Can(cat.Can_Injure);
        Cannot(cat.Can_Swim);
        Cannot(cat.Can_Heal);
    }

    [Test]
    public void Test_Get_Actions()
    {
        var cat = new Cat(Priner, Speed.Fast);
        Test_Actions(cat, Actions.Meow, Actions.Walk, Actions.Injure);
    }

    [Test]
    public void Test_Meow()
    {
        new Cat(Priner, Speed.Normal).Meow();
        Test_Action_Message("Cat is ", Actions.Meowing);
    }
}