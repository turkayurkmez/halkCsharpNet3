namespace EventMechanism
{

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CategoryEventArgs : EventArgs
    {
        public Category Category { get; set; }
        public DateTime EventTime { get; set; }
        public string User { get; set; }
    }
    public class CategoryService
    {
        //public delegate void CategoryAddedEventHandler(object sender, CategoryEventArgs e);

        public event EventHandler<CategoryEventArgs> CategoryAdded;
        public void AddCategory(Category category)
        {
            //farz edin ki db'ye eklediniz...
            CategoryEventArgs categoryEventArgs = new CategoryEventArgs { Category = category, User = "türkay", EventTime = DateTime.Now };
            OnCategoryAdded(categoryEventArgs);

        }

        public void OnCategoryAdded(CategoryEventArgs args)
        {
            if (CategoryAdded != null)
            {
                CategoryAdded(this, args);
            }
        }
    }
}
