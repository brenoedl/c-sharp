namespace DataHoraWindow
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
            lblDH = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblDH
            // 
            lblDH.AutoSize = true;
            lblDH.Location = new Point(103, 36);
            lblDH.Name = "lblDH";
            lblDH.Size = new Size(173, 20);
            lblDH.TabIndex = 0;
            lblDH.Text = "DD/MM/AAAA hh:mm:ss";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(143, 120);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 181);
            Controls.Add(btnOk);
            Controls.Add(lblDH);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data e Hora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDH;
        private Button btnOk;
    }
}
