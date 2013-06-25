namespace ExcelLibrary.BinaryFileFormat
{
    public partial class GroupMarker : SubRecord
    {
        public GroupMarker(SubRecord record) : base(record) { }

        public GroupMarker()
        {
            this.Type = SubRecordType.GroupMarker;
        }
    }
}