namespace BMICalcNoimanJoshua;

public partial class RecomPage : ContentPage
{
    double bmi;
    string choice;
	public RecomPage(double bmi, string choice)
	{
		InitializeComponent();
        this.bmi = bmi;
        this.choice = choice;
        

        if (choice == "Male")
        {
            if (bmi < 18.5)
            {
                DisplayAlert ("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
                              "HealhStatus: Underweight" +
                              "\nRecommendations: Increase calorie intake with nutrient-rich foods" +
                              "(e.g., nuts, lean protein, whole grains). Incorporate strength" +
                              "training to build muscle mass. Consult a nutritionist if needed.", "OK");
            }
            if (bmi >= 18.5 && bmi < 25)
            {
                DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
                              "HealhStatus: Normal Weight" +
                              "\nRecommendations: Maintain a balanced diet with proteins, healthy fats, and fiber. " +
                              "Stay physically active with at least 150 minutes of exercise per week. " +
                              "Keep regular check-ups to monitor overall health ", "OK");
            }
            if (bmi >= 25 && bmi < 30)
            {
                DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
                              "HealhStatus: Overweight" +
                              "\nRecommendations: Reduce processed foods and focus on portion control. " +
                              "Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. " +
                              "Drink plenty of water and track your progress ", "OK");
            }
            if (bmi > 30)
            {
                DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
                              "HealhStatus: Obese" +
                              "\nRecommendations: Consult a doctor for personalized guidance. " +
                              "Start with low impact exercises (e.g., waling, cycling). " +
                              "Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes." +
                              "Avoid sugary drinks and maintain a consistent sleep schedule ", "OK");
            }
        }
        if (choice == "Female")
        {
            if (bmi < 18)
            {
                DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
                              "HealhStatus: Underweight" +
                              "\nRecommendations: Increase clorie intake with nutrient-rich foods" +
                              "(e.g., nuts, lean protein, whole grains). Incorporate strength" +
                              "training to build muscle mass. Consult a nutritionist if needed.", "OK");
            }
            if (bmi >= 18 && bmi < 24)
            {
                DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
                              "HealhStatus: Normal Weight" +
                              "\nRecommendations: Maintain a balanced diet with proteins, healthy fats, and fiber. " +
                              "Stay physically active with at least 150 minutes of exercise per week. " +
                              "Keep regular check-ups to monitor overall health ", "OK");
            }
            if (bmi >= 24 && bmi < 29)
            {
                DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
                              "HealhStatus: Overweight" +
                              "\nRecommendations: Reduce processed foods and focus on portion control. " +
                              "Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. " +
                              "Drink plenty of water and track your progress ", "OK");
            }
            if (bmi > 29)
            {
                DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
                              "HealhStatus: Obese" +
                              "\nRecommendations: Consult a doctor for personalized guidance. " +
                              "Start with low impact exercises (e.g., waling, cycling). " +
                              "Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. " +
                              "Avoid sugary drinks and maintain a consistent sleep schedule ", "OK");
            }
        }

    }
    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ResultPage(bmi, choice));
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BMICalcPage());
    }
}