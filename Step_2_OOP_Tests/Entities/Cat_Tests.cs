using Step_2_OOP;

namespace Step_2_OOP_Tests;

public class Cat_Tests : UnitTest_Base
{
    [Test]
    public void Test_Cat_Actins()
    {
        var cat = new Cat(Priner, Speed.Fast);
        Can(cat.Can_Walk);
        Can(cat.Can_Meow);
        Can(cat.Can_Injure);
        Cannot(cat.Can_Swim);
        Cannot(cat.Can_Heal);
    }

    [Test]
    public void Test_Cat_Meow()
    {
        new Cat(Priner, Speed.Normal).Meow();
        Test_Message("Cat is meowing");
    }
}