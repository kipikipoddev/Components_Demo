using Step_2_Components;

namespace Step_2_Components_Tests;

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
        Assert_Was_Printed(Actions_Description.Meowing);
    }

    [Test]
    public void Test_Meow_When_Injure()
    {
        Subject.Get<IInjure_Component>().Injured();

        Subject.Get<IMeow_Component>().Meow();
        Assert_Cant_Printed(Actions.Meow);
    }

    [Test]
    public void Test_Walk()
    {
        Subject.Get<IWalk_Component>().Walk();
        Assert_Was_Printed(Actions_Description.Walking);
    }

    [Test]
    public void Test_Walk_When_Injure()
    {
        Subject.Get<IInjure_Component>().Injured();

        Subject.Get<IWalk_Component>().Walk();
        Assert_Cant_Printed(Actions.Walk);
    }

    protected override IComponents Get_Subject()
    {
        return Components_Factory.Create_Cat();
    }
}