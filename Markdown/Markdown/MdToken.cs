namespace Markdown;

public class MdToken
{
    private MdTokenType _tokenType;
    private string _content;

    public MdToken(MdTokenType tokenType, string content)
    {
        _tokenType = tokenType;
        _content = content;
    }
}