﻿namespace ExcelLibrary.BinaryDrawingFormat
{
    public partial class MsofbtRegroupItems : EscherRecord
    {
        public MsofbtRegroupItems(EscherRecord record) : base(record) { }

        public MsofbtRegroupItems()
        {
            this.Type = EscherRecordType.MsofbtRegroupItems;
        }
    }
}