using System;


namespace CustomEvent
{
    class NewPerson
    {
        private readonly string userid;
        public NewPerson(string userid, Raising publisher)
        {
            this.userid = userid;
            publisher.RaiseEvent += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender, MeetingEvent e)
        {
            Console.WriteLine(userid + " received message: " + e.Message);
        }
    }
}
