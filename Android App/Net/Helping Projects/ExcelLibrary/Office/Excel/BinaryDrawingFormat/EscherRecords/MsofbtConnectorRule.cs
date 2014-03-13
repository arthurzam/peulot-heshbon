namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtConnectorRule : EscherRecord
    {
        public MsofbtConnectorRule(EscherRecord record) : base(record) { }

        public MsofbtConnectorRule()
        {
            this.Type = EscherRecordType.MsofbtConnectorRule;
        }
    }
}