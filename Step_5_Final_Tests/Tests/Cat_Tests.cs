
using Step_5_Final;

namespace Step_5_Final_Tests;

public class Cat_Tests : Entity_Test_Base
{
    protected override Entities Entity => Entities.Cat;

    [Test]
    public void Test_Components()
    {
        Assert_Length(6, Subject.Get_All());
        Assert_True(Subject.Has<IName_Component>());
        Assert_True(Subject.Has<IDisabled_Component>());
        Assert_True(Subject.Has<IInjure_Component>());
        Assert_True(Subject.Has<IWalk_Component>());
        Assert_True(Subject.Has<IMeow_Component>());
    }
}