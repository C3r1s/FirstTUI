using System.Text;

namespace TestConsoleUI;

public class Cli
{
    public static string ListPrint(List<string> list)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in list)
        {
            sb.Append(item).Append(", ");
        }
        if (sb.Length > 2)
        {
            sb.Length -= 2; // Remove the last comma and space
        }
        return sb.ToString();
    }
}
