using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Com.Umeng.Socialize
{
    public partial class UMShareAPI
    {
        public partial class InitThread : global::Com.Umeng.Socialize.Common.QueuedWork.UMAsyncTask
        {
            protected override Java.Lang.Object DoInBackground()
            {
                return DoInBackgrounds();
            }
        }
    }
}