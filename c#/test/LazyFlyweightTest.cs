using Xunit;
using System;

namespace Lncodes.Tutorial.Flyweight.Test
{
    public sealed class LazyFlyweightTest
    {
        [Theory]
        [ClassData(typeof(LazyFlyweightTheoryData))]
        public void Make_FlyweightGunModel_AreEqual(Tuple<GunTypes, GunModel> tuple, GunTypes expectedTypes)
        {
            var gunModelFlyweight = new LazyGunModelFlyweight();
            gunModelFlyweight.StoreGunModel(tuple.Item1, tuple.Item2);

            var expected = gunModelFlyweight.GetGunModel(expectedTypes);
            var gunController = new GunController(expected);
            var actual = gunController.GetGunModel();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(LazyFactoryFlyweightTheoryData))]
        public void Make_FlyweightGunModel_ThroughFactory_AreEqual(GunTypes expectedTypes)
        {
            var factoryGunModelFlyweight = new LazyFactoryGunModelFlyweight();
            var expected = factoryGunModelFlyweight.GetGunModel(expectedTypes);

            var gunController = new GunController(expected);
            var actual = gunController.GetGunModel();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [ClassData(typeof(LazyFactoryFlyweightTheoryData))]
        public void Make_FlyweightGunModel_ThroughSingletonFactory_AreEqual(GunTypes expectedTypes)
        {
            var singeltonFactoryGunModelFlyweight = SingletonLazyFactoryGunModelFlyweight.GetInstance();
            var expected = singeltonFactoryGunModelFlyweight.GetGunModel(expectedTypes);

            var gunController = new GunController(expected);
            var actual = gunController.GetGunModel();

            Assert.Equal(expected, actual);
        }
    }
}
