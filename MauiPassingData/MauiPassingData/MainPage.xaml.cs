namespace MauiPassingData
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(numValOne.Text) && !string.IsNullOrEmpty(numValTwo.Text))
            {
                Navigation.PushAsync(new SumPage(int.Parse(numValOne.Text), int.Parse(numValTwo.Text), "add"));
            } else
            {
                errLabel.Text = "Please enter values in both fields.";
            }
        }

        private void OnSubtractClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(numValOne.Text) && !string.IsNullOrEmpty(numValTwo.Text))
            {
                Navigation.PushAsync(new SumPage(int.Parse(numValOne.Text), int.Parse(numValTwo.Text), "sub"));
            }
            else
            {
                errLabel.Text = "Please enter values in both fields.";
            }
        }
    }
}
