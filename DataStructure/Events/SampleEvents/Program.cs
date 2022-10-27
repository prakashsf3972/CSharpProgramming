using System;
namespace SampleEvents;
class Program
{
    public static void Main(string[] args)
    {
        Event event1=new Event("Quiz");
        Event event2=new Event("Debugging");
        Event event3=new Event("Presentation");
        Event event4=new Event("Games");

        //Subscribe to events -Example -Event Registration by ManageMent
        Event.eventlink+=new EventManager(event1.StartsEvent);
        Event.eventlink+=new EventManager(event2.StartsEvent);
        Event.eventlink+=new EventManager(event3.StartsEvent);
        Event.eventlink+=new EventManager(event4.StartsEvent);
        //Event delegates assigned with Methods

        //Process triggering to Start Events
        Event.HandleEvent();
        //Event cancellation/Degistration -Unsubcribe from Event
        Event.eventlink-=new EventManager(event4.StartsEvent);
        Event.HandleEvent();


    }
}
