namespace Markdown;

public class MarkdownToHTML : IRenderer
{
    public string Render(string input)
    {
        if (input == null)
            return null;
        return input;
    }
}