using System;

namespace TreehouseDefense
{
    class SuperInvader : Invader
    {

        private static Random _random = new Random();

        public override int Health { get; protected set; } = 3;

        protected override int StepSize { get; } = 2;


        public override void DecreaseHealth(int factor)
        {
            if (_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at a super invader but it sustained no damage.");
            }
        }

        public SuperInvader(Path path) : base(path)
        {
        }
    }
}