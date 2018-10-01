using System.Collections.Generic;

namespace LearnMore.Domain.Models.Test
{
    public class Test
    {
        public Test()
        {
            this.Questions = new List<Question>();
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public List<Question> Questions { get; set; }     
    }
}