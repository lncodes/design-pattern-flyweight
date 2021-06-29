using Xunit;
using System;

namespace Lncodes.Tutorial.Flyweight.Test
{
    public sealed class LazyFlyweightTheoryData : TheoryData<Tuple<GunTypes, GunModel>, GunTypes>
    {
        public LazyFlyweightTheoryData()
        {
            Add(new Tuple<GunTypes, GunModel>(GunTypes.M16, new GunModel(700, 3150, 550)), GunTypes.M16);
        }
    }
}
