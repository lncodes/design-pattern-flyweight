using Xunit;
using System.Collections.Generic;

namespace Lncodes.Tutorial.Flyweight.Test
{
    public sealed class EagerFlyweightTest
    {
        [Theory]
        [ClassData(typeof(EagerFlyweightTheoryData))]
        public void Make_FlyweightGunModel_AreEqual(IDictionary<GunTypes, GunModel> gunModelCollection, GunTypes expectedTypes)
        {
            var flyweight = new EagerGunModelFlyweight(gunModelCollection);
            var expected = flyweight.GetGunModel(expectedTypes);

            var gunController = new GunController(expected);
            var actual = gunController.GetGunModel();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(EagerFactoryFlyweightTheoryData))]
        public void Make_FlyweightGunModel_ThroughFactory_AreEqual(IEnumerable<GunTypes> gunTypesCollection, GunTypes expectedTypes)
        {
            var flyweightFactory = new EagerFactoryGunModelFlyweight(gunTypesCollection);
            var expected = flyweightFactory.GetGunModel(expectedTypes);

            var gunController = new GunController(expected);
            var actual = gunController.GetGunModel();

            Assert.Equal(expected, actual);
        }
    }
}
