﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34209
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple7AllPolymorphicGetOnlyPropertyAndConstructorSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7AllPolymorphicGetOnlyPropertyAndConstructor> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>> _serializer1;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Tuple_Tuple7AllPolymorphicGetOnlyPropertyAndConstructorSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[7];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchemaTypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchemaTypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchemaTypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchemaTypeMap0);
            tupleItemsSchema0[0] = tupleItemSchema0;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema1TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema1TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema1TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema1TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema1TypeMap0);
            tupleItemsSchema0[1] = tupleItemSchema1;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema2 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema2TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema2TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema2TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema2TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema2 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema2TypeMap0);
            tupleItemsSchema0[2] = tupleItemSchema2;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema3 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema3TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema3TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema3TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema3TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema3 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema3TypeMap0);
            tupleItemsSchema0[3] = tupleItemSchema3;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema4 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema4TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema4TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema4TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema4TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema4 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema4TypeMap0);
            tupleItemsSchema0[4] = tupleItemSchema4;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema5 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema5TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema5TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema5TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema5TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema5 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema5TypeMap0);
            tupleItemsSchema0[5] = tupleItemSchema5;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema6 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema6TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema6TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema6TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema6TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema6 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema6TypeMap0);
            tupleItemsSchema0[6] = tupleItemSchema6;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema1 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema1 = new MsgPack.Serialization.PolymorphismSchema[7];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema7 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema7TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema7TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema7TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema7TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema7 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema7TypeMap0);
            tupleItemsSchema1[0] = tupleItemSchema7;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema8 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema8TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema8TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema8TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema8TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema8 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema8TypeMap0);
            tupleItemsSchema1[1] = tupleItemSchema8;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema9 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema9TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema9TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema9TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema9TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema9 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema9TypeMap0);
            tupleItemsSchema1[2] = tupleItemSchema9;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema10 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema10TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema10TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema10TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema10TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema10 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema10TypeMap0);
            tupleItemsSchema1[3] = tupleItemSchema10;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema11 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema11TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema11TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema11TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema11TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema11 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema11TypeMap0);
            tupleItemsSchema1[4] = tupleItemSchema11;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema12 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema12TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema12TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema12TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema12TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema12 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema12TypeMap0);
            tupleItemsSchema1[5] = tupleItemSchema12;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema13 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> tupleItemSchema13TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            tupleItemSchema13TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            tupleItemSchema13TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema13TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            tupleItemSchema13 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), tupleItemSchema13TypeMap0);
            tupleItemsSchema1[6] = tupleItemSchema13;
            schema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>), tupleItemsSchema1);
            this._serializer1 = context.GetSerializer<System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>>(schema1);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7AllPolymorphicGetOnlyPropertyAndConstructor objectTree) {
            packer.PackMapHeader(1);
            this._serializer0.PackTo(packer, "Tuple7AllPolymorphic");
            this._serializer1.PackTo(packer, objectTree.Tuple7AllPolymorphic);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7AllPolymorphicGetOnlyPropertyAndConstructor UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7AllPolymorphicGetOnlyPropertyAndConstructor result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7AllPolymorphicGetOnlyPropertyAndConstructor);
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> ctorArg0 = default(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
                ctorArg0 = null;
                System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> nullable = default(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer1.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    ctorArg0 = nullable;
                }
                unpacked = (unpacked + 1);
                result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7AllPolymorphicGetOnlyPropertyAndConstructor(ctorArg0);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> ctorArg00 = default(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
                ctorArg00 = null;
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable0 = default(string);
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7AllPolymorphicGetOnlyPropertyAndConstructor), "MemberName");
                    if (((nullable0 == null) 
                                == false)) {
                        key = nullable0;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Tuple7AllPolymorphic")) {
                        System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry> nullable1 = default(System.Tuple<MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry, MsgPack.Serialization.FileSystemEntry>);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable1 = this._serializer1.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                            disposable0 = unpacker.ReadSubtree();
                            try {
                                nullable1 = this._serializer1.UnpackFrom(disposable0);
                            }
                            finally {
                                if (((disposable0 == null) 
                                            == false)) {
                                    disposable0.Dispose();
                                }
                            }
                        }
                        if (((nullable1 == null) 
                                    == false)) {
                            ctorArg00 = nullable1;
                        }
                    }
                    else {
                        unpacker.Skip();
                    }
                }
                result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Tuple_Tuple7AllPolymorphicGetOnlyPropertyAndConstructor(ctorArg00);
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
