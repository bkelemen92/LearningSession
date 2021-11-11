using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstSession.Classes
{
    class PlusMinusButton : Button
    {
        private TextBox DestinationTextBox;
        private AddOrSubtract AddOrSub;

        public PlusMinusButton(AddOrSubtract aos, TextBox dest)
        {
            /*
            if (aos == AddOrSubtract.Add)
            {
                dest.Text = (Convert.ToInt32(dest.Text) + 1).ToString();
            }
            else
            {
                dest.Text = (Convert.ToInt32(dest.Text) - 1).ToString();
            }
            */
            Width = Height = 20;
            Text = aos == AddOrSubtract.Add ? "+" : "-";
            DestinationTextBox = dest;
            AddOrSub = aos;
            Click += PlusMinusButton_Click;
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            DestinationTextBox.Text = AddOrSub == AddOrSubtract.Add ?
                (Convert.ToInt32(DestinationTextBox.Text) + 1).ToString() :
                (Convert.ToInt32(DestinationTextBox.Text) - 1).ToString();
            if (Convert.ToInt32(DestinationTextBox.Text) < 0) DestinationTextBox.Text = 0.ToString();
        }

        
    }

    public enum AddOrSubtract
    {
        Add,
        Subtract
    }

}
