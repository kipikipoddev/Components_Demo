using Step_1_OOP;

namespace Step_1_OOP_Tests;

public class Walk_Tests : UnitTest_Base<ICat>
{
    [TestCase(Speed.Fast)]
    [TestCase(Speed.Normal)]
    [TestCase(Speed.Slow)]
    public void Test_Walk(Speed speed)
    {
        Subject = new Cat(Priner, speed);
        Subject.Walk();
        Test_Action_Message(Actions.Walking, speed);
    }

    protected override ICat Get_Subject()
    {
        return new Cat(Priner, Speed.Normal);
    }
}