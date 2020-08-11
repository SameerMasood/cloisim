// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: micom.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Micom : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"time", IsRequired = true)]
        public Time Time { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"odom", IsRequired = true)]
        public Odometry Odom { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public Uss uss { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public Ir ir { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public Magnet magnet { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"accgyro")]
        public AccGyro Accgyro { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"imu")]
        public Imu Imu { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public Bumper bumper { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"battery")]
        public Battery Battery { get; set; }

        [global::ProtoBuf.ProtoContract(Name = @"USS")]
        public partial class Uss : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"distance")]
            public double[] Distances { get; set; }

        }

        [global::ProtoBuf.ProtoContract(Name = @"IR")]
        public partial class Ir : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"distance")]
            public double[] Distances { get; set; }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Magnet : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"detected")]
            public bool[] Detecteds { get; set; }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Odometry : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"speed_left", IsRequired = true)]
            public double SpeedLeft { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"speed_right", IsRequired = true)]
            public double SpeedRight { get; set; }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class AccGyro : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"angle_x", IsRequired = true)]
            public double AngleX { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"angle_y", IsRequired = true)]
            public double AngleY { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"angle_z", IsRequired = true)]
            public double AngleZ { get; set; }

            [global::ProtoBuf.ProtoMember(4, Name = @"anguler_rate_x", IsRequired = true)]
            public double AngulerRateX { get; set; }

            [global::ProtoBuf.ProtoMember(5, Name = @"anguler_rate_y", IsRequired = true)]
            public double AngulerRateY { get; set; }

            [global::ProtoBuf.ProtoMember(6, Name = @"anguler_rate_z", IsRequired = true)]
            public double AngulerRateZ { get; set; }

            [global::ProtoBuf.ProtoMember(7, Name = @"acc_x", IsRequired = true)]
            public double AccX { get; set; }

            [global::ProtoBuf.ProtoMember(8, Name = @"acc_y", IsRequired = true)]
            public double AccY { get; set; }

            [global::ProtoBuf.ProtoMember(9, Name = @"acc_z", IsRequired = true)]
            public double AccZ { get; set; }

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Bumper : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"bumped")]
            public bool[] Bumpeds { get; set; }

        }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
