using FluentAssertions;

namespace Exercise;

public class ParamsExercise
{
    [Fact]
    public void Method()
    {
        // 不異動MyClass的情況下, 讓測試通過
        var myClass = new MyClass();
        var result = myClass.Add(1, 2, 3, 4, 5);
        result.Should().Be("key=14");
    }

    private class MyClass
    {
        public string Add(params int[] values)
        {
            return $"key={values.Sum()}";
        }

        public string Add(int key, params int[] values)
        {
            return $"{key}={values.Sum()}";
        }
    }
}
