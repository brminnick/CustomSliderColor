using Xamarin.Forms;

namespace CustomSliderColor
{
	public class App : Application
	{
		public App() => MainPage = new ContentPage { Content = new CustomSlider() };
	}

	public class CustomSlider : Slider
	{
		public const string SliderColorHexValue = "008000";
	}
}