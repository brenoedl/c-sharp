using Microsoft.VisualBasic.Devices;

namespace AredondarWindow
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
            label1 = new Label();
            txtNum = new TextBox();
            btnOk = new Button();
            panMsg = new Panel();
            lblMsg3 = new Label();
            lblMsg2 = new Label();
            lblMsg1 = new Label();
            panMsg.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 0;
            label1.Text = "Digite um numero real: ";
            // 
            // txtNum
            // 
            txtNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum.Location = new Point(235, 23);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(125, 34);
            txtNum.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOk.Location = new Point(389, 13);
            btnOk.Name = "btnOk";
            btnOk.RightToLeft = RightToLeft.No;
            btnOk.Size = new Size(94, 49);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // panMsg
            // 
            panMsg.Controls.Add(lblMsg3);
            panMsg.Controls.Add(lblMsg2);
            panMsg.Controls.Add(lblMsg1);
            panMsg.Location = new Point(11, 84);
            panMsg.Name = "panMsg";
            panMsg.Size = new Size(472, 135);
            panMsg.TabIndex = 3;
            panMsg.Visible = false;
            // 
            // lblMsg3
            // 
            lblMsg3.AutoSize = true;
            lblMsg3.Font = new Font("Segoe UI", 12F);
            lblMsg3.Location = new Point(3, 90);
            lblMsg3.Name = "lblMsg3";
            lblMsg3.Size = new Size(124, 28);
            lblMsg3.TabIndex = 2;
            lblMsg3.Text = "Mensagem 3";
            // 
            // lblMsg2
            // 
            lblMsg2.AutoSize = true;
            lblMsg2.Font = new Font("Segoe UI", 12F);
            lblMsg2.Location = new Point(3, 50);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(124, 28);
            lblMsg2.TabIndex = 1;
            lblMsg2.Text = "Mensagem 2";
            // 
            // lblMsg1
            // 
            lblMsg1.AutoSize = true;
            lblMsg1.Font = new Font("Segoe UI", 12F);
            lblMsg1.Location = new Point(3, 10);
            lblMsg1.Name = "lblMsg1";
            lblMsg1.Size = new Size(124, 28);
            lblMsg1.TabIndex = 0;
            lblMsg1.Text = "Mensagem 1";
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 226);
            Controls.Add(panMsg);
            Controls.Add(btnOk);
            Controls.Add(txtNum);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Analisador de números";
            panMsg.ResumeLayout(false);
            panMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnOk;
        private Panel panMsg;
        private Label lblMsg2;
        private Label lblMsg1;
        private Label lblMsg3;
    }
}
