namespace EntradaDadosWindow01
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
            btnOk = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(154, 108);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "Qual o seu nome?\r\n";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(174, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 2;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(38, 201);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(82, 20);
            lblMsg.TabIndex = 3;
            lblMsg.Text = "mensagem";
            lblMsg.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 279);
            Controls.Add(lblMsg);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada de Dados Window 01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Label label1;
        private TextBox txtNome;
        private Label lblMsg;
    }
}
