namespace Markdown;

public class MdToken
{
    private MdTokenType _tokenType;
    private MdToken _content;

    public MdToken(MdTokenType tokenType, MdToken content)
    {
        _tokenType = tokenType;
        _content = content;
    }

    public MdToken(string content)
    {
        _tokenType = MdTokenType.Text;
        _content = new MdToken(MdTokenType.Text, new MdToken(content));
    }
}