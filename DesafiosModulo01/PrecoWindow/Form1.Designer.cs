namespace PrecoWindow
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProduto1 = new TextBox();
            txtPreco1 = new TextBox();
            txtProduto2 = new TextBox();
            txtPreco2 = new TextBox();
            btnCriar = new Button();
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
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 0;
            label1.Text = "Produto 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 1;
            label2.Text = "Preço 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 126);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 2;
            label3.Text = "Produto 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 178);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 3;
            label4.Text = "Preço 2";
            // 
            // txtProduto1
            // 
            txtProduto1.Font = new Font("Segoe UI", 12F);
            txtProduto1.Location = new Point(129, 8);
            txtProduto1.Name = "txtProduto1";
            txtProduto1.Size = new Size(125, 34);
            txtProduto1.TabIndex = 4;
            // 
            // txtPreco1
            // 
            txtPreco1.Font = new Font("Segoe UI", 12F);
            txtPreco1.Location = new Point(129, 59);
            txtPreco1.Name = "txtPreco1";
            txtPreco1.Size = new Size(125, 34);
            txtPreco1.TabIndex = 5;
            // 
            // txtProduto2
            // 
            txtProduto2.Font = new Font("Segoe UI", 12F);
            txtProduto2.Location = new Point(129, 120);
            txtProduto2.Name = "txtProduto2";
            txtProduto2.Size = new Size(125, 34);
            txtProduto2.TabIndex = 6;
            // 
            // txtPreco2
            // 
            txtPreco2.Font = new Font("Segoe UI", 12F);
            txtPreco2.Location = new Point(129, 172);
            txtPreco2.Name = "txtPreco2";
            txtPreco2.Size = new Size(125, 34);
            txtPreco2.TabIndex = 7;
            // 
            // btnCriar
            // 
            btnCriar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCriar.Location = new Point(53, 229);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(142, 49);
            btnCriar.TabIndex = 8;
            btnCriar.Text = "Criar tabela";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // panMsg
            // 
            panMsg.Controls.Add(lblMsg3);
            panMsg.Controls.Add(lblMsg2);
            panMsg.Controls.Add(lblMsg1);
            panMsg.Location = new Point(3, 317);
            panMsg.Name = "panMsg";
            panMsg.Size = new Size(275, 93);
            panMsg.TabIndex = 9;
            panMsg.Visible = false;
            // 
            // lblMsg3
            // 
            lblMsg3.AutoSize = true;
            lblMsg3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMsg3.Location = new Point(9, 56);
            lblMsg3.Name = "lblMsg3";
            lblMsg3.Size = new Size(119, 28);
            lblMsg3.TabIndex = 2;
            lblMsg3.Text = "Mensagem3";
            // 
            // lblMsg2
            // 
            lblMsg2.AutoSize = true;
            lblMsg2.Font = new Font("Segoe UI", 12F);
            lblMsg2.Location = new Point(9, 28);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(119, 28);
            lblMsg2.TabIndex = 1;
            lblMsg2.Text = "Mensagem2";
            // 
            // lblMsg1
            // 
            lblMsg1.AutoSize = true;
            lblMsg1.Font = new Font("Segoe UI", 12F);
            lblMsg1.Location = new Point(9, 0);
            lblMsg1.Name = "lblMsg1";
            lblMsg1.Size = new Size(119, 28);
            lblMsg1.TabIndex = 0;
            lblMsg1.Text = "Mensagem1";
            // 
            // Form1
            // 
            AcceptButton = btnCriar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 416);
            Controls.Add(panMsg);
            Controls.Add(btnCriar);
            Controls.Add(txtPreco2);
            Controls.Add(txtProduto2);
            Controls.Add(txtPreco1);
            Controls.Add(txtProduto1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preço";
            Load += Form1_Load;
            panMsg.ResumeLayout(false);
            panMsg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProduto1;
        private TextBox txtPreco1;
        private TextBox txtProduto2;
        private TextBox txtPreco2;
        private Button btnCriar;
        private Panel panMsg;
        private Label lblMsg1;
        private Label lblMsg2;
        private Label lblMsg3;
    }
}
