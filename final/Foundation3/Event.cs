namespace Event;
using System;
using System.Diagnostics;

public class Event
{
    private string _gatheringLocation;
    private string _gatheringName;
    private string _topic;

    public Event(string gatheringLocation, string topic)
    {
        _gatheringLocation = gatheringLocation;
        _topic = topic;
    }

    
    public string GetGatheringName()
    {
        return _gatheringLocation;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _gatheringName + " - " + _topic;
 
   }
}