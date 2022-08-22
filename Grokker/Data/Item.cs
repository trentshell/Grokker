using System.Text.Json.Serialization;

namespace Grokker.Data;

public class Item
{
    public int Id { get; set; }

    [JsonPropertyName("deleted")]
    public bool IsDeleted { get; set; }

    public ItemType Type { get; set; }

    [JsonPropertyName("by")]
    public string AuthorId { get; set; }
    
    [JsonPropertyName("time")]
    public long CreationTimeInUnixSeconds { get; set; }

    public DateTimeOffset CreationTime => DateTimeOffset.FromUnixTimeSeconds(CreationTimeInUnixSeconds);
    
    public string Text { get; set; }
    
    [JsonPropertyName("dead")]
    public bool IsDead { get; set; }

    [JsonPropertyName("parent")]
    public int ParentId { get; set; }
    
    [JsonPropertyName("poll")]
    public int PollId { get; set; }
    
    [JsonPropertyName("kids")]
    public int[] ChildrenIds { get; set; }
    
    public string Url { get; set; }
    
    public int Score { get; set; }
    
    public string Title { get; set; }
    
    [JsonPropertyName("parts")]
    public int[] PollOptionIds { get; set; }
    
    [JsonPropertyName("descendents")]
    public int[] TotalCommentCount { get; set; }
}