using System.Collections.Generic;

namespace Lncodes.Tutorial.Flyweight
{
    public sealed class LazyGunModelFlyweight : GunModelFlyweight
    {
        protected override IDictionary<GunTypes, GunModel> GunModelCollection { get; } = new Dictionary<GunTypes, GunModel>();

        /// <summary>
        /// Method to store gun model to the gun model collection
        /// </summary>
        /// <param name="gunType"></param>
        /// <param name="gunModel"></param>
        public void StoreGunModel(GunTypes gunType, GunModel gunModel) =>
            GunModelCollection.TryAdd(gunType, gunModel);
    }
}
