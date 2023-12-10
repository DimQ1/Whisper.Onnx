using System.Text.Json.Serialization;

public class ModelTokenizer
{
    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonPropertyName("truncation")]
    public object Truncation { get; set; }

    [JsonPropertyName("padding")]
    public object Padding { get; set; }

    [JsonPropertyName("added_tokens")]
    public List<AddedToken> AddedTokens { get; set; } = [];

    [JsonPropertyName("normalizer")]
    public object Normalizer { get; set; }

    [JsonPropertyName("pre_tokenizer")]
    public PreTokenizer PreTokenizer { get; set; }

    [JsonPropertyName("post_processor")]
    public PostProcessor PostProcessor { get; set; }

    [JsonPropertyName("decoder")]
    public Decoder Decoder { get; set; }

    [JsonPropertyName("model")]
    public Model Model { get; set; }
}

public class AddedToken
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("single_word")]
    public bool SingleWord { get; set; }

    [JsonPropertyName("lstrip")]
    public bool Lstrip { get; set; }

    [JsonPropertyName("rstrip")]
    public bool Rstrip { get; set; }

    [JsonPropertyName("normalized")]
    public bool Normalized { get; set; }

    [JsonPropertyName("special")]
    public bool Special { get; set; }
}

public class Decoder
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("add_prefix_space")]
    public bool AddPrefixSpace { get; set; }

    [JsonPropertyName("trim_offsets")]
    public bool TrimOffsets { get; set; }

    [JsonPropertyName("use_regex")]
    public bool UseRegex { get; set; }
}

public class SpecialTokens
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("ids")]
    public List<int> Ids { get; set; } = [];

    [JsonPropertyName("tokens")]
    public List<string> Tokens { get; set; } = [];
}

public class Model
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("dropout")]
    public object Dropout { get; set; }

    [JsonPropertyName("unk_token")]
    public object UnkToken { get; set; }

    [JsonPropertyName("continuing_subword_prefix")]
    public string ContinuingSubwordPrefix { get; set; }

    [JsonPropertyName("end_of_word_suffix")]
    public string EndOfWordSuffix { get; set; }

    [JsonPropertyName("fuse_unk")]
    public bool FuseUnk { get; set; }

    [JsonPropertyName("byte_fallback")]
    public bool ByteFallback { get; set; }

    [JsonPropertyName("vocab")]
    public Dictionary<string, int> Vocab { get; set; }

    [JsonPropertyName("merges")]
    public List<string> Merges { get; set; } = [];
}

public class PostProcessor
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("single")]

    public List<Dictionary<string, SpecialToken>> Single { get; set; } = [];

    [JsonPropertyName("pair")]
    public List<Dictionary<string, SpecialToken>> Pairs { get; set; } = [];

    [JsonPropertyName("special_tokens")]
    public Dictionary<string, SpecialTokens> SpecialTokens { get; set; } = [];
}

public class PreTokenizer
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("add_prefix_space")]
    public bool AddPrefixSpace { get; set; }

    [JsonPropertyName("trim_offsets")]
    public bool TrimOffsets { get; set; }

    [JsonPropertyName("use_regex")]
    public bool UseRegex { get; set; }
}

public class SpecialToken
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type_id")]
    public int TypeId { get; set; }
}