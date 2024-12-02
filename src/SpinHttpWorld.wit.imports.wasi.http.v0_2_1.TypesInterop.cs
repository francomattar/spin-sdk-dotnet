// Generated by `wit-bindgen` 0.30.0. DO NOT EDIT!
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

namespace SpinHttpWorld.wit.imports.wasi.http.v0_2_1
{
    public static class TypesInterop {

        internal static class HttpErrorCodeWasmInterop
        {
            [DllImport("wasi:http/types@0.2.1", EntryPoint = "http-error-code"), WasmImportLinkage]
            internal static extern void wasmImportHttpErrorCode(int p0, nint p1);

        }

        public  static unsafe global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode? HttpErrorCode(global::SpinHttpWorld.wit.imports.wasi.io.v0_2_1.IError.Error err)
        {
            var handle = err.Handle;

            var retArea = new ulong[5];
            fixed (ulong* retAreaByte0 = &retArea[0])
            {
                var ptr = (nint)retAreaByte0;
                HttpErrorCodeWasmInterop.wasmImportHttpErrorCode(handle, ptr);

                global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode? lifted190;

                switch (new Span<byte>((void*)(ptr + 0), 1)[0]) {
                    case 0: {
                        lifted190 = null;
                        break;
                    }

                    case 1: {

                        global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode lifted189;

                        switch (new Span<byte>((void*)(ptr + 8), 1)[0]) {
                            case 0: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.dnsTimeout();
                                break;
                            }
                            case 1: {

                                string? lifted;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted = Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 24), 4)));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                ushort? lifted14;

                                switch (new Span<byte>((void*)(ptr + 28), 1)[0]) {
                                    case 0: {
                                        lifted14 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted14 = ((ushort)BitConverter.ToUInt16(new Span<byte>((void*)(ptr + 30), 2)));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 28), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.dnsError(new global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.DnsErrorPayload (
                                lifted, lifted14));
                                break;
                            }
                            case 2: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.destinationNotFound();
                                break;
                            }
                            case 3: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.destinationUnavailable();
                                break;
                            }
                            case 4: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.destinationIpProhibited();
                                break;
                            }
                            case 5: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.destinationIpUnroutable();
                                break;
                            }
                            case 6: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.connectionRefused();
                                break;
                            }
                            case 7: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.connectionTerminated();
                                break;
                            }
                            case 8: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.connectionTimeout();
                                break;
                            }
                            case 9: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.connectionReadTimeout();
                                break;
                            }
                            case 10: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.connectionWriteTimeout();
                                break;
                            }
                            case 11: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.connectionLimitReached();
                                break;
                            }
                            case 12: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.tlsProtocolError();
                                break;
                            }
                            case 13: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.tlsCertificateError();
                                break;
                            }
                            case 14: {

                                byte? lifted45;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted45 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted45 = ((byte)new Span<byte>((void*)(ptr + 17), 1)[0]);
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                string? lifted50;

                                switch (new Span<byte>((void*)(ptr + 20), 1)[0]) {
                                    case 0: {
                                        lifted50 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted50 = Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 24), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 28), 4)));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 20), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.tlsAlertReceived(new global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.TlsAlertReceivedPayload (
                                lifted45, lifted50));
                                break;
                            }
                            case 15: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpRequestDenied();
                                break;
                            }
                            case 16: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpRequestLengthRequired();
                                break;
                            }
                            case 17: {

                                ulong? lifted61;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted61 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted61 = unchecked((ulong)(BitConverter.ToInt64(new Span<byte>((void*)(ptr + 24), 8))));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpRequestBodySize(lifted61);
                                break;
                            }
                            case 18: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpRequestMethodInvalid();
                                break;
                            }
                            case 19: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpRequestUriInvalid();
                                break;
                            }
                            case 20: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpRequestUriTooLong();
                                break;
                            }
                            case 21: {

                                uint? lifted74;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted74 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted74 = unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4))));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpRequestHeaderSectionSize(lifted74);
                                break;
                            }
                            case 22: {

                                global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.FieldSizePayload? lifted91;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted91 = null;
                                        break;
                                    }

                                    case 1: {

                                        string? lifted85;

                                        switch (new Span<byte>((void*)(ptr + 20), 1)[0]) {
                                            case 0: {
                                                lifted85 = null;
                                                break;
                                            }

                                            case 1: {

                                                lifted85 = Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 24), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 28), 4)));
                                                break;
                                            }

                                            default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 20), 1)[0]));
                                        }

                                        uint? lifted90;

                                        switch (new Span<byte>((void*)(ptr + 32), 1)[0]) {
                                            case 0: {
                                                lifted90 = null;
                                                break;
                                            }

                                            case 1: {

                                                lifted90 = unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 36), 4))));
                                                break;
                                            }

                                            default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 32), 1)[0]));
                                        }

                                        lifted91 = new global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.FieldSizePayload (
                                        lifted85, lifted90);
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpRequestHeaderSize(lifted91);
                                break;
                            }
                            case 23: {

                                uint? lifted98;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted98 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted98 = unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4))));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpRequestTrailerSectionSize(lifted98);
                                break;
                            }
                            case 24: {

                                string? lifted105;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted105 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted105 = Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 24), 4)));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                uint? lifted110;

                                switch (new Span<byte>((void*)(ptr + 28), 1)[0]) {
                                    case 0: {
                                        lifted110 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted110 = unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 32), 4))));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 28), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpRequestTrailerSize(new global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.FieldSizePayload (
                                lifted105, lifted110));
                                break;
                            }
                            case 25: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpResponseIncomplete();
                                break;
                            }
                            case 26: {

                                uint? lifted119;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted119 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted119 = unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4))));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpResponseHeaderSectionSize(lifted119);
                                break;
                            }
                            case 27: {

                                string? lifted126;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted126 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted126 = Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 24), 4)));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                uint? lifted131;

                                switch (new Span<byte>((void*)(ptr + 28), 1)[0]) {
                                    case 0: {
                                        lifted131 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted131 = unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 32), 4))));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 28), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpResponseHeaderSize(new global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.FieldSizePayload (
                                lifted126, lifted131));
                                break;
                            }
                            case 28: {

                                ulong? lifted138;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted138 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted138 = unchecked((ulong)(BitConverter.ToInt64(new Span<byte>((void*)(ptr + 24), 8))));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpResponseBodySize(lifted138);
                                break;
                            }
                            case 29: {

                                uint? lifted145;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted145 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted145 = unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4))));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpResponseTrailerSectionSize(lifted145);
                                break;
                            }
                            case 30: {

                                string? lifted152;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted152 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted152 = Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 24), 4)));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                uint? lifted157;

                                switch (new Span<byte>((void*)(ptr + 28), 1)[0]) {
                                    case 0: {
                                        lifted157 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted157 = unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 32), 4))));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 28), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpResponseTrailerSize(new global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.FieldSizePayload (
                                lifted152, lifted157));
                                break;
                            }
                            case 31: {

                                string? lifted164;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted164 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted164 = Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 24), 4)));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpResponseTransferCoding(lifted164);
                                break;
                            }
                            case 32: {

                                string? lifted171;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted171 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted171 = Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 24), 4)));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpResponseContentCoding(lifted171);
                                break;
                            }
                            case 33: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpResponseTimeout();
                                break;
                            }
                            case 34: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpUpgradeFailed();
                                break;
                            }
                            case 35: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.httpProtocolError();
                                break;
                            }
                            case 36: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.loopDetected();
                                break;
                            }
                            case 37: {

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.configurationError();
                                break;
                            }
                            case 38: {

                                string? lifted188;

                                switch (new Span<byte>((void*)(ptr + 16), 1)[0]) {
                                    case 0: {
                                        lifted188 = null;
                                        break;
                                    }

                                    case 1: {

                                        lifted188 = Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 20), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 24), 4)));
                                        break;
                                    }

                                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 16), 1)[0]));
                                }

                                lifted189 = global::SpinHttpWorld.wit.imports.wasi.http.v0_2_1.ITypes.ErrorCode.internalError(lifted188);
                                break;
                            }

                            default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 8), 1)[0]}");
                        }

                        lifted190 = lifted189;
                        break;
                    }

                    default: throw new ArgumentException("invalid discriminant: " + (new Span<byte>((void*)(ptr + 0), 1)[0]));
                }
                return lifted190;
            }

            //TODO: free alloc handle (interopString) if exists
        }

    }
}