﻿using Appercode.UI.Controls.NativeControl.Wrappers;
using System.Drawing;

namespace Appercode.UI.Controls
{
    public partial class Grid
    {
        protected internal override void NativeInit()
        {
            WrappedViewGroup.FillNativeUIElement(this);
            base.NativeInit();
        }

        protected override void ArrangeChilds(SizeF size)
        {
            this.ArrangeCells(size);
        }
    }
}
