
using Step_5_Final;

namespace Step_5_Final_Tests;

public class Cat_Tests : Entity_Test_Base
{
    protected override Entities Entity => Entities.Cat;

    [Test]
    public void Test_Available_Actions()
    {
        Assert_Equivalent(Subject.Available_Actions(), Actions.Meow, Actions.Walk, Actions.Injure, Actions.Heal);
    }
}