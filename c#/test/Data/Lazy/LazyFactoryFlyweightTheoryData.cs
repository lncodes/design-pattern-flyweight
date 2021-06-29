using Xunit;

namespace Lncodes.Tutorial.Flyweight.Test
{
    public sealed class LazyFactoryFlyweightTheoryData : TheoryData<GunTypes>
    {
        public LazyFactoryFlyweightTheoryData()
        {
            Add(GunTypes.AK47);
        }
    }
}
