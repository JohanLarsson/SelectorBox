namespace SelectorBox
{
    public class Event
    {
        public Event(Severity severity, string text)
        {
            Severity = severity;
            Text = text;
        }

        public Severity Severity { get; private set; }

        public string Text { get; private set; }
    }
}
