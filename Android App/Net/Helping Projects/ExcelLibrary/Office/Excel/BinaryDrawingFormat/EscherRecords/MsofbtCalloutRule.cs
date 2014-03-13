namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtCalloutRule : EscherRecord
    {
        public MsofbtCalloutRule(EscherRecord record) : base(record) { }

        public MsofbtCalloutRule()
        {
            this.Type = EscherRecordType.MsofbtCalloutRule;
        }
    }
}