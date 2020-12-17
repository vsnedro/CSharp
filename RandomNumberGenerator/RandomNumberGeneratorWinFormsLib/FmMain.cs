using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomNumberGeneratorLib;

namespace RandomNumberGeneratorWinFormsLib
{
    public partial class FmMain : Form
    {
        IRandomNumberGenerator rnd;

        public FmMain()
        {
            InitializeComponent();

            Reset();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Min.Text) || (!int.TryParse(txt_Min.Text, out _)))
            {
                txt_Min.Text = rnd.MinDefault.ToString();
            }
            if (string.IsNullOrWhiteSpace(txt_Max.Text) || (!int.TryParse(txt_Max.Text, out _)))
            {
                txt_Max.Text = rnd.MaxDefault.ToString();
            }

            rnd.Min = Convert.ToUInt32(txt_Min.Text);
            rnd.Max = Convert.ToUInt32(txt_Max.Text);
            txt_Max.Text = rnd.Max.ToString();
            
            txt_Result.Text = rnd.GetValue().ToString();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            rnd = new RandomNumberGenerator();
            txt_Min.Text = rnd.Min.ToString();
            txt_Max.Text = rnd.Max.ToString();
            txt_Result.Clear();
        }
    }
}
