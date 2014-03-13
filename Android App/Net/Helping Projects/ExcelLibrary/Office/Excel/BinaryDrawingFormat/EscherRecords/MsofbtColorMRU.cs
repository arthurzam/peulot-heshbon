namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtColorMRU : EscherRecord
    {
        public MsofbtColorMRU(EscherRecord record) : base(record) { }

        public MsofbtColorMRU()
        {
            this.Type = EscherRecordType.MsofbtColorMRU;
        }
    }
}