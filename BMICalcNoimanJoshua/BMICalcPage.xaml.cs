
namespace BMICalcNoimanJoshua;

public partial class BMICalcPage : ContentPage
{
	public BMICalcPage()
	{
		InitializeComponent();
	}

    String choice = "Male";
    private void TapMale_Tapped(object sender, TappedEventArgs e)
    {
        choice = "Male";
        FrameMale.BorderColor = Color.FromArgb("#0ae29");
        FrameFemale.BorderColor = Color.FromArgb("#fdfdfd");
    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        choice = "Female";
        FrameMale.BorderColor = Color.FromArgb("#fdfdfd");
        FrameFemale.BorderColor = Color.FromArgb("#0ae29");
    }

    private void BtnCalculateBmi_Clicked(object sender, EventArgs e)
    {
        double height = double.Parse(LblHeight.Text);
        double weight = double.Parse(LblWeight.Text);
        double bmi = weight * 703 / (height * height);

        Navigation.PushAsync(new ResultPage(bmi, choice));


        //if (choice == "Male")
        //{
        //    if (bmi < 18.5)
        //    {
        //        DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
        //                      "HealhStatus: Underweight" +
        //                      "\nRecommendations: Increase calorie intake with nutrient-rich foods" +
        //                      "(e.g., nuts, lean protein, whole grains). Incorporate strength" +
        //                      "training to build muscle mass. Consult a nutritionist if needed.", "OK");
        //    }
        //    if (bmi >= 18.5 && bmi < 25 )
        //    {
        //        DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
        //                      "HealhStatus: Normal Weight" +
        //                      "\nRecommendations: Maintain a balanced diet with proteins, healthy fats, and fiber. " +
        //                      "Stay physically active with at least 150 minutes of exercise per week. " +
        //                      "Keep regular check-ups to monitor overall health ", "OK");
        //    }
        //    if (bmi >= 25 && bmi < 30)
        //    {
        //        DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
        //                      "HealhStatus: Overweight" +
        //                      "\nRecommendations: Reduce processed foods and focus on portion control. " +
        //                      "Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. " +
        //                      "Drink plenty of water and track your progress ", "OK");
        //    }
        //    if (bmi > 30)
        //    {
        //        DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
        //                      "HealhStatus: Obese" +
        //                      "\nRecommendations: Consult a doctor for personalized guidance. " +
        //                      "Start with low impact exercises (e.g., waling, cycling). " +
        //                      "Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes." +
        //                      "Avoid sugary drinks and maintain a consistent sleep schedule ", "OK");
        //    }
        //}
        //if (choice == "Female")
        //{
        //    if (bmi < 18)
        //    {
        //        DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
        //                      "HealhStatus: Underweight" +
        //                      "\nRecommendations: Increase clorie intake with nutrient-rich foods" +
        //                      "(e.g., nuts, lean protein, whole grains). Incorporate strength" +
        //                      "training to build muscle mass. Consult a nutritionist if needed.", "OK");
        //    }
        //    if (bmi >= 18 && bmi < 24)
        //    {
        //        DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
        //                      "HealhStatus: Normal Weight" +
        //                      "\nRecommendations: Maintain a balanced diet with proteins, healthy fats, and fiber. " +
        //                      "Stay physically active with at least 150 minutes of exercise per week. " +
        //                      "Keep regular check-ups to monitor overall health ", "OK");
        //    }
        //    if (bmi >= 24 && bmi < 29)
        //    {
        //        DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
        //                      "HealhStatus: Overweight" +
        //                      "\nRecommendations: Reduce processed foods and focus on portion control. " +
        //                      "Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. " +
        //                      "Drink plenty of water and track your progress ", "OK");
        //    }
        //    if (bmi > 29)
        //    {
        //        DisplayAlert("Your calculated BMI results are:", "Gender: " + choice + "\n" + "BMI:" + bmi.ToString() + "\n" +
        //                      "HealhStatus: Obese" +
        //                      "\nRecommendations: Consult a doctor for personalized guidance. " +
        //                      "Start with low impact exercises (e.g., waling, cycling). " +
        //                      "Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. " +
        //                      "Avoid sugary drinks and maintain a consistent sleep schedule ", "OK");
        //    }
        //}
        
    }
}