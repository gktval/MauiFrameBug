namespace MauiAppFrameBug
{
    public partial class MainPage : ContentPage
    {
        public List<MyListModel> ItemSource { get; set; }
        public MyListModel SelectedItem { get; set; }

        public MainPage()
        {
            InitializeComponent();

            ItemSource =
            [
                new MyListModel("this", 123),
                new MyListModel("that", 456),
                new MyListModel("then some", 789),
            ];

            BindingContext = this;
        }


    }


    public class MyListModel
    {
        public MyListModel(string v1, int v2)
        {
            Name = v1;
            Value = v2;
        }

        public string Name { get; set; }
        public int Value { get; set; }

    }
}
