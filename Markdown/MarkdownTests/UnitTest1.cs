using Markdown;

namespace MarkdownTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        MarkdownToHTML md = new MarkdownToHTML();
    }

    [Test]
    public void ConvertsNull()
    {
        MarkdownToHTML md = new MarkdownToHTML();
        string markdown = "";
        string actualHtml = md.Render(markdown);
        string expectedHtml = "";
        Assert.AreEqual(expectedHtml, actualHtml);
    }

    [Test]
    public void ConvertsBold()
    {
        MarkdownToHTML md = new MarkdownToHTML();
        var markdown = "**Bold**";
        var expectedHtml = "<strong>Bold</strong>";
        string actualHtml = md.Render(markdown);
        Assert.AreEqual(expectedHtml, actualHtml);
    }

    [Test]
    public void ConvertsItalics()
    {
        MarkdownToHTML md = new MarkdownToHTML();
        var markdown = "*Italics*";
        var expectedHtml = "<em>italics</em>";
        string actualHtml = md.Render(markdown);
        Assert.AreEqual(expectedHtml, actualHtml);
    }
    
    [Test]
    public void ConvertsBoldAndItalics()
    {
        MarkdownToHTML md = new MarkdownToHTML();
        var markdown = "***Bold and Italics***";
        var expectedHtml = "<strong><em>Bold and Italics</em></strong>";
        string actualHtml = md.Render(markdown);
        Assert.AreEqual(expectedHtml, actualHtml);
    }
    
    [Test]
    public void ConvertsLineBreak()
    {
        MarkdownToHTML md = new MarkdownToHTML();
        var markdown = "Line1<br>Line2";
        var expectedHtml = "Line1<br />Line2";
        string actualHtml = md.Render(markdown);
        Assert.AreEqual(expectedHtml, actualHtml);
    }
    
    
}