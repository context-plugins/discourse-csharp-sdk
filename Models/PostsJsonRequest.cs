using System.Text.Json.Serialization;

namespace Discourse.Models;

public record PostsJsonRequest
{
    /// <summary>
    /// Required if creating a new topic or new private message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    [JsonPropertyName("raw")]
    public required string Raw { get; init; }

    /// <summary>
    /// Required if creating a new post.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("topic_id")]
    public int? TopicId { get; init; }

    /// <summary>
    /// Optional if creating a new topic, and ignored if creating
    /// a new post.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public int? Category { get; init; }

    /// <summary>
    /// Required for private message, comma separated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target_recipients")]
    public string? TargetRecipients { get; init; }

    /// <summary>
    /// Deprecated. Use target_recipients instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target_usernames")]
    public string? TargetUsernames { get; init; }

    /// <summary>
    /// Required for new private message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("archetype")]
    public string? Archetype { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Optional, the post number to reply to inside a topic.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reply_to_post_number")]
    public int? ReplyToPostNumber { get; init; }

    /// <summary>
    /// Provide a URL from a remote system to associate a forum
    /// topic with that URL, typically for using Discourse as a comments
    /// system for an external blog.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed_url")]
    public string? EmbedUrl { get; init; }

    /// <summary>
    /// Provide an external_id from a remote system to associate
    /// a forum topic with that id.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("external_id")]
    public string? ExternalId { get; init; }

    /// <summary>
    /// If false, the user will not track the topic. By default,
    /// the user will track the topic.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("auto_track")]
    public bool? AutoTrack { get; init; }
}
