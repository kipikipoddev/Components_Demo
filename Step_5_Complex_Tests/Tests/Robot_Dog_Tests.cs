using Step_5_Complex;

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
        Assert_False(Subject.Get<ICharged_Component>().Has_Charge);
    }

    [Test]
    public void Test_Actions_After_Charge()
    {
        new Charge_Command(Subject).Send();

        Assert_Valid<Bark_Command>(true);
        Assert_Valid<Walk_Command>(true);
        Assert_Valid<Swim_Command>(true);
        Assert_Valid<Charge_Command>(false);
        Assert_True(Subject.Get<ICharged_Component>().Has_Charge);
    }

    [TestCase(Volume.Quiet)]
    public void Test_Bark(Volume volume)
    {
        new Bark_Command(Subject, volume).Send();

        Assert_Cant_Printed(Actions.Bark);
    }

    [Test]
    public void Test_Bark_When_Injure()
    {
        new Charge_Command(Subject).Send();

        new Bark_Command(Subject, Volume.Quiet).Send();

        Assert_Was_Printed(Actions_Description.Barking);
    }
}