using System;

namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtBlip : EscherRecord
    {
        public MsofbtBlip() { }

        public MsofbtBlip(EscherRecord record) : base(record) { }

        public Guid UID;

        public Byte Marker;

        public Byte[] ImageData;
    }
}