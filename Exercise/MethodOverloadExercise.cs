namespace Exercise;

public class MethodOverloadExercise
{
    [Fact]
    public void Method()
    {
        // 實現一組方法, 可以計算 int、decimal、double 三種型別的加法
        var calculator = new Calculator();

        // calculator.Add(1, 2).Should().Be(3);
        // calculator.Add(1.1, 2.2).Should().Be(3.3);
        // calculator.Add(1.1m, 2.2m).Should().Be(3.3m);
    }

    private class Calculator
    {
        // TODO
    }
}
