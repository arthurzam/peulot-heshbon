namespace ExcelLibrary.BinaryFileFormat
{
    public partial class BITMAP : Record
    {
        public BITMAP(Record record) : base(record) { }

        public BITMAP()
        {
            this.Type = RecordType.BITMAP;
        }
    }
}