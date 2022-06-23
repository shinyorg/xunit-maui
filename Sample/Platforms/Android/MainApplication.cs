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

#if RUN_HEADLESS
namespace Sample
{

    [global::Android.App.Instrumentation]
    public partial class AndroidMauiTestInstrumentation : global::Xunit.Runners.Maui.HeadlessRunner.MauiTestInstrumentation
    {
        protected AndroidMauiTestInstrumentation(global::System.IntPtr handle, global::Android.Runtime.JniHandleOwnership transfer) : base(handle, transfer)
        {
        }
    }
}
#endif