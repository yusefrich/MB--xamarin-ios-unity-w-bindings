using Foundation;
using System;
using UIKit;
using NativeLibrary;
namespace iOS_only_2
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton197_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
            UnityFramework ufw = UnityFramework.LoadUnity();
            //UnityFramework ufw = UnityFramework.GetInstance();    
            //ufw.LoadUnityWArgss();
            ufw.RunEmbedded();
            ufw.ShowUnityWindow();
        }
    }
}