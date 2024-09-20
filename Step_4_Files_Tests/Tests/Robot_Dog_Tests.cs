

using Step_4_Files;

namespace Step_4_Files_Tests;

public class Robot_Dog_Tests : UnitTest_Base
{
    protected override Entities Entity => Entities.Robot_Dog;

    [Test]
    public void Test_Actions()
    {
        Assert_False(Subject.Get<IBark_Component>().Can_Bark());
        Assert_False(Subject.Get<IWalk_Component>().Can_Walk());
        Assert_True(Subject.Get<ICharged_Component>().Can_Charge());
        Assert_False(Subject.Get<ICharged_Component>().Is_Charged);
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        Subject.Get<ICharged_Component>().Charge();

        Assert_True(Subject.Get<IBark_Component>().Can_Bark());
        Assert_True(Subject.Get<IWalk_Component>().Can_Walk());
        Assert_False(Subject.Get<ICharged_Component>().Can_Charge());
        Assert_True(Subject.Get<ICharged_Component>().Is_Charged);
    }

    [Test]
    public void Test_Bark()
    {
        Subject.Get<IBark_Component>().Bark();

        Assert_Printed("Robot_Dog can't bark");
    }

    [Test]
    public void Test_Bark_After_Charge()
    {
        Subject.Get<ICharged_Component>().Charge();

        Subject.Get<IBark_Component>().Bark();

        Assert_Printed("Robot_Dog was barking");
    }
}