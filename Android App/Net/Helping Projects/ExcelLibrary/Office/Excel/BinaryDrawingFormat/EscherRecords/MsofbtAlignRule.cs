namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtAlignRule : EscherRecord
    {
        public MsofbtAlignRule(EscherRecord record) : base(record) { }

        public MsofbtAlignRule()
        {
            this.Type = EscherRecordType.MsofbtAlignRule;
        }
    }
}