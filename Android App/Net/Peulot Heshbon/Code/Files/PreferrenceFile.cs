using System;
using System.IO;

namespace Peulot_Heshbon.Code.Files
{
    internal static class PreferrenceFile
    {
        public static readonly float[] sizes = new float[] { 8F, 10F, 12F, 14F, 16F, 18F, 20F, 22F, 24F, 26F };
        public static readonly string[] fonts = new string[] { "Microsoft Sans Serif", "Arial", "Times New Roman" };
        public static readonly string TheFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\PeulotHeshbon\preference.pdb";

        public static int font = 0;
        public static int font_size = 1;
        public static Classes.Difficulty difficulty;

        public static void Update()
        {
            FileStream fs = new FileStream(TheFile, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write((byte)font);
            bw.Write((byte)font_size);
            bw.Write((byte)difficulty);
            bw.Close();
            fs.Close();
            Set();
        }

        public static void Set()
        {
            FileStream fs = new FileStream(TheFile, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            font = (int)br.ReadByte();
            font_size = (int)br.ReadByte();
            difficulty = (Classes.Difficulty)br.ReadByte();
            br.Close();
            fs.Close();
        }

        public static void SetBasis()
        {
            FileStream fs = new FileStream(TheFile, FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            font = 1;
            font_size = (int)br.ReadByte();
            difficulty = (Classes.Difficulty)br.ReadByte();
            br.Close();
            fs.Close();
        }

        public static System.Drawing.Font GetReadyFont
        {
            get
            {
                return new System.Drawing.Font(fonts[font], sizes[font_size],
                    System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            }
        }
    }
}