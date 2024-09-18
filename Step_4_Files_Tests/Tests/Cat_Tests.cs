using Step_4_Files;

namespace Step_4_Files_Tests;

public class Cat_Tests : UnitTest_Base
{
    protected override Entities Entity => Entities.Cat;

    [Test]
    public void Test_Actions()
    {
        Assert_True(Subject.Get<IMeow_Component>().Can_Meow());
        Assert_True(Subject.Get<IWalk_Component>().Can_Walk());
        Assert_True(Subject.Get<IInjure_Component>().Can_Injure());
        Assert_False(Subject.Get<IInjure_Component>().Can_Heal());
        Assert_False(Subject.Get<IInjure_Component>().Is_Injured);
    }

    [Test]
    public void Test_Actions_After_Injure()
    {
        Subject.Get<IInjure_Component>().Injure();

        Assert_False(Subject.Get<IMeow_Component>().Can_Meow());
        Assert_False(Subject.Get<IWalk_Component>().Can_Walk());
        Assert_False(Subject.Get<IInjure_Component>().Can_Injure());
        Assert_True(Subject.Get<IInjure_Component>().Can_Heal());
        Assert_True(Subject.Get<IInjure_Component>().Is_Injured);
    }

    [Test]
    public void Test_Meow()
    {
        Subject.Get<IMeow_Component>().Meow();

        Assert_Printed("Cat was meowing");
    }

    [Test]
    public void Test_Meow_When_Injure()
    {
        Subject.Get<IInjure_Component>().Injure();

        Subject.Get<IMeow_Component>().Meow();

        Assert_Printed("Cat can't meow");
    }
}