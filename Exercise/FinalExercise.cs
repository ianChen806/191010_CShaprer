using FluentAssertions;

namespace Exercise;

public class FinalExercise
{
    /*
     * 設計一個 Class "Book"
     * 傳入 Title、Author、Isbn(13碼數字) 建立並初始化物件, Author 未填寫預設為 "Unknown"
     * 提供一個屬性 Isbn, 唯讀不可設定, 返回格式 "ISBN-{Isbn}"
     * 提供一個方法 GetInfo, 返回 Title, Author, Isbn
     * 提供一個索引子 傳入章節號(int)作為索引, 返回或設定章節名稱(string)
     */
    [Fact]
    public void Method()
    {
        // sample
        /*
         * var book = new Book("Title", "Author", 9781234567890);
         * book.Isbn.Should().Be("ISBN-9781234567890");
         * book.GetInfo().Should().BeEquivalentTo(new
           {
                Title = "title",
                Author = "author",
                Isbn = "ISBN-9781234567890",
           });
         * book[1] = "Chapter 1";
         * book[1].Should().Be("Chapter 1");
         */
    }
}
