using Step_5_Complex;

namespace Step_5_Complex_Tests;

public class Hp_Component_Tests : UnitTest_Base
{
    private const int Max_Hp = 3;
    protected override string File_Name => "Hp_Component";

    [Test]
    public void Test_Injure()
    {
        new Injure_Command(Subject).Send();

        Assert_Printed("Name was injured");
    }

    [Test]
    public void Test_Heal()
    {
        new Heal_Command(Subject).Send();

        Assert_Printed("Name can't heal");
    }

    [Test]
    public void Test_Heal_After_Injured()
    {
        new Injure_Command(Subject).Send();
        new Heal_Command(Subject).Send();

        Assert_Printed("Name was healed");
    }

    [Test]
    public void Test_Hp()
    {
        var hp = Subject.Get<IHp_Component>();
        Assert.That(hp.Max_Hp, Is.EqualTo(Max_Hp));
        Assert.That(hp.Hp, Is.EqualTo(Max_Hp));
        Assert.That(hp.Is_Alive, Is.True);
        Assert.That(hp.Is_Injured, Is.False);
    }

    [Test]
    public void Test_Hp_After_Injure()
    {
        new Injure_Command(Subject).Send();

        var hp = Subject.Get<IHp_Component>();
        Assert.That(hp.Max_Hp, Is.EqualTo(Max_Hp));
        Assert.That(hp.Hp, Is.EqualTo(Max_Hp - 1));
        Assert.That(hp.Is_Alive, Is.True);
        Assert.That(hp.Is_Injured, Is.True);
    }

    [Test]
    public void Test_Hp_After_Max_Injure()
    {
        for (int i = 0; i < Max_Hp; i++)
            new Injure_Command(Subject).Send();

        var hp = Subject.Get<IHp_Component>();
        Assert.That(hp.Max_Hp, Is.EqualTo(Max_Hp));
        Assert.That(hp.Hp, Is.EqualTo(0));
        Assert.That(hp.Is_Alive, Is.False);
        Assert.That(hp.Is_Injured, Is.True);
    }

    [Test]
    public void Test_Hp_Heal()
    {
        new Injure_Command(Subject).Send();
        new Heal_Command(Subject).Send();

        var hp = Subject.Get<IHp_Component>();
        Assert.That(hp.Max_Hp, Is.EqualTo(Max_Hp));
        Assert.That(hp.Hp, Is.EqualTo(Max_Hp));
        Assert.That(hp.Is_Alive, Is.True);
        Assert.That(hp.Is_Injured, Is.False);
    }

    [Test]
    public void Test_Injure_If_Dead()
    {
        for (int i = 0; i < Max_Hp; i++)
            new Injure_Command(Subject).Send();
        new Injure_Command(Subject).Send();

        Assert_Printed("Name can't injure");
    }

    [Test]
    public void Test_Heal_If_Dead()
    {
        for (int i = 0; i < Max_Hp; i++)
            new Injure_Command(Subject).Send();
        new Heal_Command(Subject).Send();

        Assert_Printed("Name can't heal");
    }
}