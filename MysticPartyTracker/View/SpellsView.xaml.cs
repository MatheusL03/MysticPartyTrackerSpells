using MysticPartyTracker.Model;
using MysticPartyTracker.ViewModels;

namespace MysticPartyTracker.View;

public partial class SpellsView : ContentPage
{
	public SpellsView()
	{
		InitializeComponent();
        BindingContext = new SpellsViewModel();
    }
}