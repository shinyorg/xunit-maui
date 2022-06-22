using Android.App;
using Android.Runtime;

namespace Sample
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}



//#if !SKIP_RUNNER_ENTRYPOINT_GENERATION && !SKIP_HEADLESS_RUNNER_ENTRYPOINT_GENERATION && !SKIP_HEADLESS_RUNNER_INSTRUMENTATION_GENERATION
//namespace " + RootNamespace + @"
//{
//	[global::Android.App.Instrumentation(Name = """ + ApplicationId + "." + instrumentationName + @""")]
//public partial class " + instrumentationName + @" : global::Microsoft.Maui.TestUtils.DeviceTests.Runners.HeadlessRunner.MauiTestInstrumentation
//	{
//		protected " + instrumentationName + @"(global::System.IntPtr handle, global::Android.Runtime.JniHandleOwnership transfer)
//			: base(handle, transfer)
//		{
//		}
//	}
//}
//#endif
