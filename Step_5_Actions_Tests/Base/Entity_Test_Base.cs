using Step_5_Final;

namespace Step_5_Final_Tests;

public abstract class Entity_Test_Base : UnitTest_Base
{
    protected abstract Entities Entity { get; }

    protected override IComponents Get_Subject()
    {
        return Components_Factory.Create(Entity);
    }
}