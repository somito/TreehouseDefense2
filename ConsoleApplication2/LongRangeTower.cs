namespace TreehouseDefense
{
    class LongRangeTower : Tower
    {
        protected override int Range { get; } = 3;

        public LongRangeTower(MapLocation location, Path path) : base(location, path)
        { }
    }
}
