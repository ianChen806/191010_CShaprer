namespace Exercise;

public class RefOutExercise
{
    [Fact]
    public void out_Pass()
    {
        var str = "10";
        int result;
        var target = new CustomInt();

        // TODO 實現一個 int.TryParse
        // var parse = target.TryParse("...");

        // parse.Should.BeTrue();
        // result.Should().Be(10);
    }

    [Fact]
    public void out_Fail()
    {
        var str = "string";
        int result;
        var target = new CustomInt();

        // TODO 實現一個 int.TryParse
        // var parse = target.TryParse("...");

        // parse.Should.BeFalse();
        // result.Should().Be(0);
    }
}

public class CustomInt
{
    // use int.Parse
}
