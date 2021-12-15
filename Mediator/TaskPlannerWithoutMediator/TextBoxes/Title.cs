using System.Windows.Forms;

namespace TaskPlannerWithoutMediator.TextBoxes
{
    public sealed class Title : TextBox
    {
        public Title()
        {
            Multiline = true;
            ScrollBars = ScrollBars.None;
        }

        public bool IsEmpty()
        {
            return Text == string.Empty;
        }
    }
}