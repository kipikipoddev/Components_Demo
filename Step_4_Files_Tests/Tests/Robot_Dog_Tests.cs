using Step_4_Files;

namespace Step_4_Files_Tests;

public class Robot_Dog_Tests : UnitTest_Base
{
    protected override string File_Name => "Robot_Dog";

    [Test]
    public void Test_Actions()
    {
        Assert_Valid<Bark_Command>(false);
        Assert_Valid<Walk_Command>(false);
        Assert_Valid<Swim_Command>(false);
        Assert_Valid<Charge_Command>(true);
        Assert_False(Subject.Get<ICharged_Component>().Is_Charged);
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        new Charge_Command(Subject).Send();

        Assert_Valid<Bark_Command>(true);
        Assert_Valid<Walk_Command>(true);
        Assert_Valid<Swim_Command>(true);
        Assert_Valid<Charge_Command>(false);
        Assert_True(Subject.Get<ICharged_Component>().Is_Charged);
    }

    [Test]
    public void Test_Bark()
    {
        new Bark_Command(Subject).Send();

        Assert_Cant_Printed(Actions.Bark);
    }

    [Test]
    public void Test_Bark_When_Injure()
    {
        new Charge_Command(Subject).Send();

        new Bark_Command(Subject).Send();

        Assert_Was_Printed(Actions.Barking);
    }
}