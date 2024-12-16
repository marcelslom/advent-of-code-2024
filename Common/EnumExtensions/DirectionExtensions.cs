using Common.Enum;

namespace Common.EnumExtensions
{
    public static class DirectionExtensions
    {
        public static (int x, int y) GetNeighbour(this Direction direction, (int x, int y) origin)
        {
            var (x, y) = direction.GetDirectionVector();
            return (x: origin.x + x, y: origin.y + y);
        }

        public static (int x, int y) GetDirectionVector(this Direction direction)
        {
            return direction switch
            {
                Direction.Left => (-1, 0),
                Direction.Right => (1, 0),
                Direction.Up => (0, -1),
                Direction.Down => (0, 1),
                _ => throw new NotImplementedException(),
            };
        }

    }
}
