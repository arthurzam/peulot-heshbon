namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtSpgrContainer : MsofbtContainer
    {
        public MsofbtSpgrContainer(EscherRecord record) : base(record) { }

        public MsofbtSpgrContainer()
        {
            this.Type = EscherRecordType.MsofbtSpgrContainer;
        }
    }
}