using Xunit;
using System.Collections.Generic;

namespace Lncodes.Tutorial.Flyweight.Test
{
    public sealed class EagerFlyweightTheoryData : TheoryData<IDictionary<GunTypes, GunModel>, GunTypes>
    {
        public EagerFlyweightTheoryData()
        {
            Add(new Dictionary<GunTypes, GunModel> { { GunTypes.AK47, new GunModel(600, 2953, 500) } }, GunTypes.AK47);
        }
    }
}
