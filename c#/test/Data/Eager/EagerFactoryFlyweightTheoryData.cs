using Xunit;
using System.Collections.Generic;

namespace Lncodes.Tutorial.Flyweight.Test
{
    public sealed class EagerFactoryFlyweightTheoryData : TheoryData<IEnumerable<GunTypes>, GunTypes>
    {
        public EagerFactoryFlyweightTheoryData()
        {
            Add(new GunTypes[] { GunTypes.M16 }, GunTypes.M16);
        }
    }
}
