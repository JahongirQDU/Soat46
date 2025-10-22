using System.Threading.Tasks;

namespace Soat46;

public partial class Page2 : ContentPage
{
    public static event EventHandler<Alarms> AlarmAdded;

    bool[] selected = new bool[7];

	public Page2()
	{
		InitializeComponent();
	}


    void Tanlandi(int index, Button btn)
    {

    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void Button_Save(object sender, EventArgs e)
    {
        var tp = Time ?? this.FindByName<TimePicker>("Time");
        var te = Name ?? this.FindByName<Entry>("Name");
        var sw=IsEnabled ?? this.FindByName<Switch>("IsEnabled");

        string time = (tp?.Time ?? TimeSpan.Zero).ToString(@"hh\:mm");
        string title = te?.Text ?? "";
        bool toggle = sw?.IsToggled ?? false;

        string repeat = SetRepeat();

        var newAlarm = new Alarms
        {
            Time = time, Name=title, Repeat=repeat, IsEnabled=toggle
        };

        AlarmAdded?.Invoke(this, newAlarm);


        await Shell.Current.GoToAsync("..");
    }
    string SetRepeat()
    {
        return "Du";
    }
}