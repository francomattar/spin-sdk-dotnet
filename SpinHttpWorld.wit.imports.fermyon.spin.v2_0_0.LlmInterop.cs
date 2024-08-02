// Generated by `wit-bindgen` 0.29.0. DO NOT EDIT!
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

namespace SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0
{
    public static class LlmInterop {

        internal static class InferWasmInterop
        {
            [DllImport("fermyon:spin/llm@2.0.0", EntryPoint = "infer"), WasmImportLinkage]
            internal static extern void wasmImportInfer(nint p0, int p1, nint p2, int p3, int p4, int p5, float p6, int p7, float p8, int p9, float p10, nint p11);

        }

        internal  static unsafe global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.InferencingResult Infer(string model, string prompt, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.InferencingParams? @params)
        {

            var result = model;
            IntPtr interopString = InteropString.FromString(result, out int lengthresult);

            var result1 = prompt;
            IntPtr interopString0 = InteropString.FromString(result1, out int lengthresult1);

            int lowered;
            int lowered5;
            float lowered6;
            int lowered7;
            float lowered8;
            int lowered9;
            float lowered10;

            if (@params != null) {
                var payload4 = (global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.InferencingParams) @params;

                lowered = 1;
                lowered5 = unchecked((int)(payload4.maxTokens));
                lowered6 = payload4.repeatPenalty;
                lowered7 = unchecked((int)(payload4.repeatPenaltyLastNTokenCount));
                lowered8 = payload4.temperature;
                lowered9 = unchecked((int)(payload4.topK));
                lowered10 = payload4.topP;

            } else {

                lowered = 0;
                lowered5 = 0;
                lowered6 = 0.0F;
                lowered7 = 0;
                lowered8 = 0.0F;
                lowered9 = 0;
                lowered10 = 0.0F;

            }

            var retArea = new uint[5];
            fixed (uint* retAreaByte0 = &retArea[0])
            {
                var ptr = (nint)retAreaByte0;
                InferWasmInterop.wasmImportInfer(interopString.ToInt32(), lengthresult, interopString0.ToInt32(), lengthresult1, lowered, lowered5, lowered6, lowered7, lowered8, lowered9, lowered10, ptr);

                Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.InferencingResult, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error> lifted21;

                switch (new Span<byte>((void*)(ptr + 0), 1)[0]) {
                    case 0: {

                        lifted21 = Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.InferencingResult, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error>.ok(new global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.InferencingResult (
                        Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 4), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4))), new global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.InferencingUsage (
                        unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4)))), unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 16), 4)))))));
                        break;
                    }
                    case 1: {

                        global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error lifted;

                        switch (new Span<byte>((void*)(ptr + 4), 1)[0]) {
                            case 0: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error.modelNotSupported();
                                break;
                            }
                            case 1: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error.runtimeError(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 2: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error.invalidInput(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }

                            default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 4), 1)[0]}");
                        }

                        lifted21 = Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.InferencingResult, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error>.err(lifted);
                        break;
                    }

                    default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 0), 1)[0]}");
                }
                if (lifted21.IsOk) {
                    var tmp = lifted21.AsOk;
                    return tmp;
                } else {
                    throw new WitException(lifted21.AsErr!, 0);
                }
            }

            //TODO: free alloc handle (interopString) if exists
        }

        internal static class GenerateEmbeddingsWasmInterop
        {
            [DllImport("fermyon:spin/llm@2.0.0", EntryPoint = "generate-embeddings"), WasmImportLinkage]
            internal static extern void wasmImportGenerateEmbeddings(nint p0, int p1, nint p2, int p3, nint p4);

        }

        internal  static unsafe global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.EmbeddingsResult GenerateEmbeddings(string model, List<string> text)
        {

            var result = model;
            IntPtr interopString = InteropString.FromString(result, out int lengthresult);

            byte[] buffer = new byte[8 * text.Count];
            var gcHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            var address = gcHandle.AddrOfPinnedObject();

            for (int index = 0; index < text.Count; ++index) {
                string element = text[index];
                int basePtr = (int)address + (index * 8);

                var result1 = element;
                IntPtr interopString0 = InteropString.FromString(result1, out int lengthresult1);
                BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 4), 4), unchecked((int)lengthresult1));
                BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 0), 4), unchecked((int)interopString0.ToInt32()));

            }

            var retArea = new uint[4];
            fixed (uint* retAreaByte0 = &retArea[0])
            {
                var ptr = (nint)retAreaByte0;
                GenerateEmbeddingsWasmInterop.wasmImportGenerateEmbeddings(interopString.ToInt32(), lengthresult, (int)address, text.Count, ptr);

                Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.EmbeddingsResult, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error> lifted16;

                switch (new Span<byte>((void*)(ptr + 0), 1)[0]) {
                    case 0: {

                        var array6 = new List<float[]>(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)));
                        for (int index7 = 0; index7 < BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)); ++index7) {
                            nint basePtr5 = BitConverter.ToInt32(new Span<byte>((void*)(ptr + 4), 4)) + (index7 * 8);

                            var array = new float[BitConverter.ToInt32(new Span<byte>((void*)(basePtr5 + 4), 4))];
                            new Span<float>((void*)(BitConverter.ToInt32(new Span<byte>((void*)(basePtr5 + 0), 4))), BitConverter.ToInt32(new Span<byte>((void*)(basePtr5 + 4), 4))).CopyTo(new Span<float>(array));

                            array6.Add(array);
                        }

                        lifted16 = Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.EmbeddingsResult, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error>.ok(new global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.EmbeddingsResult (
                        array6, new global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.EmbeddingsUsage (
                        unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4)))))));
                        break;
                    }
                    case 1: {

                        global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error lifted;

                        switch (new Span<byte>((void*)(ptr + 4), 1)[0]) {
                            case 0: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error.modelNotSupported();
                                break;
                            }
                            case 1: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error.runtimeError(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 2: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error.invalidInput(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }

                            default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 4), 1)[0]}");
                        }

                        lifted16 = Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.EmbeddingsResult, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.ILlm.Error>.err(lifted);
                        break;
                    }

                    default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 0), 1)[0]}");
                }
                gcHandle.Free();
                if (lifted16.IsOk) {
                    var tmp = lifted16.AsOk;
                    return tmp;
                } else {
                    throw new WitException(lifted16.AsErr!, 0);
                }
            }

            //TODO: free alloc handle (interopString) if exists
        }

    }
}
