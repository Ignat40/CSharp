using System.Globalization;
using LINQ;

public static class StringExtentions
{
    public static string Capitalize(this string str)
    {
        return new CultureInfo("en-US", false).TextInfo.ToTitleCase(str);;
    }
}