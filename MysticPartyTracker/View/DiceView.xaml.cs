using MysticPartyTracker.Model;
using MysticPartyTracker.ViewModels;

namespace MysticPartyTracker.View;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
		SidesPicker.SelectedIndex = 0;
		QuantityPicker.SelectedIndex = 0;
		BindingContext = new DiceViewModel();
	}

}