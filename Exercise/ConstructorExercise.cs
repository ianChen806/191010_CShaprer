using FluentAssertions;

namespace Exercise;

public class ConstructorExercise
{
    [Fact]
    public void Ctor()
    {
        // Name 必填, 預設 Age: 10, Email: default
        // TODO 實作多個ctor, 並且使用 this 關鍵字來避免重複程式碼

        // var user1 = new User("user1");
        // var user2 = new User("user2", 20);
        // var user3 = new User("user3", 30, "test@test.com");
        //
        // user1.Should().BeEquivalentTo(new
        // {
        //     Name = "user1",
        //     Age = 10,
        //     Email = "default"
        // });
        // user2.Should().BeEquivalentTo(new
        // {
        //     Name = "user2",
        //     Age = 20,
        //     Email = "default"
        // });
        // user3.Should().BeEquivalentTo(new
        // {
        //     Name = "user3",
        //     Age = 30,
        //     Email = "test@test.com"
        // });
    }

    private class User
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Email { get; private set; }

        // TODO
    }
}
