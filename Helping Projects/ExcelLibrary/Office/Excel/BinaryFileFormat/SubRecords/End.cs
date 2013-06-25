namespace ExcelLibrary.BinaryFileFormat
{
    public partial class End : SubRecord
    {
        public End(SubRecord record) : base(record) { }

        public End()
        {
            this.Type = SubRecordType.End;
        }
    }
}