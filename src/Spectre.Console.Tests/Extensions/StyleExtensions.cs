namespace Spectre.Console.Tests
{
    internal static class StyleExtensions
    {
        public static Style SetColor(this Style style, Color color, bool foreground)
        {
            if (foreground)
            {
                return style.Foreground(color);
            }

            return style.Background(color);
        }
    }
}
