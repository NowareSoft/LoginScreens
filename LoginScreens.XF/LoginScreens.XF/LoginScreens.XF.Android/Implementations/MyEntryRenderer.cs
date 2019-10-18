using Android.Content.Res;
using Android.Graphics;
using Android.OS;
using LoginScreens.XF.Droid.Implementations;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
namespace LoginScreens.XF.Droid.Implementations
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
            else
                Control.Background.SetColorFilter(Android.Graphics.Color.Transparent, PorterDuff.Mode.SrcAtop);
        }
    }
}