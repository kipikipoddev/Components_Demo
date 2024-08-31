using Step_1_OOP;

namespace Step_1_OOP_Tests;

public class Fish_Tests : UnitTest_Base
{
    [Test]
    public void Test_Actions()
    {
        var fish = new Fish(Priner, Speed.Fast);
        Cannot(fish.Can_Walk);
        Can(fish.Can_Injure);
        Can(fish.Can_Swim);
        Cannot(fish.Can_Heal);
    }

    [Test]
    public void Test_Get_Actions()
    {
        var fish = new Fish(Priner, Speed.Fast);
        Test_Actions(fish, Actions.Swim, Actions.Injure);
    }
}