namespace SampleEvents
{
    public delegate void EventManager();//User Defined delegate
    public class Event
    {
        private string _eventName;
        public static event EventManager eventlink;//User defined Event
        static int i;
        public Event(string eventName)
        {
            _eventName=eventName;
        }
        public static void HandleEvent()//Event triggering method
        {
            i=0;
            System.Console.WriteLine("User Registration");
            System.Console.WriteLine("Starting the Following Events");
            eventlink();//Event trigger ->like clicking a button
        }
        public void StartsEvent()//Explanation about the button click action
        {
            ++i;
            System.Console.WriteLine("Event no:"+i+"is:"+_eventName+"started");
        }

    }
}