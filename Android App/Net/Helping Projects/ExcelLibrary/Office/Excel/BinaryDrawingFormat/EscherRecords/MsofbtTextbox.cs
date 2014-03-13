namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtTextbox : EscherRecord
    {
        public MsofbtTextbox(EscherRecord record) : base(record) { }

        public MsofbtTextbox()
        {
            this.Type = EscherRecordType.MsofbtTextbox;
        }
    }
}