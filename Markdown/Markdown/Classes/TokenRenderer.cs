using System.Text;

namespace Markdown;

public class TokenRenderer : IRenderer
{
    private StringBuilder _outputHtml = new StringBuilder();
    public string Render(string input)
    {
        if (input == null)
            return string.Empty;
        MarkdownMarkdownParser mdMarkdownParser = new MarkdownMarkdownParser();
        ConvertTokensToHtml(mdMarkdownParser.ParseTokens(input));
        return _outputHtml.ToString();
    }
    
    public void ConvertTokensToHtml(List<MdToken> mdTokens)
    {
        foreach (var mdToken in mdTokens)
        {
            StringBuilder tokenContent = new StringBuilder();
            switch (mdToken.Type)
            {
                case MdTokenType.Heading:
                    AppendHeader(mdToken);
                    break;
                case MdTokenType.Bold:
                    AppendBold(mdToken);
                    break;
                case MdTokenType.Italic:
                    AppendItalic(mdToken);
                    break;
                case MdTokenType.Text:
                    AppendText(mdToken);
                    break;
            }
        }
    }

    public void AppendHeader(MdToken token)
    {
        StringBuilder header = new StringBuilder();
        
        header.Append("<h1>");
        header.Append(token.GetContent());
        header.Append("</h1>");
        header.Append("\n");
        _outputHtml.Append(header);
    }

    public void AppendBold(MdToken token)
    {
        StringBuilder bold = new StringBuilder();
        bold.Append("<strong>");
        bold.Append(token.GetContent());
        bold.Append("</strong>");
        bold.Append(" ");
        _outputHtml.Append(bold);
    }
    
    public void AppendItalic(MdToken token)
    {
        StringBuilder italic = new StringBuilder();
        italic.Append("<em>");
        italic.Append(token.GetContent());
        italic.Append("</em>");
        italic.Append(" ");
        _outputHtml.Append(italic);
    }
    
    public void AppendText(MdToken token)
    {
        StringBuilder text = new StringBuilder();
        text.Append(token.GetContent());
        text.Append(" ");
        _outputHtml.Append(text);
    }   
}