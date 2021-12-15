using System;
using System.Windows.Forms;
using Mediator.Interfaces;

namespace Mediator.Buttons
{
    public sealed class SaveButton : Button, IComponent
    {
        private IMediator _mediator;

        public SaveButton()
        {
            Text = "Save";
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _mediator.Notify(this, "SaveNote");
        }
    }
}