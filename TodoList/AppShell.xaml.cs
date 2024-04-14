using TodoList.Pages;

namespace TodoList
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ToDoPage), typeof(ToDoPage));
            Routing.RegisterRoute(nameof(RegistroTareaPage), typeof(RegistroTareaPage));
            Routing.RegisterRoute(nameof(RegistroEncuestaPage), typeof(RegistroEncuestaPage));
        }
    }
}
