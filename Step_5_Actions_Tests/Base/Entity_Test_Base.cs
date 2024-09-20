using Step_5_Actions;

namespace Step_5_Actions_Tests;

public abstract class Entity_Test_Base : UnitTest_Base
{
    protected abstract Entities Entity { get; }

    protected override IComponents Get_Subject()
    {
        return Components_Factory.Create(Entity);
    }
}