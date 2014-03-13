namespace ExcelLibrary.BinaryFileFormat
{
    public partial class MSODRAWING : MSOCONTAINER
    {
        public MSODRAWING(Record record) : base(record) { }

        public MSODRAWING()
        {
            this.Type = RecordType.MSODRAWING;
        }
    }
}