using System.Collections.Generic;

namespace Lncodes.Tutorial.Flyweight
{
    public abstract class GunModelFlyweight
    {
        protected abstract IDictionary<GunTypes, GunModel> GunModelCollection { get; }

        /// <summary>
        /// Method to get gun model in the gun model collection
        /// </summary>
        /// <param name="gunType"></param>
        /// <returns cref="GunModel"></returns>
        public virtual GunModel GetGunModel(GunTypes gunType) =>
            GunModelCollection[gunType];
    }
}
