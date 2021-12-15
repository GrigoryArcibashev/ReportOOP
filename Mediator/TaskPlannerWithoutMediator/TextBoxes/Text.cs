using System;
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

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }
    }
}