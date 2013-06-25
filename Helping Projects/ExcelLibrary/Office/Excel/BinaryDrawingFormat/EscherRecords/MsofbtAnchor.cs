namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtAnchor : EscherRecord
    {
        public MsofbtAnchor(EscherRecord record) : base(record) { }

        public MsofbtAnchor()
        {
            this.Type = EscherRecordType.MsofbtAnchor;
        }
    }
}