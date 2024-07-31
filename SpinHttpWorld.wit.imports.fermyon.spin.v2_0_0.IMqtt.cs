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

public interface IMqtt {

    /**
    * Errors related to interacting with Mqtt
    */

    public class Error {
        public readonly byte Tag;
        private readonly object? value;

        private Error(byte tag, object? value) {
            this.Tag = tag;
            this.value = value;
        }

        public static Error invalidAddress() {
            return new Error(INVALID_ADDRESS, null);
        }

        public static Error tooManyConnections() {
            return new Error(TOO_MANY_CONNECTIONS, null);
        }

        public static Error connectionFailed(string connectionFailed) {
            return new Error(CONNECTION_FAILED, connectionFailed);
        }

        public static Error other(string other) {
            return new Error(OTHER, other);
        }

        public string AsConnectionFailed
        {
            get
            {
                if (Tag == CONNECTION_FAILED)
                return (string)value!;
                else
                throw new ArgumentException("expected CONNECTION_FAILED, got " + Tag);
            }
        }

        public string AsOther
        {
            get
            {
                if (Tag == OTHER)
                return (string)value!;
                else
                throw new ArgumentException("expected OTHER, got " + Tag);
            }
        }

        public const byte INVALID_ADDRESS = 0;
        public const byte TOO_MANY_CONNECTIONS = 1;
        public const byte CONNECTION_FAILED = 2;
        public const byte OTHER = 3;
    }

    /**
    * QoS for publishing Mqtt messages
    */

    public enum Qos {
        AT_MOST_ONCE, AT_LEAST_ONCE, EXACTLY_ONCE
    }

    public class Connection: IDisposable {
        internal int Handle { get; set; }

        internal readonly record struct THandle(int Handle);

        internal Connection(THandle handle) {
            Handle = handle.Handle;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        [DllImport("fermyon:spin/mqtt@2.0.0", EntryPoint = "[resource-drop]connection"), WasmImportLinkage]
        private static extern void wasmImportResourceDrop(int p0);

        protected virtual void Dispose(bool disposing) {
            if (Handle != 0) {
                wasmImportResourceDrop(Handle);
                Handle = 0;
            }
        }

        ~Connection() {
            Dispose(false);
        }

        internal static class OpenWasmInterop
        {
            [DllImport("fermyon:spin/mqtt@2.0.0", EntryPoint = "[static]connection.open"), WasmImportLinkage]
            internal static extern void wasmImportOpen(nint p0, int p1, nint p2, int p3, nint p4, int p5, long p6, nint p7);

        }

        internal  static unsafe global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Connection Open(string address, string username, string password, ulong keepAliveIntervalInSecs)
        {

            var result = address;
            IntPtr interopString = InteropString.FromString(result, out int lengthresult);

            var result1 = username;
            IntPtr interopString0 = InteropString.FromString(result1, out int lengthresult1);

            var result3 = password;
            IntPtr interopString2 = InteropString.FromString(result3, out int lengthresult3);

            var retArea = new uint[4];
            fixed (uint* retAreaByte0 = &retArea[0])
            {
                var ptr = (nint)retAreaByte0;
                OpenWasmInterop.wasmImportOpen(interopString.ToInt32(), lengthresult, interopString0.ToInt32(), lengthresult1, interopString2.ToInt32(), lengthresult3, unchecked((long)(keepAliveIntervalInSecs)), ptr);

                Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Connection, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error> lifted14;

                switch (new Span<byte>((void*)(ptr + 0), 1)[0]) {
                    case 0: {
                        var resource = new global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Connection(new global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Connection.THandle(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 4), 4))));

                        lifted14 = Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Connection, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error>.ok(resource);
                        break;
                    }
                    case 1: {

                        global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error lifted;

                        switch (new Span<byte>((void*)(ptr + 4), 1)[0]) {
                            case 0: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error.invalidAddress();
                                break;
                            }
                            case 1: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error.tooManyConnections();
                                break;
                            }
                            case 2: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error.connectionFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 3: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error.other(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }

                            default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 4), 1)[0]}");
                        }

                        lifted14 = Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Connection, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error>.err(lifted);
                        break;
                    }

                    default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 0), 1)[0]}");
                }
                if (lifted14.IsOk) {
                    var tmp = lifted14.AsOk;
                    return tmp;
                } else {
                    throw new WitException(lifted14.AsErr!, 0);
                }
            }

            //TODO: free alloc handle (interopString) if exists
        }

        internal static class PublishWasmInterop
        {
            [DllImport("fermyon:spin/mqtt@2.0.0", EntryPoint = "[method]connection.publish"), WasmImportLinkage]
            internal static extern void wasmImportPublish(int p0, nint p1, int p2, nint p3, int p4, int p5, nint p6);

        }

        internal   unsafe void Publish(string topic, byte[] payload, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Qos qos)
        {
            var handle = this.Handle;

            var result = topic;
            IntPtr interopString = InteropString.FromString(result, out int lengthresult);

            void* buffer = stackalloc byte[(payload).Length];
            payload.AsSpan<byte>().CopyTo(new Span<byte>(buffer, payload.Length));

            var retArea = new uint[4];
            fixed (uint* retAreaByte0 = &retArea[0])
            {
                var ptr = (nint)retAreaByte0;
                PublishWasmInterop.wasmImportPublish(handle, interopString.ToInt32(), lengthresult, (int)buffer, (payload).Length, (int)qos, ptr);

                Result<None, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error> lifted10;

                switch (new Span<byte>((void*)(ptr + 0), 1)[0]) {
                    case 0: {

                        lifted10 = Result<None, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error>.ok(new global::SpinHttpWorld.None());
                        break;
                    }
                    case 1: {

                        global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error lifted;

                        switch (new Span<byte>((void*)(ptr + 4), 1)[0]) {
                            case 0: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error.invalidAddress();
                                break;
                            }
                            case 1: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error.tooManyConnections();
                                break;
                            }
                            case 2: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error.connectionFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 3: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error.other(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }

                            default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 4), 1)[0]}");
                        }

                        lifted10 = Result<None, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IMqtt.Error>.err(lifted);
                        break;
                    }

                    default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 0), 1)[0]}");
                }
                if (lifted10.IsOk) {
                    var tmp = lifted10.AsOk;
                    return ;
                } else {
                    throw new WitException(lifted10.AsErr!, 0);
                }
            }

            //TODO: free alloc handle (interopString) if exists
        }

    }

}
