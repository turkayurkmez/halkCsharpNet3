using System.Collections.ObjectModel;

namespace EventMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            categoryService.CategoryAdded += CategoryService_CategoryAdded;


            Category category = new Category { Name = "Elektronik" };
            categoryService.AddCategory(category);

        }

        private void CategoryService_CategoryAdded(object sender, CategoryEventArgs e)
        {
            MessageBox.Show($"{e.Category.Name} isimli kategori, {e.User} tarafından {e.EventTime.ToString()} anında eklendi");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ObservableCollection<string> categories = new ObservableCollection<string>();
            categories.CollectionChanged += Categories_CollectionChanged;
        }

        private void Categories_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }
    }
}