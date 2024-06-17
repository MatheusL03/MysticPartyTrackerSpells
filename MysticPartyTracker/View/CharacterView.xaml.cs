namespace MysticPartyTracker.View;
using MysticPartyTracker.ViewModels;

public partial class CharacterView : ContentPage
{
	public CharacterView()
	{
		InitializeComponent();
		BindingContext = new CharacterViewModel();

    }

}