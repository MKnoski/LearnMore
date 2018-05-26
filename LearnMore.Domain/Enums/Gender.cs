using System.ComponentModel;

namespace LearnMore.Domain.Enums
{
    public enum Gender
    {
        Unknown = 0,

        [Description("Female")]
        Female,

        [Description("Male")]
        Male
    }
}
