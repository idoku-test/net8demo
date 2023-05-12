using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

public sealed class TagLine
{
    public string? InitOnly { get; init; }   // This is always null when deserialized with TagLineJsonContext
    public string? Settable { get; set; }
}

[JsonSerializable(typeof(TagLine), GenerationMode = JsonSourceGenerationMode.Metadata)]
public partial class TagLineJsonContext : JsonSerializerContext
{
}
