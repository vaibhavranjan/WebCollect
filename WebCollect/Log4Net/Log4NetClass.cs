using log4net.Appender;
using log4net.Layout;
using log4net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using log4net;

namespace WebCollect.Log4Net
{
    public class Log4NetClass
    {
        public static void ConsoleAppenderLog()
        {
            // 1st step - To create layout
            // 2nd step - To use layout in appender
            // 3rd step - To initialize configuration
            // 4th step - To get the instance of logger

            #region layout creation
            var layout = new PatternLayout();
            layout.ConversionPattern = "%date{ABSOLUTE} [%class] [%level] [%method] - %message%newline";
            layout.ActivateOptions();
            #endregion

            #region appender creation
            var consoleAppender = new ConsoleAppender()
            {
                Name = "consoleAppender",
                Layout = layout,
                Threshold = Level.All
            };
            consoleAppender.ActivateOptions();
            #endregion

            #region Init config
            BasicConfigurator.Configure(consoleAppender);
            ILog logger = LogManager.GetLogger(typeof(Log4NetClass));
            logger.Debug("this is debug information");
            logger.Info("this is Info information");
            logger.Warn("this is Warn information");
            logger.Error("this is Error information");
            logger.Fatal("this is Fatal information");
            #endregion

        }
    }
}
