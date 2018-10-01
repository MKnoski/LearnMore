using LearnMore.Domain.Enums;

namespace LearnMore.Domain.Models
{
    public struct Result
    {
        public Result(ResultStatus status, string message = null)
        {
            this.Status = status;
            this.Message = message;
        }

        public Result(string message)
            : this (ResultStatus.Failed, message)
        {
        }

        public Result(bool result)
        {
            this.Status = result ? ResultStatus.Success : ResultStatus.Failed;
            this.Message = null;
        }

        public ResultStatus Status { get; }

        public string Message { get; }
    }
}
