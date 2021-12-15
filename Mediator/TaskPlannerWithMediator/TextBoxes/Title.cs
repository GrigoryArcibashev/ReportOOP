using System;
using System.Windows.Forms;
using Mediator.Interfaces;

namespace Mediator.TextBoxes
{
    public sealed class Title : TextBox, IComponent
    {
        private IMediator _mediator;

        public Title()
        {
            Multiline = true;
            ScrollBars = ScrollBars.None;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public bool IsEmpty()
        {
            return Text == string.Empty;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            _mediator.Notify(this, "ChangeTitle");
        }
    }
}