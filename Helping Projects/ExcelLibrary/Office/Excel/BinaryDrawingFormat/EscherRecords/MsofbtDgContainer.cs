namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtDgContainer : MsofbtContainer
    {
        public MsofbtDgContainer(EscherRecord record) : base(record) { }

        public MsofbtDgContainer()
        {
            this.Type = EscherRecordType.MsofbtDgContainer;
        }
    }
}