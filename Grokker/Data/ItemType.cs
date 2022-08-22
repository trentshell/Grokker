using System.Text.Json.Serialization;

namespace Grokker.Data;

public enum ItemType
{
    Job,
    Story,
    Comment,
    Poll,
    [JsonPropertyName("pollopt")]
    PollOption
}