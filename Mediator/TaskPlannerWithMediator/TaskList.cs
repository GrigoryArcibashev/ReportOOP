using System;
using System.Windows.Forms;
using Mediator.Interfaces;

namespace Mediator
{
    public class TaskList : ListBox, IComponent
    {
        private IMediator _mediator;

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

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            _mediator.Notify(this);
        }
    }
}