namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtClientTextbox : EscherRecord
    {
        public MsofbtClientTextbox(EscherRecord record) : base(record) { }

        public MsofbtClientTextbox()
        {
            this.Type = EscherRecordType.MsofbtClientTextbox;
        }
    }
}