
using Step_5_Final;

namespace Step_5_Final_Tests;

public class Injured_Tests : Component_Test_Base<IInjure_Component>
{

    [Test]
    public void Test_Default()
    {
        Assert_False(Component.Is_Injured);
    }

    [Test]
    public void Test_Injure()
    {
        Component.Injure();

        Assert_True(Component.Is_Injured);
        Assert_True(Subject.Get<IDisabled_Component>().Is_Disabled);
        Assert_Printed("Name was injured");
    }

    [Test]
    public void Test_Injure_Again()
    {
        Component.Injure();
        Component.Injure();

        Assert_Printed("Name can't injure");
    }

    [Test]
    public void Test_Heal()
    {
        Component.Heal();

        Assert_Printed("Name can't heal");
    }

    [Test]
    public void Test_Heal_After_Injured()
    {
        Component.Injure();

        Component.Heal();

        Assert_False(Component.Is_Injured);
        Assert_False(Subject.Get<IDisabled_Component>().Is_Disabled);
        Assert_Printed("Name was healed");
    }

    protected override IComponents Get_Subject()
    {
        return base.Get_Subject().Add(new Disabled_Component(false));
    }

    protected override IInjure_Component Get_Component()
    {
        return new Injure_Component();
    }
}