namespace MauiPassingData;

public partial class SumPage : ContentPage
{
	public SumPage(int valA, int valB, string func)
	{
		InitializeComponent();
		numLabel.Text = $"The values entered are {valA} and {valB}.";

        if (func == "add")
		{
			sumLabel.Text = $"{valA + valB}";
		} else if(func == "sub")
		{
			sumLabel.Text = $"{valA - valB}";
        }
    }

	private void OnGoBackClicked(object sender, EventArgs e)
	{
		Navigation.PopAsync();
    }
}