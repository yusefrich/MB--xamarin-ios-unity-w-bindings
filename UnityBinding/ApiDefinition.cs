using System;
using CoreAnimation;

using ObjCRuntime;
using Foundation;
using UIKit;


namespace NativeLibrary
{
    // @interface UnityAppController : NSO  bject <UIApplicationDelegate>
    [BaseType(typeof(NSObject))]
    interface UnityAppController : IUIApplicationDelegate
    {
        [Export("quitHandler", ArgumentSemantic.Copy)]
        Action QuitHandler { get; set; }

        [Export("rootView", ArgumentSemantic.Copy)]
        UIView RootView { get; }

        [Export("rootViewController", ArgumentSemantic.Copy)]
        UIViewController RootViewController { get; }
    }

    interface IUnityFrameworkListener { }

    [BaseType(typeof(NSObject))]
    [Model]
    [Protocol]
    interface UnityFrameworkListener
    {
        [Export("unityDidUnload:")]
        void UnityDidUnload(NSNotification notification);

        [Export("unityDidQuit:")]
        void UnityDidQuit(NSNotification notification);
    }

    [BaseType(typeof(NSObject))]
    interface UnityFramework
    {
        [Export("appController")]
        UnityAppController AppController { get; }

        [Static, Export("getInstance")]
        UnityFramework Instance { get; }

        //[Export("setDataBundleId:")]
        //unsafe void SetDataBundleId(sbyte* bundleId);

        [Internal, Export("runUIApplicationMainWithArgc:argv:")]
        void RunUIApplicationMainWithArgc(int argc, IntPtr argv);

        [Internal, Export("runEmbeddedWithArgc:argv:appLaunchOpts:")]
        void RunEmbeddedWithArgc(int argc, IntPtr argv, NSDictionary options);

        [Export("runEmbedded")]
        void RunEmbedded();

        //[Static, Export("loadUnity")]
        //UnityFramework LoadUnity { get; }

        [Static, Export("loadUnity")]
        UnityFramework LoadUnity();

        //[Static, Export("loadUnityWArgs")]
        //UnityFramework LoadUnityWArgs();

        [Export("unloadApplication")]
        void UnloadApplication();

        [Export("quitApplication:")]
        void QuitApplication(int exitCode);

        [Export("registerFrameworkListener:")]
        void RegisterFrameworkListener(IUnityFrameworkListener obj);

        [Export("unregisterFrameworkListener:")]
        void UnregisterFrameworkListener(IUnityFrameworkListener obj);

        [Export("ShowUnityWindow")]
        void ShowUnityWindow();

        [Export("pause:")]
        void Pause(bool pause);

        //[Export("setExecuteHeader:")]
        //void SetExecuteHeader(ref MachHeader header);

        [Export("sendMessageToGOWithName:functionName:message:")]
        void SendMessageToGOWithName([PlainString] string goName, [PlainString] string functionName, [PlainString] string msg);






    }

}

