using System;
using System.Windows.Forms;

namespace TaskPlannerWithoutMediator.Buttons
{
    public sealed class AddButton : Button
    {
        // Сопряжение
        private readonly TaskList _taskList;

        public AddButton(TaskList taskList)
        {
            _taskList = taskList;
            Text = "Add";
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _taskList.Add(new Note());
        }
    }
}