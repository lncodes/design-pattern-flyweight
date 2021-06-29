using System.Collections.Generic;

namespace Lncodes.Tutorial.Flyweight
{
    public class LazyFactoryGunModelFlyweight : FactoryGunModelFlyweight
    {
        protected override IDictionary<GunTypes, GunModel> GunModelCollection { get; } = new Dictionary<GunTypes, GunModel>();

        /// <inheritdoc cref="GunModelFlyweight"/>
        public override GunModel GetGunModel(GunTypes gunType)
        {
            if(!GunModelCollection.ContainsKey(gunType))
                GunModelCollection.Add(gunType, MakeGunModel(gunType));
            return GunModelCollection[gunType];
        }
    }
}