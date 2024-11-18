using Markdown;

namespace MarkdownProcessorTests;

public class Tests
{

    private MarkdownToHTML md;
    [SetUp]
    public void Setup()
    {
        md = new MarkdownToHTML();
    }
    
    [Test]
    public void ConvertToHtml_Mixed_ReturnsCorrectHtml()a
    {
        string actual = md.ConvertMarkdownToHtml("# Я - Эмир\nПривет я Эмир, я не __жирный__ и не _кривой_");
        string expected = "<h1>Я - Эмир</h1>\nПривет я Эмир, я не <strong>жирный</strong> и не <em>кривой</em> ";

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void ConvertToHtml_EmptyString_ReturnsEmptyString()
    {
        string markdown = string.Empty;
        string actual = md.ConvertMarkdownToHtml(markdown);

        Assert.AreEqual(string.Empty, actual);
    }

    [Test]
    public void ConvertToHtml_NullString_ReturnsEmptyString()
    {
        string markdown = null;
        string actual = md.ConvertMarkdownToHtml(markdown);
        
        Assert.AreEqual(string.Empty, actual);
    }

    [Test]
    public void ConvertToHtml_SingleHeading_ReturnsCorrectHtml()
    {
        string markdown = "# Heading";
        string actual = md.ConvertMarkdownToHtml(markdown);
        
        Assert.AreEqual("<h1>Heading</h1>\n", actual);
    }

    [Test]
    public void ConvertToHtml_BoldText_ReturnsCorrectHtml()
    {
        string markdown = "__Bold Text__";
        string actual = md.ConvertMarkdownToHtml(markdown);

        Assert.AreEqual("<strong>Bold Text</strong> ", actual);
    }

    [Test]
    public void ConvertToHtml_ItalicText_ReturnsCorrectHtml()
    {
        string markdown = "_Italic Text_";
        string actual = md.ConvertMarkdownToHtml(markdown);

        Assert.AreEqual("<em>Italic Text</em> ", actual);
    }

    [Test]
    public void ConvertToHtml_MixedMarkdown_ReturnsCorrectHtml()
    {
        string markdown = "# Header\nThis is __bold__ and _italic_ text";
        string actual = md.ConvertMarkdownToHtml(markdown);
        
        string expectedHtml = "<h1>Header</h1>\nThis is <strong>bold</strong> and <em>italic</em> text ";
        Assert.AreEqual(expectedHtml, actual);
    }
}