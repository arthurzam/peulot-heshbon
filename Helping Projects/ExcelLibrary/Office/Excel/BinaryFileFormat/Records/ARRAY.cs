namespace ExcelLibrary.BinaryFileFormat
{
    public partial class ARRAY : Record
    {
        public ARRAY(Record record) : base(record) { }

        public ARRAY()
        {
            this.Type = RecordType.ARRAY;
        }
    }
}