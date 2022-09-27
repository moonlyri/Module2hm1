using System;
namespace Module2HM1
{
    public class Result
    {
        private bool _status;

        public bool Status
        {
            get { return _status; }
        }
        public Result (bool status)
        {
            _status = status;
        }
    }
}

