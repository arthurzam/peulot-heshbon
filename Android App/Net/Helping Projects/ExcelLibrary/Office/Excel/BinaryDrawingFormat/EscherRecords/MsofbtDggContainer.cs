namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtDggContainer : MsofbtContainer
    {
        public MsofbtDggContainer(EscherRecord record) : base(record) { }

        public MsofbtDggContainer()
        {
            this.Type = EscherRecordType.MsofbtDggContainer;
        }
    }
}