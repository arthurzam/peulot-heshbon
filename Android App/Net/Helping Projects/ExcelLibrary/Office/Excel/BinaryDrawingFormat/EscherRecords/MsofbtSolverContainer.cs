namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtSolverContainer : MsofbtContainer
    {
        public MsofbtSolverContainer(EscherRecord record) : base(record) { }

        public MsofbtSolverContainer()
        {
            this.Type = EscherRecordType.MsofbtSolverContainer;
        }
    }
}