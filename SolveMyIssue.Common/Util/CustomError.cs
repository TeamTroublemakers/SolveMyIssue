

namespace SolveMyIssue.Common.Util
{
    public class Result : Exception
    {
        public string? Title { get; set; }
        public bool Success { get; set; }
        public Result(string message, string title, bool success) : base(message)
        {
            Title = title;
            Success = success;
        }
        public Result(string message, bool success) : base(message)
        {
            Success = success;
        }
    }
}