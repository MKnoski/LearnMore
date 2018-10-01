using System.Collections.Generic;
using LearnMore.Domain.Enums;

namespace LearnMore.Domain.Models.Test
{
    public class Question
    {
        public Question()
        {
            this.Answers = new List<Answer>();
        }

        public string Contents { get; set; }

        public QuestionType Type { get; set; }

        public List<Answer> Answers { get; set; }
    }
}