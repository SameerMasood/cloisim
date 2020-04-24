// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: light.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Light : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"name", IsRequired = true)]
        public string Name { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"type")]
        [global::System.ComponentModel.DefaultValue(LightType.Point)]
        public LightType Type
        {
            get { return __pbn__Type ?? LightType.Point; }
            set { __pbn__Type = value; }
        }
        public bool ShouldSerializeType() => __pbn__Type != null;
        public void ResetType() => __pbn__Type = null;
        private LightType? __pbn__Type;

        [global::ProtoBuf.ProtoMember(3, Name = @"pose")]
        public Pose Pose { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"diffuse")]
        public Color Diffuse { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"specular")]
        public Color Specular { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"attenuation_constant")]
        public float AttenuationConstant
        {
            get { return __pbn__AttenuationConstant.GetValueOrDefault(); }
            set { __pbn__AttenuationConstant = value; }
        }
        public bool ShouldSerializeAttenuationConstant() => __pbn__AttenuationConstant != null;
        public void ResetAttenuationConstant() => __pbn__AttenuationConstant = null;
        private float? __pbn__AttenuationConstant;

        [global::ProtoBuf.ProtoMember(7, Name = @"attenuation_linear")]
        public float AttenuationLinear
        {
            get { return __pbn__AttenuationLinear.GetValueOrDefault(); }
            set { __pbn__AttenuationLinear = value; }
        }
        public bool ShouldSerializeAttenuationLinear() => __pbn__AttenuationLinear != null;
        public void ResetAttenuationLinear() => __pbn__AttenuationLinear = null;
        private float? __pbn__AttenuationLinear;

        [global::ProtoBuf.ProtoMember(8, Name = @"attenuation_quadratic")]
        public float AttenuationQuadratic
        {
            get { return __pbn__AttenuationQuadratic.GetValueOrDefault(); }
            set { __pbn__AttenuationQuadratic = value; }
        }
        public bool ShouldSerializeAttenuationQuadratic() => __pbn__AttenuationQuadratic != null;
        public void ResetAttenuationQuadratic() => __pbn__AttenuationQuadratic = null;
        private float? __pbn__AttenuationQuadratic;

        [global::ProtoBuf.ProtoMember(9, Name = @"direction")]
        public Vector3d Direction { get; set; }

        [global::ProtoBuf.ProtoMember(10, Name = @"range")]
        public float Range
        {
            get { return __pbn__Range.GetValueOrDefault(); }
            set { __pbn__Range = value; }
        }
        public bool ShouldSerializeRange() => __pbn__Range != null;
        public void ResetRange() => __pbn__Range = null;
        private float? __pbn__Range;

        [global::ProtoBuf.ProtoMember(11, Name = @"cast_shadows")]
        public bool CastShadows
        {
            get { return __pbn__CastShadows.GetValueOrDefault(); }
            set { __pbn__CastShadows = value; }
        }
        public bool ShouldSerializeCastShadows() => __pbn__CastShadows != null;
        public void ResetCastShadows() => __pbn__CastShadows = null;
        private bool? __pbn__CastShadows;

        [global::ProtoBuf.ProtoMember(12, Name = @"spot_inner_angle")]
        public float SpotInnerAngle
        {
            get { return __pbn__SpotInnerAngle.GetValueOrDefault(); }
            set { __pbn__SpotInnerAngle = value; }
        }
        public bool ShouldSerializeSpotInnerAngle() => __pbn__SpotInnerAngle != null;
        public void ResetSpotInnerAngle() => __pbn__SpotInnerAngle = null;
        private float? __pbn__SpotInnerAngle;

        [global::ProtoBuf.ProtoMember(13, Name = @"spot_outer_angle")]
        public float SpotOuterAngle
        {
            get { return __pbn__SpotOuterAngle.GetValueOrDefault(); }
            set { __pbn__SpotOuterAngle = value; }
        }
        public bool ShouldSerializeSpotOuterAngle() => __pbn__SpotOuterAngle != null;
        public void ResetSpotOuterAngle() => __pbn__SpotOuterAngle = null;
        private float? __pbn__SpotOuterAngle;

        [global::ProtoBuf.ProtoMember(14, Name = @"spot_falloff")]
        public float SpotFalloff
        {
            get { return __pbn__SpotFalloff.GetValueOrDefault(); }
            set { __pbn__SpotFalloff = value; }
        }
        public bool ShouldSerializeSpotFalloff() => __pbn__SpotFalloff != null;
        public void ResetSpotFalloff() => __pbn__SpotFalloff = null;
        private float? __pbn__SpotFalloff;

        [global::ProtoBuf.ProtoMember(15, Name = @"id")]
        public uint Id
        {
            get { return __pbn__Id.GetValueOrDefault(); }
            set { __pbn__Id = value; }
        }
        public bool ShouldSerializeId() => __pbn__Id != null;
        public void ResetId() => __pbn__Id = null;
        private uint? __pbn__Id;

        [global::ProtoBuf.ProtoContract()]
        public enum LightType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"POINT")]
            Point = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"SPOT")]
            Spot = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"DIRECTIONAL")]
            Directional = 3,
        }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
