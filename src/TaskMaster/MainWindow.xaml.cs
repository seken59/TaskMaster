using System.Collections.ObjectModel;
using System.Windows;
using TaskMaster.Models;

namespace TaskMaster
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<TaskItem> tasks = new ObservableCollection<TaskItem>();

        public MainWindow()
        {
            InitializeComponent();
            TasksListView.ItemsSource = tasks;
            // TODO: Load tasks from persistent storage
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var text = NewTaskTextBox.Text?.Trim();
            if (string.IsNullOrEmpty(text)) return;

            var t = new TaskItem { Title = text };
            tasks.Add(t);
            NewTaskTextBox.Text = string.Empty;

            // TODO: Save tasks to persistent storage
        }
    }
}