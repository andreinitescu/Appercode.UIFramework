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

namespace System.Windows.Threading
{
    public partial class DispatcherObject
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Windows.Threading.DispatcherObject" /> class. </summary>
        protected DispatcherObject()
        {
            this.dispatcher = Dispatcher.CurrentDispatcher;
        }

        public void VerifyAccess()
        {
            if(this.dispatcher != null)
            {
                this.dispatcher.CheckAccess();
            }
        }
    }
}