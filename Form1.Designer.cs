namespace UnitConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_val = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.opt_mm = new DarkUI.Controls.DarkRadioButton();
            this.opt_in = new DarkUI.Controls.DarkRadioButton();
            this.opt_mil = new DarkUI.Controls.DarkRadioButton();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkPanel1 = new DarkUI.Controls.DarkPanel();
            this.darkPanel3 = new DarkUI.Controls.DarkPanel();
            this.darkLinkLabel1 = new DarkUI.Controls.DarkLinkLabel();
            this.darkPanel2 = new DarkUI.Controls.DarkPanel();
            this.darkPanel4 = new DarkUI.Controls.DarkPanel();
            this.res_mil = new DarkUI.Controls.DarkLabel();
            this.darkLabel6 = new DarkUI.Controls.DarkLabel();
            this.darkVerticalSeparator2 = new DarkUI.Controls.DarkVerticalSeparator();
            this.res_mm = new DarkUI.Controls.DarkLabel();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkVerticalSeparator1 = new DarkUI.Controls.DarkVerticalSeparator();
            this.res_in = new DarkUI.Controls.DarkLabel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkSeparator1 = new DarkUI.Controls.DarkSeparator();
            this.darkPanel1.SuspendLayout();
            this.darkPanel3.SuspendLayout();
            this.darkPanel2.SuspendLayout();
            this.darkPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_val
            // 
            this.input_val.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input_val.Location = new System.Drawing.Point(74, 0);
            this.input_val.Name = "input_val";
            this.input_val.Size = new System.Drawing.Size(305, 22);
            this.input_val.TabIndex = 2;
            this.input_val.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_Val_Changed);
            // 
            // darkLabel1
            // 
            this.darkLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel1.Location = new System.Drawing.Point(5, 0);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(69, 22);
            this.darkLabel1.TabIndex = 3;
            this.darkLabel1.Text = "Input Value:";
            this.darkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // opt_mm
            // 
            this.opt_mm.Checked = true;
            this.opt_mm.Dock = System.Windows.Forms.DockStyle.Left;
            this.opt_mm.Location = new System.Drawing.Point(74, 0);
            this.opt_mm.Name = "opt_mm";
            this.opt_mm.Size = new System.Drawing.Size(60, 24);
            this.opt_mm.TabIndex = 4;
            this.opt_mm.TabStop = true;
            this.opt_mm.Text = "mm";
            this.opt_mm.CheckedChanged += new System.EventHandler(this.Checks_Changed);
            // 
            // opt_in
            // 
            this.opt_in.Dock = System.Windows.Forms.DockStyle.Left;
            this.opt_in.Location = new System.Drawing.Point(134, 0);
            this.opt_in.Name = "opt_in";
            this.opt_in.Size = new System.Drawing.Size(60, 24);
            this.opt_in.TabIndex = 5;
            this.opt_in.Text = "inch";
            this.opt_in.CheckedChanged += new System.EventHandler(this.Checks_Changed);
            // 
            // opt_mil
            // 
            this.opt_mil.Dock = System.Windows.Forms.DockStyle.Left;
            this.opt_mil.Location = new System.Drawing.Point(194, 0);
            this.opt_mil.Name = "opt_mil";
            this.opt_mil.Size = new System.Drawing.Size(62, 24);
            this.opt_mil.TabIndex = 6;
            this.opt_mil.Text = "mil";
            this.opt_mil.CheckedChanged += new System.EventHandler(this.Checks_Changed);
            // 
            // darkLabel2
            // 
            this.darkLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkLabel2.Location = new System.Drawing.Point(5, 0);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(69, 24);
            this.darkLabel2.TabIndex = 7;
            this.darkLabel2.Text = "Input Unit:";
            this.darkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // darkPanel1
            // 
            this.darkPanel1.BorderSides = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkPanel1.Controls.Add(this.darkPanel3);
            this.darkPanel1.Controls.Add(this.darkPanel2);
            this.darkPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkPanel1.Location = new System.Drawing.Point(0, 5);
            this.darkPanel1.Name = "darkPanel1";
            this.darkPanel1.Size = new System.Drawing.Size(384, 48);
            this.darkPanel1.TabIndex = 8;
            // 
            // darkPanel3
            // 
            this.darkPanel3.BorderSides = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkPanel3.Controls.Add(this.darkLinkLabel1);
            this.darkPanel3.Controls.Add(this.opt_mil);
            this.darkPanel3.Controls.Add(this.opt_in);
            this.darkPanel3.Controls.Add(this.opt_mm);
            this.darkPanel3.Controls.Add(this.darkLabel2);
            this.darkPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkPanel3.Location = new System.Drawing.Point(0, 22);
            this.darkPanel3.Name = "darkPanel3";
            this.darkPanel3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.darkPanel3.Size = new System.Drawing.Size(384, 24);
            this.darkPanel3.TabIndex = 9;
            // 
            // darkLinkLabel1
            // 
            this.darkLinkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.darkLinkLabel1.Location = new System.Drawing.Point(317, 0);
            this.darkLinkLabel1.Name = "darkLinkLabel1";
            this.darkLinkLabel1.Size = new System.Drawing.Size(62, 24);
            this.darkLinkLabel1.TabIndex = 8;
            this.darkLinkLabel1.TabStop = true;
            this.darkLinkLabel1.Text = "Calculator";
            this.darkLinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.darkLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DarkLinkLabel1_LinkClicked);
            // 
            // darkPanel2
            // 
            this.darkPanel2.BorderSides = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkPanel2.Controls.Add(this.input_val);
            this.darkPanel2.Controls.Add(this.darkLabel1);
            this.darkPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkPanel2.Location = new System.Drawing.Point(0, 0);
            this.darkPanel2.Name = "darkPanel2";
            this.darkPanel2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.darkPanel2.Size = new System.Drawing.Size(384, 22);
            this.darkPanel2.TabIndex = 8;
            // 
            // darkPanel4
            // 
            this.darkPanel4.BorderSides = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkPanel4.Controls.Add(this.res_mil);
            this.darkPanel4.Controls.Add(this.darkLabel6);
            this.darkPanel4.Controls.Add(this.darkVerticalSeparator2);
            this.darkPanel4.Controls.Add(this.res_mm);
            this.darkPanel4.Controls.Add(this.darkLabel3);
            this.darkPanel4.Controls.Add(this.darkVerticalSeparator1);
            this.darkPanel4.Controls.Add(this.res_in);
            this.darkPanel4.Controls.Add(this.darkLabel4);
            this.darkPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkPanel4.Location = new System.Drawing.Point(0, 55);
            this.darkPanel4.Name = "darkPanel4";
            this.darkPanel4.Size = new System.Drawing.Size(384, 16);
            this.darkPanel4.TabIndex = 9;
            // 
            // res_mil
            // 
            this.res_mil.AutoEllipsis = true;
            this.res_mil.Dock = System.Windows.Forms.DockStyle.Right;
            this.res_mil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.res_mil.Location = new System.Drawing.Point(-23, 0);
            this.res_mil.Name = "res_mil";
            this.res_mil.Size = new System.Drawing.Size(110, 16);
            this.res_mil.TabIndex = 4;
            this.res_mil.Text = "0000.00";
            this.res_mil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.res_mil.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Res_DoubleClick);
            // 
            // darkLabel6
            // 
            this.darkLabel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.darkLabel6.Location = new System.Drawing.Point(87, 0);
            this.darkLabel6.Name = "darkLabel6";
            this.darkLabel6.Size = new System.Drawing.Size(25, 16);
            this.darkLabel6.TabIndex = 5;
            this.darkLabel6.Text = "mil";
            this.darkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // darkVerticalSeparator2
            // 
            this.darkVerticalSeparator2.Dock = System.Windows.Forms.DockStyle.Right;
            this.darkVerticalSeparator2.Location = new System.Drawing.Point(112, 0);
            this.darkVerticalSeparator2.Name = "darkVerticalSeparator2";
            this.darkVerticalSeparator2.Size = new System.Drawing.Size(1, 16);
            this.darkVerticalSeparator2.TabIndex = 6;
            this.darkVerticalSeparator2.Text = "darkVerticalSeparator2";
            // 
            // res_mm
            // 
            this.res_mm.AutoEllipsis = true;
            this.res_mm.Dock = System.Windows.Forms.DockStyle.Right;
            this.res_mm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.res_mm.Location = new System.Drawing.Point(113, 0);
            this.res_mm.Name = "res_mm";
            this.res_mm.Size = new System.Drawing.Size(110, 16);
            this.res_mm.TabIndex = 0;
            this.res_mm.Text = "0000.00";
            this.res_mm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.res_mm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Res_DoubleClick);
            // 
            // darkLabel3
            // 
            this.darkLabel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.darkLabel3.Location = new System.Drawing.Point(223, 0);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(25, 16);
            this.darkLabel3.TabIndex = 1;
            this.darkLabel3.Text = "mm";
            this.darkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // darkVerticalSeparator1
            // 
            this.darkVerticalSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.darkVerticalSeparator1.Location = new System.Drawing.Point(248, 0);
            this.darkVerticalSeparator1.Name = "darkVerticalSeparator1";
            this.darkVerticalSeparator1.Size = new System.Drawing.Size(1, 16);
            this.darkVerticalSeparator1.TabIndex = 3;
            this.darkVerticalSeparator1.Text = "darkVerticalSeparator1";
            // 
            // res_in
            // 
            this.res_in.AutoEllipsis = true;
            this.res_in.Dock = System.Windows.Forms.DockStyle.Right;
            this.res_in.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.res_in.Location = new System.Drawing.Point(249, 0);
            this.res_in.Name = "res_in";
            this.res_in.Size = new System.Drawing.Size(110, 16);
            this.res_in.TabIndex = 1;
            this.res_in.Text = "0000.00";
            this.res_in.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.res_in.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Res_DoubleClick);
            // 
            // darkLabel4
            // 
            this.darkLabel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.darkLabel4.Location = new System.Drawing.Point(359, 0);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(25, 16);
            this.darkLabel4.TabIndex = 2;
            this.darkLabel4.Text = "in";
            this.darkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // darkSeparator1
            // 
            this.darkSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkSeparator1.Location = new System.Drawing.Point(0, 53);
            this.darkSeparator1.Name = "darkSeparator1";
            this.darkSeparator1.Size = new System.Drawing.Size(384, 2);
            this.darkSeparator1.TabIndex = 10;
            this.darkSeparator1.Text = "darkSeparator1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 71);
            this.Controls.Add(this.darkPanel4);
            this.Controls.Add(this.darkSeparator1);
            this.Controls.Add(this.darkPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 110);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 110);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Converter";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.darkPanel1.ResumeLayout(false);
            this.darkPanel3.ResumeLayout(false);
            this.darkPanel2.ResumeLayout(false);
            this.darkPanel2.PerformLayout();
            this.darkPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DarkUI.Controls.DarkTextBox input_val;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkRadioButton opt_mm;
        private DarkUI.Controls.DarkRadioButton opt_in;
        private DarkUI.Controls.DarkRadioButton opt_mil;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkPanel darkPanel1;
        private DarkUI.Controls.DarkPanel darkPanel3;
        private DarkUI.Controls.DarkPanel darkPanel2;
        private DarkUI.Controls.DarkPanel darkPanel4;
        private DarkUI.Controls.DarkLabel res_in;
        private DarkUI.Controls.DarkLabel res_mm;
        private DarkUI.Controls.DarkSeparator darkSeparator1;
        private DarkUI.Controls.DarkLabel res_mil;
        private DarkUI.Controls.DarkLabel darkLabel6;
        private DarkUI.Controls.DarkVerticalSeparator darkVerticalSeparator2;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkVerticalSeparator darkVerticalSeparator1;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkLinkLabel darkLinkLabel1;
    }
}

