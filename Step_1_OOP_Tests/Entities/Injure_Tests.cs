using Step_1_OOP;

namespace Step_1_OOP_Tests;

public class Injure_Tests : UnitTest_Base<ICat>
{
    [Test]
    public void Test_Injure()
    {
        var cat = new Cat(Priner, Speed.Fast);
        cat.Injure();
        Test_Action_Message(Actions.Injured);
    }

    [Test]
    public void Test_Heal()
    {
        var cat = new Cat(Priner, Speed.Fast);
        cat.Injure();
        cat.Heal();
        Test_Action_Message(Actions.Healing);
    }


    [Test]
    public void Test_Cannot_Heal()
    {
        var cat = new Cat(Priner, Speed.Fast);
        cat.Heal();
        Test_Cannot_Action(Actions.Heal);
    }

    [Test]
    public void Test_Injure_Actions()
    {
        Subject.Injure();
        Cannot(Subject.Can_Walk);
        Cannot(Subject.Can_Meow);
        Cannot(Subject.Can_Injure);
        Cannot(Subject.Can_Swim);
        Can(Subject.Can_Heal);
    }

    [Test]
    public void Test_Heal_Actions()
    {
        Subject.Injure();
        Subject.Heal();
        Can(Subject.Can_Walk);
        Can(Subject.Can_Meow);
        Can(Subject.Can_Injure);
        Cannot(Subject.Can_Swim);
        Cannot(Subject.Can_Heal);
    }

    protected override ICat Get_Subject()
    {
        return new Cat(Priner, Speed.Normal);
    }
}