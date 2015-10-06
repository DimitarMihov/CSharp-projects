namespace ResearchAndUseTools
{
    using System.IO;
    
    using log4net;
    using log4net.Appender;
    using log4net.Config;
    using log4net.Core;
    using log4net.Layout;

    internal class LogForNetExample
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        internal class AnotherClass
        {
            public AnotherClass(ILog logger)
            {
                logger.Debug("Call from class AnotherClass");
            }
        }
        
        internal static void Main()
        {
            var fileAppender = new FileAppender();
            fileAppender.File = "log.txt";
            fileAppender.AppendToFile = true;
            fileAppender.Layout = new SimpleLayout();
            fileAppender.Threshold = Level.All;
            fileAppender.ActivateOptions();
            
            BasicConfigurator.Configure(fileAppender);

            var anotherClass = new AnotherClass(Log);
            
            Log.Error("error");
            Log.Warn("warning");
            Log.Info("info");

            try
            {
                File.ReadAllLines(@"C:\fakeFile.txt");
            }
            catch (FileNotFoundException ex)
            {
                Log.Fatal(ex);
            }
        }
    }
}
