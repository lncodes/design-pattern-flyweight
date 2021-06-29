using System;

namespace Lncodes.Tutorial.Flyweight
{
    public sealed class SingletonLazyFactoryGunModelFlyweight : LazyFactoryGunModelFlyweight
    {
        #region Singleton
        private static readonly Lazy<SingletonLazyFactoryGunModelFlyweight> _instance = new Lazy<SingletonLazyFactoryGunModelFlyweight>(CreateInstance);

        /// <summary>
        /// Constructor
        /// </summary>
        private SingletonLazyFactoryGunModelFlyweight() { }

        /// <summary>
        /// Function to create an instance
        /// </summary>
        /// <returns cref="SingeltonFacade"></returns>
        public static SingletonLazyFactoryGunModelFlyweight CreateInstance() =>
            new SingletonLazyFactoryGunModelFlyweight();

        /// <summary>
        /// Function to get this class instance
        /// </summary>
        /// <returns cref="SingeltonFacade"></returns>
        public static SingletonLazyFactoryGunModelFlyweight GetInstance() =>
            _instance.Value;
        #endregion
    }
}
