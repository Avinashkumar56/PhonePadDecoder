using Xunit;

public class PhonePadTests
{
    [Theory]
    [InlineData("33#", "E")]
    [InlineData("227*#", "B")]
    [InlineData("4433555 555666#", "HELLO")]
    [InlineData("8 88777444666*664#", "TURING")]
    [InlineData("222 2 22#", "CAB")]
    [InlineData("777733 7777#", "SES")]
    [InlineData("999 9 99#", "YWX")]
    [InlineData("4433555 555666096667775553#", "HELLO WORLD")]
    public void OldPhonePad_ExpectedOutput(string input, string expected)
    {
        var result = PhonePadDecoder.OldPhonePad(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void OldPhonePad_EmptyInput()
    {
        var result = PhonePadDecoder.OldPhonePad("");
        Assert.Equal("", result);
    }

    [Fact]
    public void OldPhonePad_MissingHash()
    {
        var result = PhonePadDecoder.OldPhonePad("33");
        Assert.Equal("", result); // As per spec no # means invalid input
    }

    [Fact]
    public void OldPhonePad_Backspace()
    {
        var result = PhonePadDecoder.OldPhonePad("2*#");
        Assert.Equal("", result);
    }
}
