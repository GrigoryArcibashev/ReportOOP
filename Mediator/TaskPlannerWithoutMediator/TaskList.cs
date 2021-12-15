using System;
using System.Windows.Forms;

namespace TaskPlannerWithoutMediator
{
    public class TaskList : ListBox
    {
        public TaskList()
        {
            HorizontalScrollbar = true;
        }

        public void Add(Note note)
        {
            Items.Add(note);
        }

        public void Delete()
        {
            if (SelectedIndex < 0) return;
            Items.RemoveAt(SelectedIndex);
        }

        public Note GetCurrentNote()
        {
            if (SelectedIndex < 0)
                return null;
            return (Note)Items[SelectedIndex];
        }

        public void UpdateSelected(Note note)
        {
            if (SelectedIndex < 0) return;
            ((Note)SelectedItem).Text = note.Text;
            ((Note)SelectedItem).Title = note.Title;
            Items[SelectedIndex] = SelectedItem;
        }

        public bool IsEmpty()
        {
            return Items.Count == 0;
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
        }
    }
}