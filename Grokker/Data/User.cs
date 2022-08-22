using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Html;

namespace Grokker.Data;

public class User
{
    public string Id { get; set; }
    
    [JsonPropertyName("created")]
    public long CreationTimeInUnixSeconds { get; set; }

    public DateTimeOffset CreationTime => DateTimeOffset.FromUnixTimeSeconds(CreationTimeInUnixSeconds);

    public int Karma { get; set; }
    
    public HtmlString About { get; set; }
    
    public int[] Submitted { get; set; }
}