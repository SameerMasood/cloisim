// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: server_control.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ServerControl : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"save_world_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SaveWorldName
        {
            get { return __pbn__SaveWorldName ?? ""; }
            set { __pbn__SaveWorldName = value; }
        }
        public bool ShouldSerializeSaveWorldName() => __pbn__SaveWorldName != null;
        public void ResetSaveWorldName() => __pbn__SaveWorldName = null;
        private string __pbn__SaveWorldName;

        [global::ProtoBuf.ProtoMember(2, Name = @"save_filename")]
        [global::System.ComponentModel.DefaultValue("")]
        public string SaveFilename
        {
            get { return __pbn__SaveFilename ?? ""; }
            set { __pbn__SaveFilename = value; }
        }
        public bool ShouldSerializeSaveFilename() => __pbn__SaveFilename != null;
        public void ResetSaveFilename() => __pbn__SaveFilename = null;
        private string __pbn__SaveFilename;

        [global::ProtoBuf.ProtoMember(3, Name = @"open_filename")]
        [global::System.ComponentModel.DefaultValue("")]
        public string OpenFilename
        {
            get { return __pbn__OpenFilename ?? ""; }
            set { __pbn__OpenFilename = value; }
        }
        public bool ShouldSerializeOpenFilename() => __pbn__OpenFilename != null;
        public void ResetOpenFilename() => __pbn__OpenFilename = null;
        private string __pbn__OpenFilename;

        [global::ProtoBuf.ProtoMember(4, Name = @"new_world")]
        public bool NewWorld
        {
            get { return __pbn__NewWorld.GetValueOrDefault(); }
            set { __pbn__NewWorld = value; }
        }
        public bool ShouldSerializeNewWorld() => __pbn__NewWorld != null;
        public void ResetNewWorld() => __pbn__NewWorld = null;
        private bool? __pbn__NewWorld;

        [global::ProtoBuf.ProtoMember(5, Name = @"stop")]
        public bool Stop
        {
            get { return __pbn__Stop.GetValueOrDefault(); }
            set { __pbn__Stop = value; }
        }
        public bool ShouldSerializeStop() => __pbn__Stop != null;
        public void ResetStop() => __pbn__Stop = null;
        private bool? __pbn__Stop;

        [global::ProtoBuf.ProtoMember(6, Name = @"clone")]
        public bool Clone
        {
            get { return __pbn__Clone.GetValueOrDefault(); }
            set { __pbn__Clone = value; }
        }
        public bool ShouldSerializeClone() => __pbn__Clone != null;
        public void ResetClone() => __pbn__Clone = null;
        private bool? __pbn__Clone;

        [global::ProtoBuf.ProtoMember(7, Name = @"new_port")]
        public uint NewPort
        {
            get { return __pbn__NewPort.GetValueOrDefault(); }
            set { __pbn__NewPort = value; }
        }
        public bool ShouldSerializeNewPort() => __pbn__NewPort != null;
        public void ResetNewPort() => __pbn__NewPort = null;
        private uint? __pbn__NewPort;

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
