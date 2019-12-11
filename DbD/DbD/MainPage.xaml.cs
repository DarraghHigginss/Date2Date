using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace DbD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]//compiling the project when the application is finished building
    public partial class MainPage : ContentPage
    {
        public MainPage()//Main Page Method
        {
            InitializeComponent();//calling Initialize Component Method
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Recalculate();//calling the recalculate method
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            Recalculate();
        }

        void Recalculate()//Method to calculate the days until the second date selected (Using Timespan)
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date +
                (includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);

            resultLabel.Text = String.Format("{0} day{1} between dates",
                                             timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        }
    }

}