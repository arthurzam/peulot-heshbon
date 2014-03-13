using System;
using System.Collections.Generic;
using System.IO;
using Peulot_Heshbon.Classes;

namespace Peulot_Heshbon.Code.Files
{
    /// <summary>
    /// methods for marks file
    /// </summary>
    internal static class MarksFile
    {
        /// <summary>
        /// the path to marks file
        /// </summary>
        public static string TheFile = Register.Start.Properties.FolderForData + @"\marks.dat";

        #region Binary

        /// <summary>
        /// Write the Mark object inside the marks file
        /// </summary>
        /// <param name="mark">the Mark object, all properties are set</param>
        public static void WriteMark(Mark mark)
        {
            File.SetAttributes(TheFile, FileAttributes.Normal);
            using (FileStream fs = new FileStream(TheFile, FileMode.Append, FileAccess.Write))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                // date & time
                bw.Write(mark.DateTime.Year % 100);
                bw.Write(mark.DateTime.Month);
                bw.Write(mark.DateTime.Day);
                bw.Write(mark.DateTime.Hour);
                bw.Write(mark.DateTime.Minute);
                bw.Write(mark.DateTime.Second);

                bw.Write(mark.quizType.ConvertTypeToByte()); // Quiz type
                bw.Write(mark.mark);   // the mark
                bw.Write(mark.secendsToFinish);  // Time taken to finish
                bw.Write(Program.name.LastName);  // Last Name of person
                bw.Write(Program.name.FirstName); // First Name of person

                bw.Close();
                fs.Close();
            }

            File.SetAttributes(TheFile, FileAttributes.ReadOnly);
        }

        /// <summary>
        /// Creates a Mark object and it write the Mark object inside the marks file
        /// </summary>
        /// <param name="mark">the mark of quiz</param>
        /// <param name="type">type of quiz</param>
        /// <param name="timeToFinish">time taken to finish the quiz</param>
        public static void WriteMark(int mark, QuizType type, int timeToFinish)
        {
            Mark m = new Mark();
            m.mark = mark;
            m.name = "";
            m.secendsToFinish = timeToFinish;
            m.quizType = type;
            m.DateTime = DateTime.Now;
            WriteMark(m);
        }

        /// <summary>
        /// Get a Mark List of all marks saved on marks file
        /// </summary>
        /// <returns>the Mark List</returns>
        public static List<Mark> ReadAllMarks()
        {
            List<Mark> list = new List<Mark>();
            bool Delete = false;

            using (FileStream fs = new FileStream(TheFile, FileMode.Open, FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                try
                {
                    while (fs.Length != fs.Position)
                    {
                        Mark m = new Mark();
                        {
                            int temp = br.ReadInt32();
                            int year = (temp >= 50 ? 1900 + temp : 2000 + temp);
                            m.DateTime = new DateTime(year, br.ReadInt32(), br.ReadInt32(), br.ReadInt32(), br.ReadInt32(), br.ReadInt32());
                        }
                        m.quizType.ConvertByteToType(br.ReadByte());
                        m.mark = br.ReadInt32();
                        m.secendsToFinish = br.ReadInt32();
                        m.name = br.ReadString() + ' ' + br.ReadString();
                        list.Add(m);
                    }
                }
                catch (IOException)
                {
                    Delete = true;
                }
                br.Close();
                fs.Close();
            }
            if (Delete)
            {
                ClearFile();
                return new List<Mark>();
            }
            return list;
        }

        /// <summary>
        /// Remove the Mark from the mark list by it place
        /// </summary>
        /// <param name="place">the place</param>
        public static void RemoveMark(int place)
        {
            List<Mark> list = ReadAllMarks();
            list.Remove(list[place]);
            ClearFile();
            foreach (Mark m in list)
                WriteMark(m);
        }

        /// <summary>
        /// Clears the marks file
        /// </summary>
        public static void ClearFile()
        {
            File.SetAttributes(TheFile, FileAttributes.Normal);
            File.Delete(TheFile);
            File.Create(TheFile).Close();
            File.SetAttributes(TheFile, FileAttributes.ReadOnly);
        }

        #endregion Binary

        #region Get Special Data From Marks File

        /// <summary>
        /// get all dates in file that are different
        /// </summary>
        /// <returns>list of string</returns>
        public static List<string> GetAllDates()
        {
            List<string> al = new List<string>();
            foreach (Mark m in ReadAllMarks())
            {
                if (!al.Contains(m.DateTime.ToShortDateString()))
                    al.Add(m.DateTime.ToShortDateString());
            }
            return al;
        }

        /// <summary>
        /// get all names in file that are different
        /// </summary>
        /// <returns>list of string</returns>
        public static List<string> GetAllNames()
        {
            List<string> al = new List<string>();
            foreach (Mark m in ReadAllMarks())
            {
                if (!al.Contains(m.name))
                    al.Add(m.name);
            }
            return al;
        }

        /// <summary>
        /// get all peulot
        /// </summary>
        /// <returns>list of string</returns>
        public static List<string> GetAllPeulot()
        {
            List<string> al = new List<string>();
            foreach (Mark m in ReadAllMarks())
            {
                if (!al.Contains(m.quizType.ToString()))
                    al.Add(m.quizType.ToString());
            }
            return al;
        }

        #endregion Get Special Data From Marks File
    }
}