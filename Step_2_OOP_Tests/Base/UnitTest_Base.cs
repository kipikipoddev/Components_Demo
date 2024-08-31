using Step_2_OOP;

namespace Step_2_OOP_Tests;

public class UnitTest_Base
{
    protected Test_Priner Priner;

    [SetUp]
    public virtual void Setup()
    {
        Priner = new Test_Priner();
    }

    protected void Test_Actions(Entity entity, params Actions[] actions)
    {
        var entity_actions = entity.Get_Actions().ToArray();
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

    protected void Test_Action_Message(string message, Actions action, Speed? speed = null)
    {
        var speed_str = speed != null ? Get_Speed(speed) : string.Empty;
        Test_Message(message + action.ToString().ToLower() + speed_str);
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