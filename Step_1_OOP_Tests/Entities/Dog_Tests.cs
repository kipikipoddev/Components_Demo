using Step_1_OOP;

namespace Step_1_OOP_Tests;

public class Dog_Tests : UnitTest_Base
{
    [Test]
    public void Test_Actions()
    {
        var Dog = new Dog(Priner, Speed.Fast);
        Can(Dog.Can_Walk);
        Can(Dog.Can_Bark);
        Can(Dog.Can_Injure);
        Can(Dog.Can_Swim);
        Cannot(Dog.Can_Heal);
    }

    [Test]
    public void Test_Get_Actions()
    {
        var dog = new Dog(Priner, Speed.Fast);
        Test_Actions(dog, Actions.Bark, Actions.Walk, Actions.Swim, Actions.Injure);
    }

    [Test]
    public void Test_Bark()
    {
        new Dog(Priner, Speed.Normal).Bark();
        Test_Action_Message("Dog is ", Actions.Barking);
    }
}