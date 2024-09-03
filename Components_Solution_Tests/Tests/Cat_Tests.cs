using Components_Basic_Solution;

namespace Components_Solution_Tests;

public class Cat_Tests : UnitTest_Base
{
    [Test]
    public void Test_Actions()
    {
        Assert_True(Subject.Get<IMeow_Component>().Can_Meow());
        Assert_True(Subject.Get<IWalk_Component>().Can_Walk());
        Assert_True(Subject.Get<IInjure_Component>().Can_Injured());
        Assert_False(Subject.Get<IInjure_Component>().Can_Heal());
    }

    [Test]
    public void Test_Actions_After_Injure()
    {
        Subject.Get<IInjure_Component>().Injured();

        Assert_False(Subject.Get<IMeow_Component>().Can_Meow());
        Assert_False(Subject.Get<IWalk_Component>().Can_Walk());
        Assert_False(Subject.Get<IInjure_Component>().Can_Injured());
        Assert_True(Subject.Get<IInjure_Component>().Can_Heal());
    }

    [Test]
    public void Test_Meow()
    {
        Subject.Get<IMeow_Component>().Meow();
        Assert_Was_Printed(Actions.Meowing);
    }

    [Test]
    public void Test_Meow_When_Injure()
    {
        Subject.Get<IInjure_Component>().Injured();

        Subject.Get<IMeow_Component>().Meow();
        Assert_Cant_Printed(Actions.Meow);
    }

    protected override IComponents Get_Subject()
    {
        return Components_Factory.Create_Cat();
    }
}