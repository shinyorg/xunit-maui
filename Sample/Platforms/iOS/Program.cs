using UIKit;

namespace Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}
//#if !SKIP_RUNNER_ENTRYPOINT_GENERATION && !SKIP_VISUAL_RUNNER_ENTRYPOINT_GENERATION && !SKIP_RUNNER_PROGRAM_GENERATION
//namespace " + RootNamespace + @"
//{
//	partial class Program
//{
//    static void Main(global::System.String[] args)
//    {
//#if !SKIP_HEADLESS_RUNNER_APP_DELEGATE_GENERATION
//        if (global::Microsoft.Maui.TestUtils.DeviceTests.Runners.HeadlessRunner.MauiTestApplicationDelegate.IsHeadlessRunner(args))
//        {
//            global::UIKit.UIApplication.Main(args, null, typeof(global::" + RootNamespace + @"." + headlessDelegateName + @"));
//        }
//        else
//#endif
//        {
//#if !SKIP_VISUAL_RUNNER_APP_DELEGATE_GENERATION
//            global::UIKit.UIApplication.Main(args, null, typeof(global::" + RootNamespace + @"." + visualDelegateName + @"));
//#endif
//        }
//    }
//}
//}