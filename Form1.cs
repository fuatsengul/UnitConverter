using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : DarkUI.Forms.DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Input_Val_Changed(object sender, KeyEventArgs e)
        {
            Calculate();
        }

        void Calculate()
        {
            double _input_val = 0;
            if (Double.TryParse(
                input_val.Text.Replace(" ", "").Replace(",", ".").Trim(),
                System.Globalization.NumberStyles.AllowDecimalPoint,
                System.Globalization.CultureInfo.InvariantCulture,
                out _input_val))
            {
                
            }

            if (opt_mm.Checked)
            {
                res_mm.Text = Math.Round(_input_val, 5).ToString();
                res_in.Text = Math.Round(_input_val / 25.4, 5).ToString();
                res_mil.Text = Math.Round(_input_val * 39.37, 5).ToString();
            }
            else if (opt_in.Checked)
            {
                res_mm.Text = Math.Round(_input_val * 25.4, 5).ToString();
                res_in.Text = Math.Round(_input_val, 5).ToString();
                res_mil.Text = Math.Round(_input_val * 1000, 5).ToString();
            }
            else if (opt_mil.Checked)
            {
                res_mm.Text = Math.Round(_input_val * 0.0254, 5).ToString();
                res_in.Text = Math.Round(_input_val / 1000, 5).ToString();
                res_mil.Text = Math.Round(_input_val, 5).ToString();
            }
        }

        private void Checks_Changed(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Res_DoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(((DarkUI.Controls.DarkLabel)sender).Text, TextDataFormat.Text);
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += delegate
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.Text = "Copied Into Clipboard";
                    System.Threading.Thread.Sleep(1000);
                    this.Text = "Unit Converter";
                }));
                
            };
            bw.RunWorkerAsync();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            res_mil.Width = res_mm.Width  = res_in.Width = (this.Width - 100) / 3;
        }

        private void DarkLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
    }
}
