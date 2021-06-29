namespace Lncodes.Tutorial.Flyweight
{
    public abstract class FactoryGunModelFlyweight : GunModelFlyweight
    {
        /// <summary>
        /// Method to make gun model
        /// </summary>
        /// <param name="gunType"></param>
        /// <returns cref="GunModel"></returns>
        protected GunModel MakeGunModel(GunTypes gunType)
        {
            switch (gunType)
            {
                case GunTypes.M16:
                    return new GunModel(700, 3150, 550);
                case GunTypes.M240:
                    return new GunModel(650, 2800, 800);
                case GunTypes.AK47:
                    return new GunModel(600, 2953, 500);
                default:
                    return new GunModel();
            }
        }
    }
}
