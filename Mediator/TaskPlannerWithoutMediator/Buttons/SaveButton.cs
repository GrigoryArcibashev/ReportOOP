using System;
using System.Windows.Forms;
using TaskPlannerWithoutMediator.TextBoxes;

namespace TaskPlannerWithoutMediator.Buttons
{
    public sealed class SaveButton : Button
    {
        // Сильное сопряжение 💩
        private TaskList _taskList;
        private Title _title;
        private Text _text;

        public SaveButton(TaskList taskList, Title title, Text text)
        {
            _taskList = taskList;
            _title = title;
            // сопряжение
            _title.TextChanged += (_, _) => UpdateDisplayOfSaveButton();
            _text = text;
            // сопряжение
            _text.TextChanged += (_, _) => UpdateDisplayOfSaveButton();
            Text = "Save";
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _taskList.UpdateSelected(new Note(_title.Text, _text.Text));
        }

        private void UpdateDisplayOfSaveButton()
        {
            if (_title.IsEmpty() || _taskList.IsEmpty())
                Hide();
            else
                Show();
        }
    }
}