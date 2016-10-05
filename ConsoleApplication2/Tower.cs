using System;

namespace TreehouseDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        private static readonly Random _random = new Random();

        protected readonly MapLocation _location;

        public Tower(MapLocation location, Path path)
        {
            _location = location;

            if (path.OnPath(_location))
            {
                throw new TowerOnPathException(_location.X + "," + _location.Y + " is on the path, tower cannot be placed here.");
            }
        }

        

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }

        public virtual void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Invader neutralized at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader.");
                    }
                    break;
                }
            }
        }
    }
}
