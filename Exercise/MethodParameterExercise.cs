using FluentAssertions;

namespace Exercise;

public class MethodParameterExercise
{
    [Fact]
    public void Method()
    {
        var emailSender = new EmailSender();

        // 嘗試建立三個sender, 並且分別帶入不同的參數
        /* 1.
         寄件人: test@test.com
         內容: This is a test email
         主旨: Test
        */
        // var sender1 = emailSender.Create("TODO");
        // sender1.Should().BeEquivalentTo(new
        // {
        //     Recipient = "test@test.com",
        //     Subject = "Test",
        //     Content = "This is a test email"
        // });

        /* 2.
         寄件人: test@test.com
         內容: This is a test email
         CC: cc@test.com
         */
        // var sender2 = emailSender.Create("TODO");
        // sender2.Should().BeEquivalentTo(new
        // {
        //     Recipient = "test@test.com",
        //     Content = "This is a test email",
        //     Subject = "No Subject",
        //     CC = "cc@test.com"
        // });
    }

    private class EmailSender
    {
        public Sender Create(
            string recipient,
            string content,
            string subject = "No Subject",
            string cc = null)
        {
            var sender = new Sender();
            sender.Recipient = recipient;
            sender.Subject = subject;
            sender.Content = content;
            if (!string.IsNullOrEmpty(cc))
            {
                sender.CC = cc;
            }
            return sender;
        }
    }

    private class Sender
    {
        public string CC;
        public string BCC;

        public string Recipient { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }
    }
}
