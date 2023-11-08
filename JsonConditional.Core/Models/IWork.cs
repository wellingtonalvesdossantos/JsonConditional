using JsonConditional.Core.Models.Enums;

namespace JsonConditional.Core.Models
{
    public interface IWork
    {
        EWorkType Type { get; }
        string? Title { get; set; }
        IWork? Father { get; set; }

        bool IsRatingEnable { get; set; }
        bool IsLeadFlagEnable { get; set; }
        bool IsResponseEnable { get; set; }
    }
}
