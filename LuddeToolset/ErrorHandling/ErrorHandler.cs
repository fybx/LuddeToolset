/*
 *         LuddeToolset.ErrorHandler
 * 
 *         LuddeToolset by fybalaban @ 2020
 *         https://www.github.com/fybalaban
 *         https://www.instagram.com/ferityigitbalaban/
 *         https://www.twitter.com/fybalaban/
 *         https://fybalaban.github.io/website/
 */

using System;
using System.Windows.Forms;

namespace LuddeToolset
{
    /// <summary>
    /// Handle errors in a better way with ErrorHandler. Create one instance of this, do generic error handling or write your own handler.
    /// </summary>
    public class ErrorHandler
    {
        /// <summary>
        /// Directory to save error messages.
        /// </summary>
        public string ErrorFileOutputDirectory { get; }
        /// <summary>
        /// Application-specific message to add to error messages.
        /// </summary>
        public string SpecialMessage { get; }
        /// <summary>
        /// If true, uses generic error handling method to handle exceptions. If false developer needs to override LuddeToolset.ErrorHandler.Handle with their handler method.
        /// </summary>
        public bool DoGenericErrorHandling { get; }

        public bool UseDefaultMessageBox { get; }

        /// <summary>
        /// Class initialization.
        /// </summary>
        /// <param name="outputDirectory">Directory to save error messages</param>
        /// <param name="message">Application-specific message to add to error messages</param>
        /// <param name="doGenericErrorHandling">If true, uses generic error handling method to handle exceptions, if false developer needs to override LuddeToolset.ErrorHandler.Handle with their handler method</param>
        public ErrorHandler(string outputDirectory, string message, bool doGenericErrorHandling = true)
        {
            ErrorFileOutputDirectory = outputDirectory;
            SpecialMessage = message;
            DoGenericErrorHandling = doGenericErrorHandling;
        }

        /// <summary>
        /// This method is for handling exceptions. If DoGenericErrorHandling is set to false, override this with your method to do another task.
        /// </summary>
        /// <param name="exception"></param>
        public virtual void Handle(Exception exception)
        {
            if (DoGenericErrorHandling == true)
            {
                IO.CreateAndWriteErrorMessage(ErrorFileOutputDirectory, exception, SpecialMessage);
                MessageBox.Show($"An error has occured!\nError log is saved in {ErrorFileOutputDirectory}.\n\n\nLuddeToolset ErrorHandler", SpecialMessage);
            }
        }
    }
}