namespace StringsInterpoladasWindow02
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
            label1 = new Label();
            txtSal = new TextBox();
            btnOk = new Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(31, 48);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "Qual o seu salário?";
            // 
            // txtSal
            // 
            txtSal.Font = new Font("Segoe UI", 12F);
            txtSal.Location = new Point(221, 42);
            txtSal.Name = "txtSal";
            txtSal.Size = new Size(125, 34);
            txtSal.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 12F);
            btnOk.Location = new Point(137, 105);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 39);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI", 12F);
            lblMsg.Location = new Point(41, 188);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(102, 28);
            lblMsg.TabIndex = 3;
            lblMsg.Text = "Mensagen";
            lblMsg.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 261);
            Controls.Add(lblMsg);
            Controls.Add(btnOk);
            Controls.Add(txtSal);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Strings Interpoladas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSal;
        private Button btnOk;
        private Label lblMsg;
    }
}
