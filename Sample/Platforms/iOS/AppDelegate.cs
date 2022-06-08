using Foundation;

namespace Sample;


[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    //[Export("application:didRegisterForRemoteNotificationsWithDeviceToken:")]
    //public void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
    //    => Host.Current.Lifecycle().OnRegisteredForRemoteNotifications(deviceToken);

    //[Export("application:didFailToRegisterForRemoteNotificationsWithError:")]
    //public void FailedToRegisterForRemoteNotifications(UIApplication application, NSError error)
    //    => Host.Current.Lifecycle().OnFailedToRegisterForRemoteNotifications(error);

    //[Export("application:didReceiveRemoteNotification:fetchCompletionHandler:")]
    //public void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, Action<UIBackgroundFetchResult> completionHandler)
    //    => Host.Current.Lifecycle().OnDidReceiveRemoveNotification(userInfo, completionHandler);

    //[Export("application:handleEventsForBackgroundURLSession:completionHandler:")]
    //public bool HandleEventsForBackgroundUrl(UIApplication application, string sessionIdentifier, Action completionHandler) 
    //    => Host.Current.Lifecycle().OnHandleEventsForBackgroundUrl(sessionIdentifier, completionHandler);

//    static void Main(global::System.String[] args)
//    {
//#if !SKIP_HEADLESS_RUNNER_APP_DELEGATE_GENERATION
//        if (global::XUnit.Maui.Runners.HeadlessRunner.MauiTestApplicationDelegate.IsHeadlessRunner(args))
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
}