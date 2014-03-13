using System;
using PeulotHeshbon.ZipLibrary.Zip;
using IO = System.IO;

namespace Peulot_Heshbon.Languages
{
    internal static class Zip
    {
        /// <summary>
        /// Add a file to the zip file
        /// </summary>
        /// <param name="filePath">the file</param>
        /// <param name="nameInZip">the name of file in zip</param>
        /// <param name="zipFile">the path to zip file.</param>
        public static void AddFile(string filePath, string nameInZip, string zipFile = "")
        {
            if (zipFile == "") zipFile = Program.ExePath + @"\Languages.dll";
            if (!IO.File.Exists(zipFile))
                CreateFile(Program.ExePath + @"\Languages.dll");
            using (ZipFile file = new ZipFile(zipFile))
            {
                file.BeginUpdate();
                file.Add(filePath, nameInZip);
                file.CommitUpdate();
                file.Close();
            }
        }

        /// <summary>
        /// create an empty zip file
        /// </summary>
        /// <param name="File">the zip file</param>
        public static void CreateFile(string File)
        {
            using (ZipFile file = ZipFile.Create(File))
            {
                file.BeginUpdate();
                file.CommitUpdate();
                file.Close();
            }
        }

        /// <summary>
        /// Extracts a all files from the zip file
        /// </summary>
        /// <param name="sourceZip">the zip file</param>
        /// <param name="destinationFolder">the folder the files will be extracted to</param>
        public static int ExtractAll(string sourceZip, string destination)
        {
            ZipInputStream zinstream = null; // used to read from the zip file
            int numFileUnzipped = 0; // number of files extracted from the zip file

            try
            {
                // create a zip input stream from source zip file
                zinstream = new ZipInputStream(IO.File.OpenRead(sourceZip));

                // we need to extract to a folder so we must create it if needed
                if (!IO.Directory.Exists(destination))
                    IO.Directory.CreateDirectory(destination);

                ZipEntry theEntry; // an entry in the zip file which could be a file or directory

                // now, walk through the zip file entries and copy each file/directory
                while ((theEntry = zinstream.GetNextEntry()) != null)
                {
                    string dirname = IO.Path.GetDirectoryName(theEntry.Name); // the file Path
                    string fname = IO.Path.GetFileName(theEntry.Name);        // the file name

                    // if a path name exists we should create the directory in the destination folder
                    string target = destination + IO.Path.DirectorySeparatorChar + dirname;
                    if (dirname.Length > 0 && !IO.Directory.Exists(target))
                        IO.Directory.CreateDirectory(target);

                    // now we know the proper path exists in the destination so copy the file there
                    if (fname != String.Empty)
                    {
                        DecompressAndWriteFile(destination + IO.Path.DirectorySeparatorChar + theEntry.Name, zinstream);
                        numFileUnzipped++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                zinstream.Close();
            }

            return numFileUnzipped;
        }

        /// <summary>
        /// Extracts a specific file from the zip file
        /// </summary>
        /// <param name="sourceZip">the zip file</param>
        /// <param name="destinationFolder">the folder the file will be extracted to</param>
        /// <param name="FileName">the file name</param>
        public static void ExtractFile(string sourceZip, string destinationFolder, string FileName)
        {
            ZipInputStream zinstream = null;
            int numFileUnzipped = 0;
            try
            {
                zinstream = new ZipInputStream(IO.File.OpenRead(sourceZip));

                if (!IO.Directory.Exists(destinationFolder))
                    IO.Directory.CreateDirectory(destinationFolder);

                ZipEntry theEntry;
                while ((theEntry = zinstream.GetNextEntry()) != null)
                {
                    string dirname = IO.Path.GetDirectoryName(theEntry.Name);
                    string fname = IO.Path.GetFileName(theEntry.Name);

                    if (FileName != fname) continue;

                    string target = destinationFolder + IO.Path.DirectorySeparatorChar + dirname;
                    if (dirname.Length > 0 && !IO.Directory.Exists(target))
                        IO.Directory.CreateDirectory(target);

                    if (fname != String.Empty)
                    {
                        DecompressAndWriteFile(destinationFolder + IO.Path.DirectorySeparatorChar + theEntry.Name, zinstream);
                        numFileUnzipped++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                zinstream.Close();
            }
        }

        private static void DecompressAndWriteFile(string destination, ZipInputStream source)
        {
            IO.FileStream wstream = null;
            try
            {
                wstream = IO.File.Create(destination);
                const int block = 2048;
                byte[] data = new byte[block];
                while (true)
                {
                    int size = source.Read(data, 0, data.Length);

                    if (size > 0)
                        wstream.Write(data, 0, size);
                    else
                        break;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (wstream != null)
                    wstream.Close();
            }
        }
    }
}