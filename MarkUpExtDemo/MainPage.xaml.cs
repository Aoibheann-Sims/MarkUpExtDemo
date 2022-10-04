namespace MarkUpExtDemo;

public partial class MainPage : ContentPage
{
	public const double MyFontSize = 25;
	public MainPage()
	{
		InitializeComponent();
		//btnChangeText.Clicked += OnbtnChangeTextClicked;
	}
}

public class GlobalFontSizeExtension : IMarkupExtension
{
	public object ProvideValue(IServiceProvider serviceProvider)
	{
		return MainPage.MyFontSize;
	}
}

