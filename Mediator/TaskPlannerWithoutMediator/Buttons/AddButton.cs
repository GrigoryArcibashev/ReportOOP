using System.Windows.Forms;

namespace TaskPlannerWithoutMediator.Buttons
{
    public sealed class AddButton : Button
    {
        public AddButton(TaskList taskList)
        {
            Text = "Add";
            // Сопряжение
            Click += (_, _) => taskList.Add(new Note());
        }
    }
}