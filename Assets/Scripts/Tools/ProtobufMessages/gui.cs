// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: gui.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract(Name = @"GUI")]
    public partial class Gui : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"fullscreen")]
        public bool Fullscreen
        {
            get { return __pbn__Fullscreen.GetValueOrDefault(); }
            set { __pbn__Fullscreen = value; }
        }
        public bool ShouldSerializeFullscreen() => __pbn__Fullscreen != null;
        public void ResetFullscreen() => __pbn__Fullscreen = null;
        private bool? __pbn__Fullscreen;

        [global::ProtoBuf.ProtoMember(2, Name = @"camera")]
        public GUICamera Camera { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"plugin")]
        public global::System.Collections.Generic.List<Plugin> Plugins { get; } = new global::System.Collections.Generic.List<Plugin>();

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
