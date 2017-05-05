using System;

namespace TreehouseDefense
{
    public class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = 1;

        private static readonly Random _random = new Random();

        protected readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        

        public bool IsSuccessfulShot()
        {
            //return _random.NextDouble() < Accuracy;
            return true;
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
                }
            }
        }
    }
}
