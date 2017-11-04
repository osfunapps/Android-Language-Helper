using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remotes_App_Translation_Project.tools
{
    class HintsCreator
    {
        /**Normal Text Box hint **/
        public void OnTBHint_Leave(object sender, EventArgs e)
        {
            if (((TextBox) sender).Text.Length != 0) return;
            ((TextBox)sender).Text = ((TextBox)sender).Tag.ToString();
            ((TextBox)sender).ForeColor = SystemColors.GrayText;
        }

        public void OnTBHint_Enter(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == ((TextBox)sender).Tag.ToString())
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = SystemColors.WindowText;
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        /**Rich Text Box hint **/
        public void OnRTBHint_Leave(object sender, EventArgs e)
        {
            if (((RichTextBox)sender).Text.Length != 0) return;
            ((RichTextBox)sender).Text = ((RichTextBox)sender).Tag.ToString();
            ((RichTextBox)sender).ForeColor = SystemColors.GrayText;
        }

        public void OnRTBHint_Enter(object sender, EventArgs e)
        {
            if (((RichTextBox)sender).Text == ((RichTextBox)sender).Tag.ToString())
            {
                ((RichTextBox)sender).Text = "";
                ((RichTextBox)sender).ForeColor = SystemColors.WindowText;
                ((RichTextBox)sender).ForeColor = Color.Black;
            }
        }
    }
}
