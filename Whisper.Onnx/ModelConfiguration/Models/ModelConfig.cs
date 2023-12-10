﻿using System.Text.Json.Serialization;

namespace Whisper.Onnx.ModelConfiguration.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public record ModelConfig(
        [property: JsonPropertyName("_name_or_path")] string NameOrPath,
        [property: JsonPropertyName("activation_dropout")] double ActivationDropout,
        [property: JsonPropertyName("activation_function")] string ActivationFunction,
        [property: JsonPropertyName("apply_spec_augment")] bool ApplySpecAugment,
        [property: JsonPropertyName("architectures")] IReadOnlyList<string> Architectures,
        [property: JsonPropertyName("attention_dropout")] double AttentionDropout,
        [property: JsonPropertyName("begin_suppress_tokens")] IReadOnlyList<int> BeginSuppressTokens,
        [property: JsonPropertyName("bos_token_id")] int BosTokenId,
        [property: JsonPropertyName("classifier_proj_size")] int ClassifierProjSize,
        [property: JsonPropertyName("d_model")] int DModel,
        [property: JsonPropertyName("decoder_attention_heads")] int DecoderAttentionHeads,
        [property: JsonPropertyName("decoder_ffn_dim")] int DecoderFfnDim,
        [property: JsonPropertyName("decoder_layerdrop")] double DecoderLayerdrop,
        [property: JsonPropertyName("decoder_layers")] int DecoderLayers,
        [property: JsonPropertyName("decoder_start_token_id")] int DecoderStartTokenId,
        [property: JsonPropertyName("dropout")] double Dropout,
        [property: JsonPropertyName("encoder_attention_heads")] int EncoderAttentionHeads,
        [property: JsonPropertyName("encoder_ffn_dim")] int EncoderFfnDim,
        [property: JsonPropertyName("encoder_layerdrop")] double EncoderLayerdrop,
        [property: JsonPropertyName("encoder_layers")] int EncoderLayers,
        [property: JsonPropertyName("eos_token_id")] int EosTokenId,
        [property: JsonPropertyName("forced_decoder_ids")] IReadOnlyList<List<int>> ForcedDecoderIds,
        [property: JsonPropertyName("init_std")] double InitStd,
        [property: JsonPropertyName("is_encoder_decoder")] bool IsEncoderDecoder,
        [property: JsonPropertyName("mask_feature_length")] int MaskFeatureLength,
        [property: JsonPropertyName("mask_feature_min_masks")] int MaskFeatureMinMasks,
        [property: JsonPropertyName("mask_feature_prob")] double MaskFeatureProb,
        [property: JsonPropertyName("mask_time_length")] int MaskTimeLength,
        [property: JsonPropertyName("mask_time_min_masks")] int MaskTimeMinMasks,
        [property: JsonPropertyName("mask_time_prob")] double MaskTimeProb,
        [property: JsonPropertyName("max_length")] int MaxLength,
        [property: JsonPropertyName("max_source_positions")] int MaxSourcePositions,
        [property: JsonPropertyName("max_target_positions")] int MaxTargetPositions,
        [property: JsonPropertyName("median_filter_width")] int MedianFilterWidth,
        [property: JsonPropertyName("model_type")] string ModelType,
        [property: JsonPropertyName("num_hidden_layers")] int NumHiddenLayers,
        [property: JsonPropertyName("num_mel_bins")] int NumMelBins,
        [property: JsonPropertyName("pad_token_id")] int PadTokenId,
        [property: JsonPropertyName("scale_embedding")] bool ScaleEmbedding,
        [property: JsonPropertyName("suppress_tokens")] IReadOnlyList<int> SuppressTokens,
        [property: JsonPropertyName("transformers_version")] string TransformersVersion,
        [property: JsonPropertyName("use_cache")] bool UseCache,
        [property: JsonPropertyName("use_weighted_layer_sum")] bool UseWeightedLayerSum,
        [property: JsonPropertyName("vocab_size")] int VocabSize
    );
}