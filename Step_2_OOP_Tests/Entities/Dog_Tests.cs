using Step_2_OOP;

namespace Step_2_OOP_Tests;

public class Dog_Tests : UnitTest_Base
{
    [Test]
    public void Test_Dog_Actins()
    {
        var Dog = new Dog(Priner, Speed.Fast);
        Can(Dog.Can_Walk);
        Can(Dog.Can_Bark);
        Can(Dog.Can_Injure);
        Can(Dog.Can_Swim);
        Cannot(Dog.Can_Heal);
    }


    [Test]
    public void Test_Dog_Bark()
    {
        new Dog(Priner, Speed.Normal).Bark();
        Test_Message("Dog is barking");
    }
}