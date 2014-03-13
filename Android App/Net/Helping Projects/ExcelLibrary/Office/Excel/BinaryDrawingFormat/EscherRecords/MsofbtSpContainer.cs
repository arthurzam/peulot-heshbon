namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtSpContainer : MsofbtContainer
    {
        public MsofbtSpContainer(EscherRecord record) : base(record) { }

        public MsofbtSpContainer()
        {
            this.Type = EscherRecordType.MsofbtSpContainer;
        }
    }
}