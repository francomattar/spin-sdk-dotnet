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

namespace SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0
{
    public static class VariablesInterop {

        internal static class GetWasmInterop
        {
            [DllImport("fermyon:spin/variables@2.0.0", EntryPoint = "get"), WasmImportLinkage]
            internal static extern void wasmImportGet(nint p0, int p1, nint p2);

        }

        internal  static unsafe string Get(string name)
        {

            var result = name;
            IntPtr interopString = InteropString.FromString(result, out int lengthresult);

            var retArea = new uint[4];
            fixed (uint* retAreaByte0 = &retArea[0])
            {
                var ptr = (nint)retAreaByte0;
                GetWasmInterop.wasmImportGet(interopString.ToInt32(), lengthresult, ptr);

                Result<string, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IVariables.Error> lifted10;

                switch (new Span<byte>((void*)(ptr + 0), 1)[0]) {
                    case 0: {

                        lifted10 = Result<string, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IVariables.Error>.ok(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 4), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4))));
                        break;
                    }
                    case 1: {

                        global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IVariables.Error lifted;

                        switch (new Span<byte>((void*)(ptr + 4), 1)[0]) {
                            case 0: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IVariables.Error.invalidName(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 1: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IVariables.Error.undefined(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 2: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IVariables.Error.provider(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 3: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IVariables.Error.other(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }

                            default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 4), 1)[0]}");
                        }

                        lifted10 = Result<string, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IVariables.Error>.err(lifted);
                        break;
                    }

                    default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 0), 1)[0]}");
                }
                if (lifted10.IsOk) {
                    var tmp = lifted10.AsOk;
                    return tmp;
                } else {
                    throw new WitException(lifted10.AsErr!, 0);
                }
            }

            //TODO: free alloc handle (interopString) if exists
        }

    }
}
