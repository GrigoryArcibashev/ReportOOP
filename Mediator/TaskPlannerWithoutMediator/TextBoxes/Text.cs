using System.Windows.Forms;

namespace TaskPlannerWithoutMediator.TextBoxes
{
    public sealed class Text : TextBox
    {
        public Text()
        {
            Multiline = true;
            WordWrap = true;
            ScrollBars = ScrollBars.Vertical;
        }
    }
}