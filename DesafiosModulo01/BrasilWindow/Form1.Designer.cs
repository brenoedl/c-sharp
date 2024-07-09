namespace BrasilWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblMsg1 = new Label();
            lblMsg2 = new Label();
            lblMsg3 = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblMsg1
            // 
            lblMsg1.AutoSize = true;
            lblMsg1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMsg1.Location = new Point(55, 79);
            lblMsg1.Name = "lblMsg1";
            lblMsg1.Size = new Size(91, 46);
            lblMsg1.TabIndex = 0;
            lblMsg1.Text = "MEU";
            lblMsg1.Visible = false;
            // 
            // lblMsg2
            // 
            lblMsg2.AutoSize = true;
            lblMsg2.Font = new Font("Segoe UI", 19.8000011F);
            lblMsg2.Location = new Point(152, 79);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(124, 46);
            lblMsg2.TabIndex = 1;
            lblMsg2.Text = "BRASIL";
            lblMsg2.Visible = false;
            // 
            // lblMsg3
            // 
            lblMsg3.AutoSize = true;
            lblMsg3.Font = new Font("Segoe UI", 19.8000011F);
            lblMsg3.Location = new Point(282, 78);
            lblMsg3.Name = "lblMsg3";
            lblMsg3.Size = new Size(196, 46);
            lblMsg3.TabIndex = 2;
            lblMsg3.Text = "BRASILEIRO";
            lblMsg3.Visible = false;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOk.Location = new Point(212, 191);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(104, 49);
            btnOk.TabIndex = 3;
            btnOk.Text = "INICIAR";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += button1_Click;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 344);
            Controls.Add(btnOk);
            Controls.Add(lblMsg3);
            Controls.Add(lblMsg2);
            Controls.Add(lblMsg1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brasil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsg1;
        private Label lblMsg2;
        private Label lblMsg3;
        private Button btnOk;
    }
}
