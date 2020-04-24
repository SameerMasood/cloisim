// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: gui_camera.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GUICamera : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name", IsRequired = true)]
        public string Name { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"view_controller")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ViewController
        {
            get { return __pbn__ViewController ?? ""; }
            set { __pbn__ViewController = value; }
        }
        public bool ShouldSerializeViewController() => __pbn__ViewController != null;
        public void ResetViewController() => __pbn__ViewController = null;
        private string __pbn__ViewController;

        [global::ProtoBuf.ProtoMember(3, Name = @"pose")]
        public Pose Pose { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"track")]
        public TrackVisual Track { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"projection_type")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ProjectionType
        {
            get { return __pbn__ProjectionType ?? ""; }
            set { __pbn__ProjectionType = value; }
        }
        public bool ShouldSerializeProjectionType() => __pbn__ProjectionType != null;
        public void ResetProjectionType() => __pbn__ProjectionType = null;
        private string __pbn__ProjectionType;

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
