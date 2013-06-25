namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtClientData : EscherRecord
    {
        public MsofbtClientData(EscherRecord record) : base(record) { }

        public MsofbtClientData()
        {
            this.Type = EscherRecordType.MsofbtClientData;
        }
    }
}