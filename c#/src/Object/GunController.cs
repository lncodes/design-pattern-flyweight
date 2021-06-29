namespace Lncodes.Tutorial.Flyweight
{
    public sealed class GunController
    {
        private readonly GunModel _gunModel;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gunModel"></param>
        public GunController(GunModel gunModel) =>
            _gunModel = gunModel;

        /// <summary>
        /// Get current gun model
        /// </summary>
        /// <returns cref="GunModel"></returns>
        public GunModel GetGunModel() =>
            _gunModel;
    }
}
