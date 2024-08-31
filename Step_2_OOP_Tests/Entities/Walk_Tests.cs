using Step_2_OOP;

namespace Step_2_OOP_Tests;

public class Walk_Tests : UnitTest_Base
{
    [Test]
    public void Test_Walk_Fast()
    {
        new Cat(Priner, Speed.Fast).Walk();
        Test_Message("Cat is walking fast");
    }

    [Test]
    public void Test_Walk_Slow()
    {
        new Cat(Priner, Speed.Slow).Walk();
        Test_Message("Cat is walking slowly");
    }

    [Test]
    public void Test_Walk_Normal()
    {
        new Cat(Priner, Speed.Normal).Walk();
        Test_Message("Cat is walking");
    }
}