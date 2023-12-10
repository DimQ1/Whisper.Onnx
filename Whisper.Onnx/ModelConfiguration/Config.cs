using System.Text.Json;
using Whisper.Onnx.ModelConfiguration.Models;

namespace Whisper.Onnx.ModelConfiguration
{
    public class Config
    {
        private ModelConfig _config;
        private ModelTokenizer _modelTokenizer;
        private ModelTokenizerConfig _modelTokenizerConfig;

        public ModelConfig ModelConfig => _config;
        public ModelTokenizer ModelTokenizer => _modelTokenizer;

        public ModelTokenizerConfig ModelTokenizerConfig => _modelTokenizerConfig;

        public Config(string modelPath)
        {
            var configString = File.ReadAllText(Path.Combine(modelPath, "config.json"));
            this._config = JsonSerializer.Deserialize<ModelConfig>(configString) ?? throw new NullReferenceException("config.json");

            var tokenizerString = File.ReadAllText(Path.Combine(modelPath, "tokenizer.json"));
            this._modelTokenizer = JsonSerializer.Deserialize<ModelTokenizer>(tokenizerString) ?? throw new NullReferenceException("tokenizer.json");

            var tokenizerConfigString = File.ReadAllText(Path.Combine(modelPath, "tokenizer_config.json"));
            this._modelTokenizerConfig = JsonSerializer.Deserialize<ModelTokenizerConfig>(tokenizerConfigString) ?? throw new NullReferenceException("tokenizer_config.json");
        }
    }
}
