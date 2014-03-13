namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtArcRule : EscherRecord
    {
        public MsofbtArcRule(EscherRecord record) : base(record) { }

        public MsofbtArcRule()
        {
            this.Type = EscherRecordType.MsofbtArcRule;
        }
    }
}