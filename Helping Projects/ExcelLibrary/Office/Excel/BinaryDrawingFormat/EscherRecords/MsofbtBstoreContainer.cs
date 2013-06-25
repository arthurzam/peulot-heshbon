namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtBstoreContainer : MsofbtContainer
    {
        public MsofbtBstoreContainer(EscherRecord record) : base(record) { }

        public MsofbtBstoreContainer()
        {
            this.Type = EscherRecordType.MsofbtBstoreContainer;
        }
    }
}