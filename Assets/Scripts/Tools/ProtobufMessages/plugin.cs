// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: plugin.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Plugin : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name", IsRequired = true)]
        public string Name { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"filename", IsRequired = true)]
        public string Filename { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"innerxml")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Innerxml
        {
            get { return __pbn__Innerxml ?? ""; }
            set { __pbn__Innerxml = value; }
        }
        public bool ShouldSerializeInnerxml() => __pbn__Innerxml != null;
        public void ResetInnerxml() => __pbn__Innerxml = null;
        private string __pbn__Innerxml;

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
