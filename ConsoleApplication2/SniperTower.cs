namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = .90;

        public SniperTower(MapLocation location, Path path) : base(location, path)
        { }
    }
}
