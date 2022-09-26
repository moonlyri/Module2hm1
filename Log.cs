using System;
namespace Module2HM1
{
    public class Log
    {
        private string _message;
        private LogType _type;
        public string Message
        {
            get { return _message; }
        }
        public LogType Type
        {
            get { return _type; }
        }
        public LogItem(string message, LogType type)
        {
            _message = message;
            _type = type;
        }
    }
}

