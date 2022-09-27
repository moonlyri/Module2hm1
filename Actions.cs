using System;
namespace Module2HM1
{
    public class Actions
    {
        private Logger _logger = Logger.GetInstance();
        public Result Method1()
        {
            var item = new LogItem(DateTime.Now, "Start method: Method1", LogType.Info);
            _logger.Log(item);
            return new Result(true);
        }

        public Result Method2()
        {
            var item = new LogItem(DateTime.Now, "Skipped logic in method: Method2", LogType.Warning);
            _logger.Log(item);
            return new Result(true);
        }

        public Result Method3()
        {
            var item = new LogItem(DateTime.Now, "I broke a logic", LogType.Error);
            _logger.Log(item);
            return new Result(false);
        }

    }
}

