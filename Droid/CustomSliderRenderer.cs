using Android.Content;
using Android.Content.Res;
using Android.Graphics;

using CustomSliderColor;
using CustomSliderColor.Droid;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomSlider), typeof(CustomSliderRenderer))]
namespace CustomSliderColor.Droid
{
	public class CustomSliderRenderer : SliderRenderer
	{
		public CustomSliderRenderer(Context context) : base(context)
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null)
			{
				Control.ProgressTintList = ColorStateList.ValueOf(Xamarin.Forms.Color.FromHex(CustomSlider.SliderColorHexValue).ToAndroid());
				Control.ProgressTintMode = PorterDuff.Mode.SrcIn;
                
				Control.SecondaryProgressTintList = ColorStateList.ValueOf(Xamarin.Forms.Color.FromHex(CustomSlider.SliderColorHexValue).ToAndroid());
				Control.SecondaryProgressTintMode = PorterDuff.Mode.SrcIn;
                
				Control.ProgressBackgroundTintList = ColorStateList.ValueOf(Xamarin.Forms.Color.FromHex(CustomSlider.SliderColorHexValue).ToAndroid());
				Control.ProgressBackgroundTintMode = PorterDuff.Mode.SrcIn;
                
				Control.Thumb.SetColorFilter(Xamarin.Forms.Color.FromHex(CustomSlider.SliderColorHexValue).ToAndroid(), PorterDuff.Mode.SrcIn);
			}
		}
	}
}