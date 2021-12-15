using Mediator.Buttons;
using Mediator.Interfaces;
using Mediator.TextBoxes;

namespace Mediator
{
    public class TaskPlanner : IMediator
    {
        private Title _title;
        private Text _text;
        private DeleteButton _deleteButton;
        private SaveButton _saveButton;
        private TaskList _taskList;

        public void RegisterComponent(IComponent component)
        {
            component.SetMediator(this);
            switch (component)
            {
                case DeleteButton button:
                    _deleteButton = button;
                    _deleteButton.Hide();
                    break;
                case TaskList list:
                    _taskList = list;
                    break;
                case SaveButton button:
                    _saveButton = button;
                    _saveButton.Hide();
                    break;
                case Text text:
                    _text = text;
                    break;
                case Title title:
                    _title = title;
                    break;
            }
        }

        public void Notify(IComponent sender, string ev)
        {
            switch (sender)
            {
                case AddButton:
                    _taskList.Add(new Note());
                    break;
                case DeleteButton:
                    DeleteNote();
                    break;
                case SaveButton:
                    _taskList.UpdateSelected(new Note(_title.Text, _text.Text));
                    break;
                case Title:
                case Text:
                    UpdateDisplayOfSaveButton();
                    break;
                case TaskList:
                    SelectNote();
                    break;
            }
        }

        private void UpdateDisplayOfSaveButton()
        {
            if (_title.IsEmpty() || _taskList.IsEmpty())
                _saveButton.Hide();
            else
                _saveButton.Show();
        }

        private void SelectNote()
        {
            var note = _taskList.GetCurrentNote();
            if (note != null)
            {
                _title.Text = note.Title;
                _text.Text = note.Text;
                _deleteButton.Show();
            }
            else
                _deleteButton.Hide();
        }

        private void DeleteNote()
        {
            _taskList.Delete();
            _title.Clear();
            _text.Clear();
            _saveButton.Hide();
        }
    }
}