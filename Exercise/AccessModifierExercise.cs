namespace Exercise;

public class AccessModifierExercise
{
    [Fact]
    public void Method()
    {
        var member = new Member(id: 1, name: "test");

        // TODO
        // don't get
        // var id = member.Id;

        // pass this
        // var id = member.GetId();
        // id.Should().Be(1);

        // pass this
        // member.Name.Should().Be("test");
    }

    private class Member
    {
        public Member(int id, string name)
        {
            // TODO
        }
    }
}
