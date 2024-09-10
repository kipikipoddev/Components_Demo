using Step_5_Complex;

namespace Step_5_Complex_Tests;

public class Bark_Component_Test : UnitTest_Base
{
    protected override string File_Name => "Bark_Component";

    [Test]
    public void Test_Bark()
    {
        Assert_Valid<Bark_Command>(true);
    }

    [Test]
    public void Test_Bark_After_Injure()
    {
        Subject.Add(new Hp_Component(2));

        new Injure_Command(Subject).Send();

        Assert_Valid<Bark_Command>(true);
    }

    [Test]
    public void Test_Bark_After_Dead()
    {
        Subject.Add(new Hp_Component(1));

        new Injure_Command(Subject).Send();

        Assert_Valid<Bark_Command>(false);
    }

    [TestCase(Volume.Quiet, "Name was barking quietly")]
    [TestCase(Volume.Normal, "Name was barking normaly")]
    [TestCase(Volume.Loud, "Name was barking loudly")]
    public void Test_Bark_Volumes(Volume volume, string message)
    {
        new Bark_Command(Subject, volume).Send();

        Assert_Printed(message);
    }

    [TestCase(Volume.Quiet, "Name was barking quietly")]
    [TestCase(Volume.Normal, "Name can't bark")]
    [TestCase(Volume.Loud, "Name can't bark")]
    public void Test_Bark_Volumes_When_Injureds(Volume volume, string message)
    {
        Subject.Add(new Hp_Component(2));
        new Injure_Command(Subject).Send();

        new Bark_Command(Subject, volume).Send();

        Assert_Printed(message);
    }

    [Test]
    public void Test_Bark_Actions()
    {
        var actions = Subject.Get<IActions_Component>().Available_Actions;
        
        Assert.That(actions.Contains(Actions.Bark), Is.True);

        Subject.Remove<Bark_Component>();

        Assert.That(actions.Contains(Actions.Bark), Is.False);
    }

    [Test]
    public void Test_Bark_When_No_Component()
    {
        Subject.Remove<Bark_Component>();
        new Bark_Command(Subject, Volume.Loud).Send();

        Assert_Valid<Bark_Command>(false);
        Assert_Printed("Name can't bark");
    }
}