using System;
using System.Windows.Forms;

namespace Formless
{
    class Context
    {
        public ContextMenuStrip Create()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            ToolStripMenuItem item;

            // Exit.
            item = new ToolStripMenuItem();
            item.Text = "Exit";
            item.Click += new EventHandler(Exit_Click);
            menu.Items.Add(item);

            return menu;
        }

        void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
