namespace MonoGame.ConwaysGameOfLife.Extensions
{
    public static class IntegerExtensions
    {
        public static bool InBetween(this int i, int min, int max)
        {
            return i >= min && i <= max;
        }
    }
}