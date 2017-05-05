using System;

namespace TreehouseDefense
{
    class SuperTower : Tower
    {
        protected override double Accuracy { get; } = .90;
        protected override int Range { get; } = 3;
        protected override int Power { get; } = 2;

        public SuperTower(MapLocation location) : base(location)
        { }

        public override void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("Super Tower shot at and hit an invader.");


                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Invader neutralized at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Super Tower shot at and missed an invader.");
                    }
                    break;
                }
            }
        }
    }
}
