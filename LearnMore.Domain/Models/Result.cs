using LearnMore.Domain.Enums;

namespace LearnMore.Domain.Models
{
    public class Result
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
            if (result)
            {
                this.Status = ResultStatus.Success;
            }
            else
            {
                this.Status = ResultStatus.Failed;
            }
        }

        public ResultStatus Status { get; private set; }

        public string Message { get; private set; }
    }
}
