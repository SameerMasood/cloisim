// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: log_playback_control.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace gazebo.msgs
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LogPlaybackControl : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pause")]
        public bool Pause
        {
            get { return __pbn__Pause.GetValueOrDefault(); }
            set { __pbn__Pause = value; }
        }
        public bool ShouldSerializePause() => __pbn__Pause != null;
        public void ResetPause() => __pbn__Pause = null;
        private bool? __pbn__Pause;

        [global::ProtoBuf.ProtoMember(2, Name = @"multi_step", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
        public int MultiStep
        {
            get { return __pbn__MultiStep.GetValueOrDefault(); }
            set { __pbn__MultiStep = value; }
        }
        public bool ShouldSerializeMultiStep() => __pbn__MultiStep != null;
        public void ResetMultiStep() => __pbn__MultiStep = null;
        private int? __pbn__MultiStep;

        [global::ProtoBuf.ProtoMember(3, Name = @"rewind")]
        public bool Rewind
        {
            get { return __pbn__Rewind.GetValueOrDefault(); }
            set { __pbn__Rewind = value; }
        }
        public bool ShouldSerializeRewind() => __pbn__Rewind != null;
        public void ResetRewind() => __pbn__Rewind = null;
        private bool? __pbn__Rewind;

        [global::ProtoBuf.ProtoMember(4, Name = @"forward")]
        public bool Forward
        {
            get { return __pbn__Forward.GetValueOrDefault(); }
            set { __pbn__Forward = value; }
        }
        public bool ShouldSerializeForward() => __pbn__Forward != null;
        public void ResetForward() => __pbn__Forward = null;
        private bool? __pbn__Forward;

        [global::ProtoBuf.ProtoMember(5, Name = @"seek")]
        public Time Seek { get; set; }

    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
