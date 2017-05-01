namespace TreehouseDefense
{
    public class TreehouseDefenseException : System.Exception
    {
        public TreehouseDefenseException()
        {
        }

        public TreehouseDefenseException(string message) : base(message)
        {
        }
    }

    public class OutOfBoundsException : TreehouseDefenseException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
    class TowerOnPathException : TreehouseDefenseException
    {
        public TowerOnPathException()
        {
        }

        public TowerOnPathException(string message) : base(message)
        {
        }
    }
}