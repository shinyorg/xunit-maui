using Android.OS;
using AndroidX.AppCompat.App;

namespace Xunit.Runners.Maui.HeadlessRunner
{
    public abstract class MauiTestActivity : AppCompatActivity
    {
        public TaskCompletionSource<Bundle> TaskCompletionSource { get; } = new();

        protected override async void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

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