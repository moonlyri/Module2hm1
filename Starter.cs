using System;
using System.Text;

namespace Module2HM1
{
    public class Starter
    {
        public void Run()
        {
            var actions = new Actions();

            for (int i = 0; i < 100; i++)
            {
                int numder = new Random().Next(1, 4);
                Result result = null;

                switch (numder)
                {
                    case 1:
                        result = actions.Method1();
                        break;
                    case 2:
                        result = actions.Method2();
                        break;
                    case 3:
                        result = actions.Method3();
                        break;
                }
                if (result != null && !result.Status)
                {
                    var item = new LogItem(DateTime.Now, "Action failed by a reason: status = false", LogType.Error);
                    Logger.GetInstance().Log(item);
                }
            }
            
            var text = new StringBuilder();
            var current = Logger.GetInstance().Storage;
            while (current != null)
            {
                text.AppendLine(current.time.ToShortTimeString+ " Type:" + current.Type + " Message" + current.Message);

                current = current.Next;
            }

            File.WriteAllText("log.txt", text.ToString());
        }
    }
}

