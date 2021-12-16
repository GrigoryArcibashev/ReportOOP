using System;
using System.Windows.Forms;
using Mediator.Interfaces;

namespace Mediator.TextBoxes
{
    public sealed class Text : TextBox, IComponent
    {
        private IMediator _mediator;

        public Text()
        {
            Multiline = true;
            WordWrap = true;
            ScrollBars = ScrollBars.Vertical;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            _mediator.Notify(this);
        }
    }
}