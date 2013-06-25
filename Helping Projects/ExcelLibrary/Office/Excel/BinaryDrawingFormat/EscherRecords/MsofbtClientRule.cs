namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtClientRule : EscherRecord
    {
        public MsofbtClientRule(EscherRecord record) : base(record) { }

        public MsofbtClientRule()
        {
            this.Type = EscherRecordType.MsofbtClientRule;
        }
    }
}