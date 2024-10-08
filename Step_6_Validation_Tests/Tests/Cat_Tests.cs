
using Step_6_Validation;

namespace Step_6_Validation_Tests;

public class Cat_Tests : Entity_Test_Base
{
    protected override Entities Entity => Entities.Cat;

    [Test]
    public void Test_Available_Actions()
    {
        Assert_Equivalent(Subject.Available_Actions(), Actions.Meow, Actions.Walk, Actions.Injure, Actions.Heal);
    }
}