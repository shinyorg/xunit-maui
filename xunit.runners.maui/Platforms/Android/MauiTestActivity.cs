using Android.OS;
using Xunit.Runners.Maui.HeadlessRunner;

namespace Xunit.Runners.Maui
{
    public abstract class MauiTestActivity : MauiAppCompatActivity
    {
        public TaskCompletionSource<Bundle> TaskCompletionSource { get; } = new();

        protected override async void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            if (MauiTestInstrumentation.Current != null)
            {
                try
                {

                    var runner = MauiTestInstrumentation.Current.Services.GetRequiredService<HeadlessTestRunner>();

                    var bundle = await runner.RunTestsAsync();

                    TaskCompletionSource.TrySetResult(bundle);
                }
                catch (Exception ex)
                {
                    TaskCompletionSource.TrySetException(ex);
                }

                Finish();
            }
        }
    }
}