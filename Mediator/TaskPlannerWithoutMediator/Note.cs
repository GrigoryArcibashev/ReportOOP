namespace TaskPlannerWithoutMediator
{
    public class Note
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public Note(string title = "New note", string text = "")
        {
            Title = title;
            Text = text;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}