namespace StringsInterpoladasFormatadasWindow
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
            label2 = new Label();
            label3 = new Label();
            btnOk = new Button();
            lblMsg = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtPeso = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(17, 84);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 1;
            label2.Text = "Idade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 141);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 2;
            label3.Text = "Peso";
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 12F);
            btnOk.Location = new Point(90, 204);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 39);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI", 12F);
            lblMsg.Location = new Point(20, 255);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(102, 28);
            lblMsg.TabIndex = 4;
            lblMsg.Text = "Mensagen";
            lblMsg.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(99, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 34);
            txtNome.TabIndex = 5;
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 12F);
            txtIdade.Location = new Point(99, 78);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(125, 34);
            txtIdade.TabIndex = 6;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 12F);
            txtPeso.Location = new Point(99, 135);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 34);
            txtPeso.TabIndex = 7;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 325);
            Controls.Add(txtPeso);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lblMsg);
            Controls.Add(btnOk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Strins Interpoladas Formatadas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOk;
        private Label lblMsg;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtPeso;
    }
}
