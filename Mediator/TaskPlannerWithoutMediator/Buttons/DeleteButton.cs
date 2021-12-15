using System;
using System.Windows.Forms;
using TaskPlannerWithoutMediator.TextBoxes;

namespace TaskPlannerWithoutMediator.Buttons
{
    public sealed class DeleteButton : Button
    {
        // Сильное сопряжение 💩
        private TaskList _taskList;
        private Title _title;
        private Text _text;
        private SaveButton _saveButton;

        public DeleteButton(TaskList taskList, Title title, Text text, SaveButton saveButton)
        {
            _taskList = taskList;
            // сопряжение
            _taskList.SelectedIndexChanged += (_, _) => SelectNote();
            _title = title;
            _text = text;
            _saveButton = saveButton;
            Text = "Delete";
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _taskList.Delete();
            _title.Clear();
            _text.Clear();
            _saveButton.Hide();
            Hide();
        }
        
        private void SelectNote()
        {
            var note = _taskList.GetCurrentNote();
            if (note != null)
            {
                _title.Text = note.Title;
                _text.Text = note.Text;
                Show();
            }
            else
                Hide();
        }
    }
}