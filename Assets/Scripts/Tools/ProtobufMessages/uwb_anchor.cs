// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: uwb_anchor.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class UwbAnchor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public int Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"dist", IsRequired = true)]
        public int Dist { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"pos")]
        public Vector3d Pos { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"estimated_pos")]
        public Vector3d EstimatedPos { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"state")]
        public int State
        {
            get { return __pbn__State.GetValueOrDefault(); }
            set { __pbn__State = value; }
        }
        public bool ShouldSerializeState() => __pbn__State != null;
        public void ResetState() => __pbn__State = null;
        private int? __pbn__State;

        [global::ProtoBuf.ProtoMember(6, Name = @"strength")]
        public int Strength
        {
            get { return __pbn__Strength.GetValueOrDefault(); }
            set { __pbn__Strength = value; }
        }
        public bool ShouldSerializeStrength() => __pbn__Strength != null;
        public void ResetStrength() => __pbn__Strength = null;
        private int? __pbn__Strength;

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
