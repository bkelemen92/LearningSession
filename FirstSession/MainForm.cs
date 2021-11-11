using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstSession.Classes;

namespace FirstSession
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CalculateButton cb = new CalculateButton(200, 30) { Left = txt_Result.Left, Top = txt_Result.Top + 32 };
            Controls.Add(cb);
            PlusMinusButton btnPlus = new PlusMinusButton(AddOrSubtract.Add, txt_Period) { Top = txt_Period.Top, Left = txt_Period.Left + txt_Period.Width + 10 };
            Controls.Add(btnPlus);
            PlusMinusButton btnMinus = new PlusMinusButton(AddOrSubtract.Subtract, txt_Period) { Top = txt_Period.Top, Left = btnPlus.Left + btnPlus.Width + 5 } ;
            Controls.Add(btnMinus);
            txt_Period.Text = 0.ToString();
            txt_Period.ReadOnly = true;


            cb.Click += Cb_Click;

            
          
        }

        private void Cb_Click(object sender, EventArgs e)
        {
            CalcualteResult();
        }




        public void CalcualteResult()
        {
            //txt_Result.Text = (Convert.ToDouble(txt_PV.Text) * (1 + Convert.ToDouble(txt_Interest.Text) / 100 * Convert.ToDouble(txt_Period.Text))).ToString();
            txt_Result.Text = Functions.FutureValue2(Convert.ToDouble(txt_PV.Text), Convert.ToDouble(txt_Interest.Text), Convert.ToDouble(txt_Period.Text)).ToString();
        }

    }
}
