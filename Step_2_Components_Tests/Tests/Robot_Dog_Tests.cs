using Step_2_Components;

namespace Step_2_Components_Tests;

public class Robot_Dog_Tests : UnitTest_Base
{
    [Test]
    public void Test_Actions()
    {
        Assert_False(Subject.Get<IBark_Component>().Can_Bark());
        Assert_False(Subject.Get<IWalk_Component>().Can_Walk());
        Assert_False(Subject.Get<ISwim_Component>().Can_Swim());
        Assert_True(Subject.Get<ICharged_Component>().Can_Charge());
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        Subject.Get<ICharged_Component>().Charge();

        Assert_True(Subject.Get<IBark_Component>().Can_Bark());
        Assert_True(Subject.Get<IWalk_Component>().Can_Walk());
        Assert_True(Subject.Get<ISwim_Component>().Can_Swim());
        Assert_False(Subject.Get<ICharged_Component>().Can_Charge());
    }

    [Test]
    public void Test_Bark()
    {
        Subject.Get<ICharged_Component>().Charge();

        Subject.Get<IBark_Component>().Bark();
        Assert_Was_Printed(Actions_Description.Barking);
    }

    protected override IComponents Get_Subject()
    {
        return Components_Factory.Create_Robot_Dog();
    }
}