﻿using System;
using Sparkle;

using AppKit;
using Foundation;

namespace SparkleSharpSample
{
    public partial class ViewController : NSViewController
    {
        SUUpdater updater;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            updater = new SUUpdater();
            updater.AutomaticallyChecksForUpdates = false;
        }

        partial void CheckUpdates(NSObject sender)
        {
            updater.CheckForUpdates(new NSObject());
        }

    }
}
