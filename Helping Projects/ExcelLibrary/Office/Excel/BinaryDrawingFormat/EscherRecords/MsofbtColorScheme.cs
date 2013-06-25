namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtColorScheme : EscherRecord
    {
        public MsofbtColorScheme(EscherRecord record) : base(record) { }

        public MsofbtColorScheme()
        {
            this.Type = EscherRecordType.MsofbtColorScheme;
        }
    }
}