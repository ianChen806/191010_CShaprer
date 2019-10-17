using System;

namespace ConstructorSample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new RecordService(1, 50);
        }
    }

    internal class RecordService
    {
        private readonly int _page;
        private readonly int _pageSize;

        public RecordService(int page, int pageSize)
        {
            _page = page;
            _pageSize = pageSize;
        }
    }
}