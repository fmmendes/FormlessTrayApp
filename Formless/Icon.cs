using System;
using System.Drawing;
using System.Windows.Forms;

namespace Formless
{
    internal class Icon : IDisposable
    {
        NotifyIcon ni;
        public Icon()
        {
            ni = new NotifyIcon();
        }

        public void Dispose()
        {
            ni.Dispose();
        }

        internal void Display()
        {
            ni.Icon = SystemIcons.Information;
            ni.Text = "Formless Sample Application";
            ni.Visible = true;
            ni.ContextMenuStrip = new Context().Create();
        }
    }

}
