using System.Collections.Generic;
using System.Collections.Immutable;

namespace Lncodes.Tutorial.Flyweight
{
    public sealed class EagerFactoryGunModelFlyweight : FactoryGunModelFlyweight
    {
        protected override IDictionary<GunTypes, GunModel> GunModelCollection { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gunTypeCollection"></param>
        public EagerFactoryGunModelFlyweight(IEnumerable<GunTypes> gunTypeCollection)
        {
            var gunModelCollection = new Dictionary<GunTypes, GunModel>();
            foreach (var gunType in gunTypeCollection)
                gunModelCollection.Add(gunType, MakeGunModel(gunType));
            GunModelCollection = gunModelCollection.ToImmutableDictionary();
        }
    }
}
