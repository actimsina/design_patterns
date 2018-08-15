using System;

namespace observer
{
    public class MyTopicObserver : IObserver
    {
        private string receivedMsg;
        private ISubject topic;

        public MyTopicObserver(ISubject subject)
        {
            this.topic = subject;
        }


        public void update()
        {
            this.receivedMsg = topic.getMessage();
            Console.WriteLine(receivedMsg);
        }
    }
}