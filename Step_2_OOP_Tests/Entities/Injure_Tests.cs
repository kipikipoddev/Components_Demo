using Step_2_OOP;

namespace Step_2_OOP_Tests;

public class Injure_Tests : UnitTest_Base
{
    [Test]
    public void Test_Injure()
    {
        var cat = new Cat(Priner, Speed.Fast);
        cat.Injure();
        Test_Message("Cat is injured");
    }

    [Test]
    public void Test_Heal()
    {
        var cat = new Cat(Priner, Speed.Fast);
        cat.Injure();
        cat.Heal();
        Test_Message("Cat is healing");
    }


    [Test]
    public void Test_Cannot_Heal()
    {
        var cat = new Cat(Priner, Speed.Fast);
        cat.Heal();
        Test_Message("Cat cannot heal");
    }
    
    [Test]
    public void Test_Injure_Actions()
    {
        var cat = new Cat(Priner, Speed.Normal);
        cat.Injure();
        Cannot(cat.Can_Walk);
        Cannot(cat.Can_Meow);
        Cannot(cat.Can_Injure);
        Cannot(cat.Can_Swim);
        Can(cat.Can_Heal);
    }

    [Test]
    public void Test_Heal_Actions()
    {
        var cat = new Cat(Priner, Speed.Normal);
        cat.Injure();
        cat.Heal();
        Can(cat.Can_Walk);
        Can(cat.Can_Meow);
        Can(cat.Can_Injure);
        Cannot(cat.Can_Swim);
        Cannot(cat.Can_Heal);
    }
}