namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtDeletedPspl : EscherRecord
    {
        public MsofbtDeletedPspl(EscherRecord record) : base(record) { }

        public MsofbtDeletedPspl()
        {
            this.Type = EscherRecordType.MsofbtDeletedPspl;
        }
    }
}