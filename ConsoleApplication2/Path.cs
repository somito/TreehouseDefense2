namespace TreehouseDefense
{
    public class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        public int PathEnd => _path.Length;

        public bool OnPath(Point point)
        {
            for (int i = 0; i < _path.Length; i++)
            { if (_path[i].X == point.X && _path[i].Y == point.Y) return true; }
            return false;
        }

    }
}
