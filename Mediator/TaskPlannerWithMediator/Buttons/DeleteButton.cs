using System;
using System.Windows.Forms;
using Mediator.Interfaces;

namespace Mediator.Buttons
{
    public sealed class DeleteButton : Button, IComponent
    {
        private IMediator _mediator;

        public DeleteButton()
        {
            Text = "Delete";
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _mediator.Notify(this);
        }
    }
}