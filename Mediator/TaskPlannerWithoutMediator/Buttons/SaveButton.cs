using System;
using System.Windows.Forms;

namespace TaskPlannerWithoutMediator.Buttons
{
    public sealed class SaveButton : Button
    {
        public SaveButton()
        {
            Text = "Save";
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }
}