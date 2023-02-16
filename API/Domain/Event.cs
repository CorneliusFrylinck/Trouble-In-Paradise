namespace API.Domain
{
    /// <summary>
    /// Events are used to track occurences.
    /// </summary>
    public class Event
    {
        public int Id { get; set; }

        /// <summary>
        /// The event occurence.
        /// </summary>
        public EventTypeEnum EventType { get; set; }

        /// <summary>
        /// The id of the related occurence.
        /// </summary>
        public int RelatedId { get; set; }

        /// <summary>
        /// The date and time the event occured.
        /// </summary>
        public DateTime EventOccurrence {get; set;}
    }
}
