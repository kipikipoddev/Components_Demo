
using Step_5_Actions;

namespace Step_5_Actions_Tests;

public class Robot_Dog_Tests : Entity_Test_Base
{
    protected override Entities Entity => Entities.Robot_Dog;

    [Test]
    public void Test_Available_Actions()
    {
        Assert_Equivalent(Subject.Available_Actions(), Actions.Bark, Actions.Walk, Actions.Charge);
    }
}