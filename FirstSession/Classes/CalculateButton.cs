using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstSession.Classes
{
    public class CalculateButton : Button
    {
        public CalculateButton(int w, int h)
        {
            Width = w;
            Height = h;
            Text = "Számolás";
        }
    }
}
