// Generated by `wit-bindgen` 0.28.0. DO NOT EDIT!
// <auto-generated />
#nullable enable

using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0;

public interface ILlm {

    /**
    * Inference request parameters
    */

    public class InferencingParams {
        public readonly uint maxTokens;
        public readonly float repeatPenalty;
        public readonly uint repeatPenaltyLastNTokenCount;
        public readonly float temperature;
        public readonly uint topK;
        public readonly float topP;

        public InferencingParams(uint maxTokens, float repeatPenalty, uint repeatPenaltyLastNTokenCount, float temperature, uint topK, float topP) {
            this.maxTokens = maxTokens;
            this.repeatPenalty = repeatPenalty;
            this.repeatPenaltyLastNTokenCount = repeatPenaltyLastNTokenCount;
            this.temperature = temperature;
            this.topK = topK;
            this.topP = topP;
        }
    }

    /**
    * The set of errors which may be raised by functions in this interface
    */

    public class Error {
        public readonly byte Tag;
        private readonly object? value;

        private Error(byte tag, object? value) {
            this.Tag = tag;
            this.value = value;
        }

        public static Error modelNotSupported() {
            return new Error(MODEL_NOT_SUPPORTED, null);
        }

        public static Error runtimeError(string runtimeError) {
            return new Error(RUNTIME_ERROR, runtimeError);
        }

        public static Error invalidInput(string invalidInput) {
            return new Error(INVALID_INPUT, invalidInput);
        }

        public string AsRuntimeError
        {
            get
            {
                if (Tag == RUNTIME_ERROR)
                return (string)value!;
                else
                throw new ArgumentException("expected RUNTIME_ERROR, got " + Tag);
            }
        }

        public string AsInvalidInput
        {
            get
            {
                if (Tag == INVALID_INPUT)
                return (string)value!;
                else
                throw new ArgumentException("expected INVALID_INPUT, got " + Tag);
            }
        }

        public const byte MODEL_NOT_SUPPORTED = 0;
        public const byte RUNTIME_ERROR = 1;
        public const byte INVALID_INPUT = 2;
    }

    /**
    * Usage information related to the inferencing result
    */

    public class InferencingUsage {
        public readonly uint promptTokenCount;
        public readonly uint generatedTokenCount;

        public InferencingUsage(uint promptTokenCount, uint generatedTokenCount) {
            this.promptTokenCount = promptTokenCount;
            this.generatedTokenCount = generatedTokenCount;
        }
    }

    /**
    * An inferencing result
    */

    public class InferencingResult {
        public readonly string text;
        public readonly InferencingUsage usage;

        public InferencingResult(string text, InferencingUsage usage) {
            this.text = text;
            this.usage = usage;
        }
    }

    /**
    * Usage related to an embeddings generation request
    */

    public class EmbeddingsUsage {
        public readonly uint promptTokenCount;

        public EmbeddingsUsage(uint promptTokenCount) {
            this.promptTokenCount = promptTokenCount;
        }
    }

    /**
    * Result of generating embeddings
    */

    public class EmbeddingsResult {
        public readonly List<float[]> embeddings;
        public readonly EmbeddingsUsage usage;

        public EmbeddingsResult(List<float[]> embeddings, EmbeddingsUsage usage) {
            this.embeddings = embeddings;
            this.usage = usage;
        }
    }

}