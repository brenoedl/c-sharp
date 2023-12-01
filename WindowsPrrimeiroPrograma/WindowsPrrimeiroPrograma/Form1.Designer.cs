namespace WindowsPrrimeiroPrograma
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
            btn = new Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.Location = new Point(242, 182);
            btn.Name = "btn";
            btn.Size = new Size(141, 56);
            btn.TabIndex = 0;
            btn.Text = "Me aperte";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // lblMsg
            // 
            lblMsg.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMsg.Location = new Point(12, 32);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(616, 38);
            lblMsg.TabIndex = 1;
            lblMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(624, 319);
            Controls.Add(lblMsg);
            Controls.Add(btn);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prrimeiro Programa";
            ResumeLayout(false);
        }

        #endregion

        private Button btn;
        private Label lblMsg;
    }
}
