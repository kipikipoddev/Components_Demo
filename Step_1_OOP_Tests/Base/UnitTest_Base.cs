using Step_1_OOP;

namespace Step_1_OOP_Tests;

public abstract class UnitTest_Base<T>
    where T : IEntity
{
    protected Test_Printer Priner;

    protected T Subject;

    [SetUp]
    public virtual void Setup()
    {
        Priner = new Test_Printer();
        Subject = Get_Subject();
    }

    protected abstract T Get_Subject();

    protected void Test_Actions(params Actions[] actions)
    {
        var entity_actions = Subject.Get_Actions().ToArray();
        Assert.That(entity_actions.Length, Is.EqualTo(actions.Length));
        foreach (var entity_action in entity_actions)
            Assert.True(actions.Contains(entity_action));
    }

    protected void Can(bool expected)
    {
        Assert.That(expected, Is.True);
    }

    protected void Cannot(bool expected)
    {
        Assert.That(expected, Is.False);
    }

    protected void Test_Message(string message)
    {
        Assert.That(Priner.Messages.Last(), Is.EqualTo(message));
    }

    protected void Test_Action_Message(Actions action, Speed? speed = null)
    {
        var speed_str = speed != null ? Get_Speed(speed) : string.Empty;
        var action_set = action.ToString().ToLower();
        Test_Message($"{Subject.Name} is {action_set}{speed_str}");
    }


    protected void Test_Cannot_Action(Actions action)
    {
        var action_set = action.ToString().ToLower();
        Test_Message($"{Subject.Name} cannot {action_set}");
    }

    private static string Get_Speed(Speed? speed)
    {
        return speed switch
        {
            Speed.Slow => " slowly",
            Speed.Fast => " fast",
            _ => string.Empty,
        };
    }
}