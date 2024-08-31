using Step_2_OOP;

namespace Step_2_OOP_Tests;

public class Fish_Tests : UnitTest_Base
{
    [Test]
    public void Test_Fish_Actins()
    {
        var fish = new Fish(Priner, Speed.Fast);
        Cannot(fish.Can_Walk);
        Can(fish.Can_Injure);
        Can(fish.Can_Swim);
        Cannot(fish.Can_Heal);
    }
}