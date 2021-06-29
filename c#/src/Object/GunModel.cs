namespace Lncodes.Tutorial.Flyweight
{
    public struct GunModel
    {
        private readonly int _fireRate;
        private readonly int _muzzleVelocity;
        private readonly int _effectiveFireRange;

        public GunModel(int fireRate, int muzzleVelocity, int effectiveFireRange) =>
            (_fireRate, _muzzleVelocity, _effectiveFireRange) = (fireRate, muzzleVelocity, effectiveFireRange);
    }
}
