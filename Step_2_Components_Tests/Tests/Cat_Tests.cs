using Step_2_Components;

namespace Step_2_Components_Tests;

public class Cat_Tests : UnitTest_Base
{
    [Test]
    public void Test_Actions()
    {
        Assert_True(Subject.Get<IMeow_Model>().Can_Meow());
        Assert_True(Subject.Get<IWalk_Model>().Can_Walk());
        Assert_True(Subject.Get<IInjure_Model>().Can_Injured());
        Assert_False(Subject.Get<IInjure_Model>().Can_Heal());
    }

    [Test]
    public void Test_Actions_After_Injure()
    {
        Subject.Get<IInjure_Model>().Injured();

        Assert_False(Subject.Get<IMeow_Model>().Can_Meow());
        Assert_False(Subject.Get<IWalk_Model>().Can_Walk());
        Assert_False(Subject.Get<IInjure_Model>().Can_Injured());
        Assert_True(Subject.Get<IInjure_Model>().Can_Heal());
    }

    [Test]
    public void Test_Meow()
    {
        Subject.Get<IMeow_Model>().Meow();
        Assert_Was_Printed(Actions.Meowing);
    }

    [Test]
    public void Test_Meow_When_Injure()
    {
        Subject.Get<IInjure_Model>().Injured();

        Subject.Get<IMeow_Model>().Meow();
        Assert_Cant_Printed(Actions.Meow);
    }

    protected override IComponents Get_Subject()
    {
        return Model_Factory.Create_Cat();
    }
}