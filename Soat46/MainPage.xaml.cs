using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Soat46
{
    public partial class MainPage : ContentPage
    {

       public ObservableCollection<Alarms>  alarms { get; set; } 

        public MainPage()
        {
            InitializeComponent();
            alarms = new ObservableCollection<Alarms>
            {
                new Alarms{Time="07:30", Name="Budilnik",Repeat="du-ju", IsEnabled=true},
                 new Alarms{Time="07:30", Name="Budilnik", IsEnabled=true},
            };
            Alarmslist.ItemsSource = alarms;

        }

       

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Page2));
        }
    }
    public class Alarms
    {
        public string Time { get; set; }
        public string Name { get; set; }
        public string Repeat { get; set; }
        public bool IsEnabled { get; set; }
    }

}
