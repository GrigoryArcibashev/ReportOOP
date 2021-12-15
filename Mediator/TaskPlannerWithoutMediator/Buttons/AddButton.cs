using System;
using System.Windows.Forms;

namespace TaskPlannerWithoutMediator.Buttons
{
    public sealed class AddButton : Button
    {
        public AddButton()
        {
            Text = "Add";
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }
}