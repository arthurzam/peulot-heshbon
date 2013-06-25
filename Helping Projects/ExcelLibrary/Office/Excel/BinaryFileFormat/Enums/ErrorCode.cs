using System.Collections.Generic;

namespace ExcelLibrary.BinaryFileFormat
{
    public class ErrorCode
    {
        public byte Code;
        public string Value;

        private ErrorCode(byte code, string value)
        {
            Code = code;
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public static Dictionary<byte, ErrorCode> ErrorCodes;

        static ErrorCode()
        {
            ErrorCodes = new Dictionary<byte, ErrorCode>();
            AddErrorCode(0x00, "#NULL!");
            AddErrorCode(0x07, "#DIV/0!");
            AddErrorCode(0x0F, "#VALUE!");
            AddErrorCode(0x17, "#REF!");
            AddErrorCode(0x1D, "#NAME?");
            AddErrorCode(0x24, "#NUM!");
            AddErrorCode(0x2A, "#N/A!");
        }

        private static void AddErrorCode(byte code, string value)
        {
            ErrorCode error = new ErrorCode(code, value);
            ErrorCodes.Add(code, error);
        }
    }
}