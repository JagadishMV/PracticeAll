using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPropertyInjection
{
    //  https://www.c-sharpcorner.com/UploadFile/85ed7a/dependency-injection-in-C-Sharp/

    //  -------------------
    //  Property Injection
    //  -------------------

    //  We use constructor injection, but there are some cases where I need a parameter-less constructor 
    //  so we need to use property injection.


    public interface INotificationAction
    {
        void ActOnNotification(string message);
    }

    class atul
    {
        INotificationAction task = null;

        public void nofity(INotificationAction at, string messages)
        {
            this.task = at;
            task.ActOnNotification(messages);
        }
    }

    class EventLogWriter : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            // Write to event log here
            WriteLogToFiile(DateTime.Now.ToString() + "\t\t" + message);
        }

        private void WriteLogToFiile(string message)
        {
            FileStream objFilestream = new FileStream(string.Format("{0}\\{1}", Path.GetTempPath(), "LogFile.txt"), FileMode.Append, FileAccess.Write);
            StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
            objStreamWriter.WriteLine(message);
            objStreamWriter.Close();
            objFilestream.Close();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            EventLogWriter elw = new EventLogWriter();
            atul at = new atul();
            at.nofity(elw, "The log is writing...!");
            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
