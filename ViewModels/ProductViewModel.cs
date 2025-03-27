using Hardware_Management_System.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Hardware_Management_System.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        // Properties
        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get => _products;
            set { _products = value; OnPropertyChanged(); }
        }

        private string _selectedCategory;
        public string SelectedCategory
        {
            get => _selectedCategory;
            set { _selectedCategory = value; OnPropertyChanged(); }
        }

        public List<string> Categories { get; } = new() { "Cement", "Steel Rods", "Paint" };

        // Commands
        public ICommand SaveProductCommand { get; }

        public ProductViewModel()
        {
            SaveProductCommand = new RelayCommand(SaveProduct);
            LoadProducts();
        }

        private void SaveProduct(object parameter)
        {
            // Add your save logic here
        }

        private void LoadProducts()
        {
            // Load products from the database
        }

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}