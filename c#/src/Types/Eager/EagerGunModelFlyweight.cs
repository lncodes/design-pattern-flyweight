using System.Collections.Generic;
using System.Collections.Immutable;

namespace Lncodes.Tutorial.Flyweight
{
    public sealed class EagerGunModelFlyweight : GunModelFlyweight
    {
        protected override IDictionary<GunTypes, GunModel> GunModelCollection { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gunModelCollection"></param>
        public EagerGunModelFlyweight(IDictionary<GunTypes, GunModel> gunModelCollection) =>
            GunModelCollection = new Dictionary<GunTypes, GunModel>(gunModelCollection).ToImmutableDictionary();
    }
}
