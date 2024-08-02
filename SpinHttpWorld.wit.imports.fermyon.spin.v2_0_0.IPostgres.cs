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

namespace SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0;

public interface IPostgres {

    /**
    * A connection to a postgres database.
    */

    public class Connection: IDisposable {
        internal int Handle { get; set; }

        public readonly record struct THandle(int Handle);

        public Connection(THandle handle) {
            Handle = handle.Handle;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        [DllImport("fermyon:spin/postgres@2.0.0", EntryPoint = "[resource-drop]connection"), WasmImportLinkage]
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
            [DllImport("fermyon:spin/postgres@2.0.0", EntryPoint = "[static]connection.open"), WasmImportLinkage]
            internal static extern void wasmImportOpen(nint p0, int p1, nint p2);

        }

        internal  static unsafe global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IPostgres.Connection Open(string address)
        {

            var result = address;
            IntPtr interopString = InteropString.FromString(result, out int lengthresult);

            var retArea = new uint[4];
            fixed (uint* retAreaByte0 = &retArea[0])
            {
                var ptr = (nint)retAreaByte0;
                OpenWasmInterop.wasmImportOpen(interopString.ToInt32(), lengthresult, ptr);

                Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IPostgres.Connection, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error> lifted12;

                switch (new Span<byte>((void*)(ptr + 0), 1)[0]) {
                    case 0: {
                        var resource = new global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IPostgres.Connection(new global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IPostgres.Connection.THandle(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 4), 4))));

                        lifted12 = Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IPostgres.Connection, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error>.ok(resource);
                        break;
                    }
                    case 1: {

                        global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error lifted;

                        switch (new Span<byte>((void*)(ptr + 4), 1)[0]) {
                            case 0: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.connectionFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 1: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.badParameter(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 2: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.queryFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 3: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.valueConversionFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 4: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.other(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }

                            default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 4), 1)[0]}");
                        }

