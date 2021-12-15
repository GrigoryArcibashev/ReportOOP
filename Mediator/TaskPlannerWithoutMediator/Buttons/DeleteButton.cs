using System;
using System.Windows.Forms;

namespace TaskPlannerWithoutMediator.Buttons
{
    public sealed class DeleteButton : Button
    {
        public DeleteButton()
        {
            Text = "Delete";
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }
}