using System.Text.Json.Serialization;

namespace Whisper.Onnx.ModelConfiguration.Models
{
    public class ModelTokenizerConfig
    {
        [JsonPropertyName("add_bos_token")]
        public bool AddBosToken { get; set; }

        [JsonPropertyName("add_prefix_space")]
        public bool AddPrefixSpace { get; set; }

        [JsonPropertyName("bos_token")]
        public Token BosToken { get; set; }

        [JsonPropertyName("clean_up_tokenization_spaces")]
        public bool CleanUpTokenizationSpaces { get; set; }

        [JsonPropertyName("eos_token")]
        public Token EosToken { get; set; }

        [JsonPropertyName("errors")]
        public string Errors { get; set; }

        [JsonPropertyName("model_max_length")]
        public int ModelMaxLength { get; set; }

        [JsonPropertyName("pad_token")]
        public object PadToken { get; set; }

        [JsonPropertyName("processor_class")]
        public string ProcessorClass { get; set; }

        [JsonPropertyName("return_attention_mask")]
        public bool ReturnAttentionMask { get; set; }

        [JsonPropertyName("tokenizer_class")]
        public string TokenizerClass { get; set; }

        [JsonPropertyName("trust_remote_code")]
        public bool TrustRemoteCode { get; set; }

        [JsonPropertyName("unk_token")]
        public Token UnkToken { get; set; }
    }

    public class Token
    {
        [JsonPropertyName("__type")]
        public string Type { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("lstrip")]
        public bool Lstrip { get; set; }

        [JsonPropertyName("normalized")]
        public bool Normalized { get; set; }

        [JsonPropertyName("rstrip")]
        public bool Rstrip { get; set; }

        [JsonPropertyName("single_word")]
        public bool SingleWord { get; set; }
    }
}
