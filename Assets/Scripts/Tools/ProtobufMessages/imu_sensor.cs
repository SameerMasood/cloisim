// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: imu_sensor.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class IMUSensor : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public AngularVelocity angular_velocity { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public LinearAcceleration linear_acceleration { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class AngularVelocity : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"x_noise")]
            public SensorNoise XNoise { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"y_noise")]
            public SensorNoise YNoise { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"z_noise")]
            public SensorNoise ZNoise { get; set; }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class LinearAcceleration : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"x_noise")]
            public SensorNoise XNoise { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"y_noise")]
            public SensorNoise YNoise { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"z_noise")]
            public SensorNoise ZNoise { get; set; }

        }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
