using FluentAssertions;

namespace Exercise;

public class AccessModifierExercise
{
    [Fact]
    public void Method()
    {
        var member = new Member(id: 1, name: "test");

        // 保持不能直接取得 Id
        // var id = member.Id;

        // 只能夠過方法取得 Id
        // var id = member.GetId();
        // id.Should().Be(1);

        // 可以直接取得 Name
        // member.Name.Should().Be("test");
    }

    private class Member
    {
        //TODO
        int Id { get; set; }

        //TODO
        string Name { get; set; }

        public Member(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
