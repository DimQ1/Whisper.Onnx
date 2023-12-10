using Whisper.Onnx.ModelConfiguration;

namespace Whisper.Onnx.Tests.ModelConfiguration
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class ConfigTests
    {
        [Test]
        public void ConfigTest()
        {
            var modelPath = "ModelConfiguration/Asserts/";

            var config = new Config(modelPath);

            Assert.IsNotNull(config.ModelConfig);
            Assert.IsNotNull(config.ModelTokenizer);
            Assert.IsNotNull(config.ModelTokenizerConfig);
        }

    }
}
