using System;

namespace ConstructorSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new SearchRecordService(1, 25);
        }
    }

    internal class SearchRecordService
    {
        private readonly int _page;
        private readonly int _pageSize;

        public SearchRecordService(int page, int pageSize)
        {
            _page = page;
            _pageSize = pageSize;
        }
    }
}