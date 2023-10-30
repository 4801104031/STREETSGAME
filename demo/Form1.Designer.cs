namespace demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Gametimer = new System.Windows.Forms.Timer(components);
            lbl1 = new Label();
            SuspendLayout();
            // 
            // Gametimer
            // 
            Gametimer.Enabled = true;
            Gametimer.Interval = 20;
            Gametimer.Tick += GameTimerEvent;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Tw Cen MT Condensed Extra Bold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            lbl1.ForeColor = Color.FromArgb(192, 0, 192);
            lbl1.Image = Properties.Resources.Nen;
            lbl1.Location = new Point(387, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(30, 35);
            lbl1.TabIndex = 0;
            lbl1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Streetfighter demo";
            Paint += FormPaintEvent;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Gametimer;
        private Label lbl1;
    }
}