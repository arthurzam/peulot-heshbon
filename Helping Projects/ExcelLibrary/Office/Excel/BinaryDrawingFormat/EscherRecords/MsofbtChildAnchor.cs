namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtChildAnchor : EscherRecord
    {
        public MsofbtChildAnchor(EscherRecord record) : base(record) { }

        public MsofbtChildAnchor()
        {
            this.Type = EscherRecordType.MsofbtChildAnchor;
        }
    }
}