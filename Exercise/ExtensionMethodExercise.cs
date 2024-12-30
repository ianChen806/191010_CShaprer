namespace Exercise;

public class ExtensionMethodExercise
{
    [Fact]
    public void pass()
    {
        // 實現一個string的擴充方法 判斷string是否有值
        var str = "Hello";

        // str.HasValue().Should().BeTrue();
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    [InlineData(" ")]
    public void fail2(string value)
    {
        // 實現一個string的擴充方法
        // value.HasValue().Should().BeFalse();
    }
}
