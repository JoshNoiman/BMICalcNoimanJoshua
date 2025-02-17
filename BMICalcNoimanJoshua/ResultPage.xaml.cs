namespace BMICalcNoimanJoshua;

public partial class ResultPage : ContentPage
{
    double bmi;
    string choice;
    public ResultPage(double bmi, string choice)
	{
		InitializeComponent();
        LblBMI.Text = bmi.ToString();
        this.bmi = bmi;
        this.choice = choice;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RecomPage(bmi, choice));
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BMICalcPage());
    }
}