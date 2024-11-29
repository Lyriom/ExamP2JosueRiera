namespace ExamP2JosueRiera
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void IrStack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EXAMP2.StackLayoutPage());
        }


    }

}
