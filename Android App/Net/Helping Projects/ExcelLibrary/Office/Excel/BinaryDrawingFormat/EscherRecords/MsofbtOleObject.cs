namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtOleObject : EscherRecord
    {
        public MsofbtOleObject(EscherRecord record) : base(record) { }

        public MsofbtOleObject()
        {
            this.Type = EscherRecordType.MsofbtOleObject;
        }
    }
}