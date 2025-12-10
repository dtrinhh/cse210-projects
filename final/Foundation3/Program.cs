using System;

class Program
{
    static void Main(string[] args)
    {
        // Lecture Event
        string eventTitle = "Coding for Fun";
        string eventDescription = "Learn how coding is a way to be creative, innovative, and able to provide you with a fun time! ";
        string eventDate = "December 20th, 2025";
        string eventType = "Lecture";
        string eventTime = "12pm MST";
        Address eventAddress = new Address("12345 Happy ln, Rexburg, ID 83441");
        int maxCapacity = 100;
        int currentCapacity = 79;
        string speakerName = "Bill Gates";


        Event event1 = new Event(eventTitle, eventDescription, eventDate, eventType, eventTime, eventAddress.Getaddress());

        // Displays Standard Details, Full Details, and Short Description of lectureEvent when the specific event instance is called. (Would be easy to separate)
        LectureEvent lectureEvent = new LectureEvent(eventTitle, eventDescription, eventDate, eventType, eventTime, eventAddress.Getaddress(), maxCapacity, currentCapacity, speakerName);

        // Reception Event
        eventTitle = "Travis and Taylor Wedding Reception";
        eventDescription = "We're getting married, come celebrate with some food and drinks! ";
        eventDate = "March 12th, 2026";
        eventType = "Reception";
        eventTime = "2pm MST";
        eventAddress = new Address("143 Love rd, Rexburg, ID 83440");
        string emailRSVP = "If you'd like to celebrate with us on our new marriage, please RSVP so we can ensure we have enough food and drinks! ";
        int confirmedRSVP = 60;

        // Displays Standard Details, Full Details, and Short Description of receptionEvent when the specific event instance is called. (Would be easy to separate)
        ReceptionEvent receptionEvent = new ReceptionEvent(eventTitle, eventDescription, eventDate, eventType, eventTime, eventAddress.Getaddress(), emailRSVP, confirmedRSVP);

        // Outdoor Event
        eventTitle = "Spartan Race";
        eventDescription = "Who's gonna carry the boats?! You are! Join us on a obstacle course race and test your toughness!  ";
        eventDate = "June, 10th 2026";
        eventType = "Outdoor Event";
        eventTime = "7am MST";
        eventAddress = new Address("789 Toughness st, Rexburg, ID 83449");
        string weatherForecast = "Sunny H:77 degrees L:63 degress ";

        // Displays Standard Details, Full Details, and Short Description of receptionEvent when the specific event instance is called. (Would be easy to separate)
        OutdoorEvent outdoorEvent = new OutdoorEvent(eventTitle, eventDescription, eventDate, eventType, eventTime, eventAddress.Getaddress(), weatherForecast);
    }
}