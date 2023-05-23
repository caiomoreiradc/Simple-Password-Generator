﻿namespace ezPasswordGen
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            txtSenha = new TextBox();
            btnGerar = new Button();
            btnCopy = new Button();
            txtTamanho = new TextBox();
            Title = new Label();
            labelSize = new Label();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.White;
            txtSenha.Enabled = false;
            txtSenha.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSenha.ForeColor = Color.Black;
            txtSenha.Location = new Point(82, 81);
            txtSenha.MaxLength = 99;
            txtSenha.Name = "txtSenha";
            txtSenha.ReadOnly = true;
            txtSenha.Size = new Size(360, 21);
            txtSenha.TabIndex = 9999;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.White;
            btnGerar.Cursor = Cursors.Hand;
            btnGerar.FlatStyle = FlatStyle.Flat;
            btnGerar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerar.ForeColor = Color.Black;
            btnGerar.Location = new Point(134, 108);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(256, 46);
            btnGerar.TabIndex = 1;
            btnGerar.Text = "Generate!";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.White;
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Font = new Font("Nexa Heavy", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnCopy.ForeColor = Color.Black;
            btnCopy.Image = Properties.Resources.copybutton;
            btnCopy.Location = new Point(459, 77);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(30, 30);
            btnCopy.TabIndex = 2;
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // txtTamanho
            // 
            txtTamanho.BackColor = Color.White;
            txtTamanho.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTamanho.ForeColor = Color.Black;
            txtTamanho.Location = new Point(7, 81);
            txtTamanho.MaxLength = 2;
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(49, 21);
            txtTamanho.TabIndex = 0;
            txtTamanho.TextAlign = HorizontalAlignment.Center;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Slant", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(75, 7);
            Title.Name = "Title";
            Title.Size = new Size(374, 67);
            Title.TabIndex = 10000;
            Title.Text = "ezPasswords";
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.BackColor = Color.Transparent;
            labelSize.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSize.Location = new Point(16, 63);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(27, 15);
            labelSize.TabIndex = 10001;
            labelSize.Text = "Size";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.wallpaper;
            ClientSize = new Size(524, 169);
            Controls.Add(labelSize);
            Controls.Add(Title);
            Controls.Add(txtTamanho);
            Controls.Add(btnCopy);
            Controls.Add(btnGerar);
            Controls.Add(txtSenha);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            Text = "by - https://github.com/caiomoreiradc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private Button btnGerar;
        private Button btnCopy;
        private TextBox txtTamanho;
        private Label Title;
        private Label labelSize;
    }
}