

namespace TreehouseDefense
{
    public interface IMappable
    {
        MapLocation Location { get; }
    }

    public interface IMoveable
    {
        void Move();
    }


    public interface IInvader : IMappable, IMoveable
    {
        int Health { get; }

        //True if the invader has reached the end of the path
        bool HasScored { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void DecreaseHealth (int factor);
        
    }
}
