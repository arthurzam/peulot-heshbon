namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtSp : EscherRecord
    {
        public ShapeType ShapeType
        {
            get
            {
                return (ShapeType)Instance;
            }
            set
            {
                Instance = (ushort)value;
            }
        }
    }
}