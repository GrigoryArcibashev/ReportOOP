using System;
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

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }
    }
}