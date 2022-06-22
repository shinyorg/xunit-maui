using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Sample;


[Activity(
    Theme = "@style/Maui.SplashTheme",
    MainLauncher = true,
    ConfigurationChanges =
        ConfigChanges.ScreenSize |
        ConfigChanges.Orientation |
        ConfigChanges.UiMode |
        ConfigChanges.ScreenLayout |
        ConfigChanges.SmallestScreenSize |
        ConfigChanges.Density
)]
public class MainActivity : MauiAppCompatActivity
{
}


//#if !SKIP_RUNNER_ENTRYPOINT_GENERATION && !SKIP_VISUAL_RUNNER_ENTRYPOINT_GENERATION && !SKIP_VISUAL_RUNNER_ACTIVITY_GENERATION
//namespace " + RootNamespace + @"
//{
//	[global::Android.App.Activity(
//        " + splash + @"

//        MainLauncher = true,
//        ConfigurationChanges =
//            global::Android.Content.PM.ConfigChanges.ScreenSize |
//            global::Android.Content.PM.ConfigChanges.Orientation |
//            global::Android.Content.PM.ConfigChanges.UiMode |
//            global::Android.Content.PM.ConfigChanges.ScreenLayout |
//            global::Android.Content.PM.ConfigChanges.SmallestScreenSize)]
//partial class " + visualActivityName + @" : global::Microsoft.Maui.MauiAppCompatActivity
//	{
//	}
//}
//#endif