﻿using BulePointLilac.Methods;
using System.Windows.Forms;

namespace BulePointLilac.Controls
{
    public sealed class MyToolTip
    {
        public static void SetToolTip(Control ctr, string tip)
        {
            if(tip.IsNullOrWhiteSpace()) return;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(ctr, tip);
            ctr.Disposed += (sender, e) => toolTip.Dispose();
        }

        public static void SetToolTip(ToolStripItem item, string tip)
        {
            //必须先设置item的Owner
            item.Owner.ShowItemToolTips = true;
            item.ToolTipText = tip;
        }
    }
}