                        lifted12 = Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IPostgres.Connection, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error>.err(lifted);
                        break;
                    }

                    default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 0), 1)[0]}");
                }
                if (lifted12.IsOk) {
                    var tmp = lifted12.AsOk;
                    return tmp;
                } else {
                    throw new WitException(lifted12.AsErr!, 0);
                }
            }

            //TODO: free alloc handle (interopString) if exists
        }

        internal static class QueryWasmInterop
        {
            [DllImport("fermyon:spin/postgres@2.0.0", EntryPoint = "[method]connection.query"), WasmImportLinkage]
            internal static extern void wasmImportQuery(int p0, nint p1, int p2, nint p3, int p4, nint p5);

        }

        internal   unsafe global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.RowSet Query(string statement, List<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.ParameterValue> @params)
        {
            var handle = this.Handle;

            var result = statement;
            IntPtr interopString = InteropString.FromString(result, out int lengthresult);

            byte[] buffer43 = new byte[16 * @params.Count];
            var gcHandle = GCHandle.Alloc(buffer43, GCHandleType.Pinned);
            var address = gcHandle.AddrOfPinnedObject();

            for (int index = 0; index < @params.Count; ++index) {
                global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.ParameterValue element = @params[index];
                int basePtr = (int)address + (index * 16);

                switch (element.Tag) {
                    case 0: {
                        bool payload = element.AsBoolean;
                        *(byte*)(basePtr + 0) = (byte)0;
                        *(byte*)(basePtr + 8) = (byte)(payload ? 1 : 0);

                        break;
                    }
                    case 1: {
                        sbyte payload4 = element.AsInt8;
                        *(byte*)(basePtr + 0) = (byte)1;
                        *(byte*)(basePtr + 8) = (byte)payload4;

                        break;
                    }
                    case 2: {
                        short payload7 = element.AsInt16;
                        *(byte*)(basePtr + 0) = (byte)2;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 2), (short)payload7);

                        break;
                    }
                    case 3: {
                        int payload10 = element.AsInt32;
                        *(byte*)(basePtr + 0) = (byte)3;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 4), unchecked((int)payload10));

                        break;
                    }
                    case 4: {
                        long payload13 = element.AsInt64;
                        *(byte*)(basePtr + 0) = (byte)4;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 8), unchecked((long)payload13));

                        break;
                    }
                    case 5: {
                        byte payload16 = element.AsUint8;
                        *(byte*)(basePtr + 0) = (byte)5;
                        *(byte*)(basePtr + 8) = (byte)payload16;

                        break;
                    }
                    case 6: {
                        ushort payload19 = element.AsUint16;
                        *(byte*)(basePtr + 0) = (byte)6;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 2), (short)payload19);

                        break;
                    }
                    case 7: {
                        uint payload22 = element.AsUint32;
                        *(byte*)(basePtr + 0) = (byte)7;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 4), unchecked((int)unchecked((int)(payload22))));

                        break;
                    }
                    case 8: {
                        ulong payload25 = element.AsUint64;
                        *(byte*)(basePtr + 0) = (byte)8;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 8), unchecked((long)unchecked((long)(payload25))));

                        break;
                    }
                    case 9: {
                        float payload28 = element.AsFloating32;
                        *(byte*)(basePtr + 0) = (byte)9;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 4), unchecked((float)payload28));

                        break;
                    }
                    case 10: {
                        double payload31 = element.AsFloating64;
                        *(byte*)(basePtr + 0) = (byte)10;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 8), unchecked((double)payload31));

                        break;
                    }
                    case 11: {
                        string payload34 = element.AsStr;
                        *(byte*)(basePtr + 0) = (byte)11;

                        var result36 = payload34;
                        IntPtr interopString35 = InteropString.FromString(result36, out int lengthresult36);
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 12), 4), unchecked((int)lengthresult36));
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 4), unchecked((int)interopString35.ToInt32()));

                        break;
                    }
                    case 12: {
                        byte[] payload39 = element.AsBinary;
                        *(byte*)(basePtr + 0) = (byte)12;

                        void* buffer = stackalloc byte[(payload39).Length];
                        payload39.AsSpan<byte>().CopyTo(new Span<byte>(buffer, payload39.Length));
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 12), 4), unchecked((int)(payload39).Length));
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 4), unchecked((int)(int)buffer));

                        break;
                    }
                    case 13: {

                        *(byte*)(basePtr + 0) = (byte)13;

                        break;
                    }

                    default: throw new ArgumentException($"invalid discriminant: {element}");
                }

            }

            var retArea = new uint[5];
            fixed (uint* retAreaByte0 = &retArea[0])
            {
                var ptr = (nint)retAreaByte0;
                QueryWasmInterop.wasmImportQuery(handle, interopString.ToInt32(), lengthresult, (int)address, @params.Count, ptr);

                Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.RowSet, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error> lifted101;

                switch (new Span<byte>((void*)(ptr + 0), 1)[0]) {
                    case 0: {

                        var array = new List<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Column>(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)));
                        for (int index48 = 0; index48 < BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)); ++index48) {
                            nint basePtr47 = BitConverter.ToInt32(new Span<byte>((void*)(ptr + 4), 4)) + (index48 * 12);

                            array.Add(new global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Column (
                            Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(basePtr47 + 0), 4)), BitConverter.ToInt32(new Span<byte>((void*)(basePtr47 + 4), 4))), (global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbDataType)new Span<byte>((void*)(basePtr47 + 8), 1)[0]));
                        }

                        var array86 = new List<List<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue>>(BitConverter.ToInt32(new Span<byte>((void*)(ptr + 16), 4)));
                        for (int index87 = 0; index87 < BitConverter.ToInt32(new Span<byte>((void*)(ptr + 16), 4)); ++index87) {
                            nint basePtr50 = BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4)) + (index87 * 8);

                            var array84 = new List<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue>(BitConverter.ToInt32(new Span<byte>((void*)(basePtr50 + 4), 4)));
                            for (int index85 = 0; index85 < BitConverter.ToInt32(new Span<byte>((void*)(basePtr50 + 4), 4)); ++index85) {
                                nint basePtr52 = BitConverter.ToInt32(new Span<byte>((void*)(basePtr50 + 0), 4)) + (index85 * 16);

                                global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue lifted;

                                switch (new Span<byte>((void*)(basePtr52 + 0), 1)[0]) {
                                    case 0: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.boolean((new Span<byte>((void*)(basePtr52 + 8), 1)[0] != 0));
                                        break;
                                    }
                                    case 1: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.int8(((sbyte)(sbyte)new Span<byte>((void*)(basePtr52 + 8), 1)[0]));
                                        break;
                                    }
                                    case 2: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.int16(((short)BitConverter.ToInt16(new Span<byte>((void*)(basePtr52 + 8), 2))));
                                        break;
                                    }
                                    case 3: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.int32(BitConverter.ToInt32(new Span<byte>((void*)(basePtr52 + 8), 4)));
                                        break;
                                    }
                                    case 4: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.int64(BitConverter.ToInt64(new Span<byte>((void*)(basePtr52 + 8), 8)));
                                        break;
                                    }
                                    case 5: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.uint8(((byte)new Span<byte>((void*)(basePtr52 + 8), 1)[0]));
                                        break;
                                    }
                                    case 6: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.uint16(((ushort)BitConverter.ToUInt16(new Span<byte>((void*)(basePtr52 + 8), 2))));
                                        break;
                                    }
                                    case 7: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.uint32(unchecked((uint)(BitConverter.ToInt32(new Span<byte>((void*)(basePtr52 + 8), 4)))));
                                        break;
                                    }
                                    case 8: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.uint64(unchecked((ulong)(BitConverter.ToInt64(new Span<byte>((void*)(basePtr52 + 8), 8)))));
                                        break;
                                    }
                                    case 9: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.floating32(BitConverter.ToSingle(new Span<byte>((void*)(basePtr52 + 8), 4)));
                                        break;
                                    }
                                    case 10: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.floating64(BitConverter.ToDouble(new Span<byte>((void*)(basePtr52 + 8), 8)));
                                        break;
                                    }
                                    case 11: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.str(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(basePtr52 + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(basePtr52 + 12), 4))));
                                        break;
                                    }
                                    case 12: {

                                        var array79 = new byte[BitConverter.ToInt32(new Span<byte>((void*)(basePtr52 + 12), 4))];
                                        new Span<byte>((void*)(BitConverter.ToInt32(new Span<byte>((void*)(basePtr52 + 8), 4))), BitConverter.ToInt32(new Span<byte>((void*)(basePtr52 + 12), 4))).CopyTo(new Span<byte>(array79));

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.binary(array79);
                                        break;
                                    }
                                    case 13: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.dbNull();
                                        break;
                                    }
                                    case 14: {

                                        lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.DbValue.unsupported();
                                        break;
                                    }

                                    default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(basePtr52 + 0), 1)[0]}");
                                }

                                array84.Add(lifted);
                            }

                            array86.Add(array84);
                        }

                        lifted101 = Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.RowSet, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error>.ok(new global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.RowSet (
                        array, array86));
                        break;
                    }
                    case 1: {

                        global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error lifted100;

                        switch (new Span<byte>((void*)(ptr + 4), 1)[0]) {
                            case 0: {

                                lifted100 = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.connectionFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 1: {

                                lifted100 = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.badParameter(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 2: {

                                lifted100 = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.queryFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 3: {

                                lifted100 = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.valueConversionFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }
                            case 4: {

                                lifted100 = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.other(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 8), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4))));
                                break;
                            }

                            default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 4), 1)[0]}");
                        }

                        lifted101 = Result<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.RowSet, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error>.err(lifted100);
                        break;
                    }

                    default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 0), 1)[0]}");
                }
                gcHandle.Free();
                if (lifted101.IsOk) {
                    var tmp = lifted101.AsOk;
                    return tmp;
                } else {
                    throw new WitException(lifted101.AsErr!, 0);
                }
            }

            //TODO: free alloc handle (interopString) if exists
        }

        internal static class ExecuteWasmInterop
        {
            [DllImport("fermyon:spin/postgres@2.0.0", EntryPoint = "[method]connection.execute"), WasmImportLinkage]
            internal static extern void wasmImportExecute(int p0, nint p1, int p2, nint p3, int p4, nint p5);

        }

        internal   unsafe ulong Execute(string statement, List<global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.ParameterValue> @params)
        {
            var handle = this.Handle;

            var result = statement;
            IntPtr interopString = InteropString.FromString(result, out int lengthresult);

            byte[] buffer43 = new byte[16 * @params.Count];
            var gcHandle = GCHandle.Alloc(buffer43, GCHandleType.Pinned);
            var address = gcHandle.AddrOfPinnedObject();

            for (int index = 0; index < @params.Count; ++index) {
                global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.ParameterValue element = @params[index];
                int basePtr = (int)address + (index * 16);

                switch (element.Tag) {
                    case 0: {
                        bool payload = element.AsBoolean;
                        *(byte*)(basePtr + 0) = (byte)0;
                        *(byte*)(basePtr + 8) = (byte)(payload ? 1 : 0);

                        break;
                    }
                    case 1: {
                        sbyte payload4 = element.AsInt8;
                        *(byte*)(basePtr + 0) = (byte)1;
                        *(byte*)(basePtr + 8) = (byte)payload4;

                        break;
                    }
                    case 2: {
                        short payload7 = element.AsInt16;
                        *(byte*)(basePtr + 0) = (byte)2;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 2), (short)payload7);

                        break;
                    }
                    case 3: {
                        int payload10 = element.AsInt32;
                        *(byte*)(basePtr + 0) = (byte)3;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 4), unchecked((int)payload10));

                        break;
                    }
                    case 4: {
                        long payload13 = element.AsInt64;
                        *(byte*)(basePtr + 0) = (byte)4;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 8), unchecked((long)payload13));

                        break;
                    }
                    case 5: {
                        byte payload16 = element.AsUint8;
                        *(byte*)(basePtr + 0) = (byte)5;
                        *(byte*)(basePtr + 8) = (byte)payload16;

                        break;
                    }
                    case 6: {
                        ushort payload19 = element.AsUint16;
                        *(byte*)(basePtr + 0) = (byte)6;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 2), (short)payload19);

                        break;
                    }
                    case 7: {
                        uint payload22 = element.AsUint32;
                        *(byte*)(basePtr + 0) = (byte)7;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 4), unchecked((int)unchecked((int)(payload22))));

                        break;
                    }
                    case 8: {
                        ulong payload25 = element.AsUint64;
                        *(byte*)(basePtr + 0) = (byte)8;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 8), unchecked((long)unchecked((long)(payload25))));

                        break;
                    }
                    case 9: {
                        float payload28 = element.AsFloating32;
                        *(byte*)(basePtr + 0) = (byte)9;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 4), unchecked((float)payload28));

                        break;
                    }
                    case 10: {
                        double payload31 = element.AsFloating64;
                        *(byte*)(basePtr + 0) = (byte)10;
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 8), unchecked((double)payload31));

                        break;
                    }
                    case 11: {
                        string payload34 = element.AsStr;
                        *(byte*)(basePtr + 0) = (byte)11;

                        var result36 = payload34;
                        IntPtr interopString35 = InteropString.FromString(result36, out int lengthresult36);
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 12), 4), unchecked((int)lengthresult36));
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 4), unchecked((int)interopString35.ToInt32()));

                        break;
                    }
                    case 12: {
                        byte[] payload39 = element.AsBinary;
                        *(byte*)(basePtr + 0) = (byte)12;

                        void* buffer = stackalloc byte[(payload39).Length];
                        payload39.AsSpan<byte>().CopyTo(new Span<byte>(buffer, payload39.Length));
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 12), 4), unchecked((int)(payload39).Length));
                        BitConverter.TryWriteBytes(new Span<byte>((void*)(basePtr + 8), 4), unchecked((int)(int)buffer));

                        break;
                    }
                    case 13: {

                        *(byte*)(basePtr + 0) = (byte)13;

                        break;
                    }

                    default: throw new ArgumentException($"invalid discriminant: {element}");
                }

            }

            var retArea = new ulong[3];
            fixed (ulong* retAreaByte0 = &retArea[0])
            {
                var ptr = (nint)retAreaByte0;
                ExecuteWasmInterop.wasmImportExecute(handle, interopString.ToInt32(), lengthresult, (int)address, @params.Count, ptr);

                Result<ulong, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error> lifted58;

                switch (new Span<byte>((void*)(ptr + 0), 1)[0]) {
                    case 0: {

                        lifted58 = Result<ulong, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error>.ok(unchecked((ulong)(BitConverter.ToInt64(new Span<byte>((void*)(ptr + 8), 8)))));
                        break;
                    }
                    case 1: {

                        global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error lifted;

                        switch (new Span<byte>((void*)(ptr + 8), 1)[0]) {
                            case 0: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.connectionFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 16), 4))));
                                break;
                            }
                            case 1: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.badParameter(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 16), 4))));
                                break;
                            }
                            case 2: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.queryFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 16), 4))));
                                break;
                            }
                            case 3: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.valueConversionFailed(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 16), 4))));
                                break;
                            }
                            case 4: {

                                lifted = global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error.other(Encoding.UTF8.GetString((byte*)BitConverter.ToInt32(new Span<byte>((void*)(ptr + 12), 4)), BitConverter.ToInt32(new Span<byte>((void*)(ptr + 16), 4))));
                                break;
                            }

                            default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 8), 1)[0]}");
                        }

                        lifted58 = Result<ulong, global::SpinHttpWorld.wit.imports.fermyon.spin.v2_0_0.IRdbmsTypes.Error>.err(lifted);
                        break;
                    }

                    default: throw new ArgumentException($"invalid discriminant: {new Span<byte>((void*)(ptr + 0), 1)[0]}");
                }
                gcHandle.Free();
                if (lifted58.IsOk) {
                    var tmp = lifted58.AsOk;
                    return tmp;
                } else {
                    throw new WitException(lifted58.AsErr!, 0);
                }
            }

            //TODO: free alloc handle (interopString) if exists
        }

    }

}
