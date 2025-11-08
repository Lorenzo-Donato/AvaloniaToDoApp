using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using ToDoApp.Models;
using ToDoApp.ViewModels;

namespace ToDoApp.ViewModels
{
    public partial class ToDoItemViewModel : ViewModelBase
    {
        [ObservableProperty]
        private bool _isChecked;

        [ObservableProperty]
        private string? _content;


        public ToDoItemViewModel()
        {

        }


        public ToDoItemViewModel(ToDoItem item)
        {
            IsChecked = item.IsChecked;
            Content = item.Content;
        }


        public ToDoItem GetToDoItem()
        {
            return new ToDoItem()
            {
                IsChecked = this.IsChecked,
                Content = this.Content
            };
        }



    }





}



