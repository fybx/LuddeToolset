/*
 *         LuddeToolset.IO
 * 
 *         LuddeToolset by ferityigitbalaban @ 2020
 *         https://www.github.com/fybalaban
 *         https://www.instagram.com/ferityigitbalaban/
 *         https://www.twitter.com/fybalaban/
 *         https://fybalaban.github.io/website/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LuddeToolset
{
    /// <summary>
    /// Methods for IO and File System operations.
    /// </summary>
    public static class IO
    {
        /// <summary>
        /// Opens and reads lines of a file, returns list object containing lines. Suppresses errors. Not safe.
        /// </summary>
        /// <param name="fromFilePath">Path of file</param>
        /// <returns>Returns true if operation is executed without any errors.</returns>
        public static bool ReadLinesFromFile(string fromFilePath, out IEnumerable<string> content)
        {
            if (!fromFilePath.Valid())
            {
                throw new ArgumentNullException(nameof(fromFilePath));
            }

            content = null;
            try
            {
                content = File.ReadAllLines(fromFilePath).ToList();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Opens and reads lines of a file, returns list object containing lines. Handles errors. Safe.
        /// </summary>
        /// <param name="fromFilePath">Path of file</param>
        /// <param name="handler">Handler object to handle errors.</param>
        /// <returns>Returns true if operation is executed without any errors.</returns>
        public static bool ReadLinesFromFile(string fromFilePath, ErrorHandler handler, out IEnumerable<string> content)
        {
            if (!fromFilePath.Valid())
            {
                handler.Handle(new ArgumentNullException(nameof(fromFilePath)));
            }

            content = null;
            try
            {
                content = File.ReadAllLines(fromFilePath).ToList();
            }
            catch (Exception exception)
            {
                handler.Handle(exception);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Writes all elements in List object, treating them as lines. Suppresses errors. Not safe. 
        /// </summary>
        /// <param name="writeTheseLines">List containing lines</param>
        /// <param name="toFilePath">Path of file to write</param>
        /// <returns>Returns true if operation is executed without any errors.</returns>
        public static bool WriteLinesToFile(IEnumerable<string> writeTheseLines, string toFilePath)
        {
            if (!toFilePath.Valid())
            {
                throw new ArgumentNullException(nameof(toFilePath));
            }
            if (writeTheseLines is null)
            {
                throw new ArgumentNullException(nameof(writeTheseLines));
            }
            if (writeTheseLines.Count() is 0)
            {
                throw new ArgumentOutOfRangeException(nameof(writeTheseLines));
            }

            try
            {
                File.WriteAllLines(toFilePath, writeTheseLines.ToArray());
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Writes all elements in List object, treating them as lines. Handles errors. Safe. 
        /// </summary>
        /// <param name="writeTheseLines">List containing lines</param>
        /// <param name="toFilePath">Path of file to write</param>
        /// <param name="handler">Handler object</param>
        /// <returns>Returns true if operation is executed without any errors.</returns>
        public static bool WriteLinesToFile(IEnumerable<string> writeTheseLines, string toFilePath, ErrorHandler handler)
        {
            if (!toFilePath.Valid())
            {
                handler.Handle(new ArgumentNullException(nameof(toFilePath)));
            }
            if (writeTheseLines is null)
            {
                handler.Handle(new ArgumentNullException(nameof(writeTheseLines)));
            }
            if (writeTheseLines.Count() is 0)
            {
                handler.Handle(new ArgumentOutOfRangeException(nameof(writeTheseLines)));
            }

            try
            {
                File.WriteAllLines(toFilePath, writeTheseLines.ToArray());
            }
            catch (Exception exception)
            {
                handler.Handle(exception);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Returns the directory of file from its given full name path.
        /// </summary>
        /// <param name="path">A valid file path</param>
        /// <returns></returns>
        public static string ReturnDirectoryFromFullPath(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Argument 'path' is not a valid file path.", nameof(path));
            }
            return new FileInfo(path).Directory.FullName + @"\";
        }

        /// <summary>
        /// Returns only the name of file from its given full name path.
        /// </summary>
        /// <param name="path">A valid file path</param>
        /// <returns></returns>
        public static string ReturnNameFromFullPath(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Argument 'path' is not a valid file path.", nameof(path));
            }
            return new FileInfo(path).Name;
        }

        /// <summary>
        /// Creates a error log text out of an Exception object and saves it in the given directory. Safe.
        /// </summary>
        /// <param name="saveDirectory">Directory to save log. If does not exist, will be created.</param>
        /// <param name="exception">Exception describing the error.</param>
        /// <param name="applicationMessageLine">Special message for defining the application or the exception, supplied by developer. Default is empty.</param>
        public static void CreateAndWriteErrorMessage(string saveDirectory, Exception exception, string applicationMessageLine = @"")
        {
            if (Directory.Exists(saveDirectory) == false)
            {
                Directory.CreateDirectory(saveDirectory);
            }
            string errorLogPath = string.Format("error log({0}).txt", Text.GetDateTimeNow());
            string errorLogText = string.Format("{0}\r\nError occured at - {1}\r\n \r\nError message: {2}\r\nInner exception: {3}\r\n\r\nTarget site: {4}\r\n \r\nStack trace:\r\n{5}",
                applicationMessageLine, DateTime.Now, exception.Message, exception.InnerException, exception.TargetSite, exception.StackTrace);
            try
            {
                StreamWriter writer = new StreamWriter(errorLogPath);
                writer.Write(errorLogText);
                writer.Close();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Appends Environment.NewLine after every element in given list, appends every element to a string, returns the string.
        /// </summary>
        /// <param name="list">List containing lines.</param>
        /// <returns></returns>
        public static string LinesToString(IEnumerable<string> list)
        {
            if (list.Count() != 0)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < list.Count(); i++)
                {
                    builder.AppendFormat("{0}{1}", list.ElementAt(i), Environment.NewLine);
                }
                return builder.ToString();
            }
            return string.Empty;
        }

        /// <summary>
        /// Reads from supplied file. Suppresses error. Not safe.
        /// </summary>
        /// <param name="fromFilePath"></param>
        /// <returns>Returns true if operation is executed without any errors.</returns>
        public static bool ReadBytesFromFile(string fromFilePath, out byte[] content)
        {
            if (!fromFilePath.Valid())
            {
                throw new ArgumentNullException(nameof(fromFilePath));
            }

            content = null;
            try
            {
                content = File.ReadAllBytes(fromFilePath);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Writes supplied byte[] to supplied file. Supresses errors. Not safe.
        /// </summary>
        /// <param name="writeTheseBytes">Bytes to write</param>
        /// <param name="toFilePath">File to write to</param>
        /// <returns>Returns true if operation is executed without any errors.</returns>
        public static bool WriteBytesToFile(byte[] writeTheseBytes, string toFilePath)
        {
            if (!toFilePath.Valid())
            {
                throw new ArgumentNullException(nameof(toFilePath));
            }
            if (writeTheseBytes is null)
            {
                throw new ArgumentNullException(nameof(writeTheseBytes));
            }
            if (writeTheseBytes.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(writeTheseBytes));
            }

            try
            {
                File.WriteAllBytes(toFilePath, writeTheseBytes);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
