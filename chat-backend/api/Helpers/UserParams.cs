using System;
namespace api.Helpers
{
    public class UserParams
    {
        private int MaxPageSize = 50;
        private int _pageSize = 10;

        public int pageNumber { get; set; } = 1;

        public int pageSize {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public string CurrentUsername { get; set; }

        public string Gender { get; set; }

        public int MinAge { get; set; } = 18;

        public int MaxAge { get; set; } = 200;

        public string OrderBy { get; set; } = "lastActive";
    }
}
