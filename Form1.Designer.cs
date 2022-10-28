
namespace Rabota
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Reg = new System.Windows.Forms.Button();
            this.RegEmail = new System.Windows.Forms.TextBox();
            this.RegPas = new System.Windows.Forms.TextBox();
            this.Avto = new System.Windows.Forms.TabControl();
            this.RegPage = new System.Windows.Forms.TabPage();
            this.Pochta = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outemail = new System.Windows.Forms.TextBox();
            this.logi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Avto.SuspendLayout();
            this.RegPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(284, 164);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(100, 23);
            this.Reg.TabIndex = 0;
            this.Reg.Text = "registracia";
            this.Reg.UseVisualStyleBackColor = true;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // RegEmail
            // 
            this.RegEmail.Location = new System.Drawing.Point(284, 62);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(100, 20);
            this.RegEmail.TabIndex = 1;
            // 
            // RegPas
            // 
            this.RegPas.Location = new System.Drawing.Point(284, 118);
            this.RegPas.Name = "RegPas";
            this.RegPas.PasswordChar = '*';
            this.RegPas.Size = new System.Drawing.Size(100, 20);
            this.RegPas.TabIndex = 2;
            // 
            // Avto
            // 
            this.Avto.Controls.Add(this.RegPage);
            this.Avto.Controls.Add(this.tabPage2);
            this.Avto.Location = new System.Drawing.Point(2, 3);
            this.Avto.Name = "Avto";
            this.Avto.SelectedIndex = 0;
            this.Avto.Size = new System.Drawing.Size(798, 242);
            this.Avto.TabIndex = 3;
            // 
            // RegPage
            // 
            this.RegPage.Controls.Add(this.label1);
            this.RegPage.Controls.Add(this.Pochta);
            this.RegPage.Controls.Add(this.RegEmail);
            this.RegPage.Controls.Add(this.Reg);
            this.RegPage.Controls.Add(this.RegPas);
            this.RegPage.Location = new System.Drawing.Point(4, 22);
            this.RegPage.Name = "RegPage";
            this.RegPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegPage.Size = new System.Drawing.Size(790, 216);
            this.RegPage.TabIndex = 0;
            this.RegPage.Text = "Registracia";
            this.RegPage.UseVisualStyleBackColor = true;
            // 
            // Pochta
            // 
            this.Pochta.AutoSize = true;
            this.Pochta.Location = new System.Drawing.Point(308, 46);
            this.Pochta.Name = "Pochta";
            this.Pochta.Size = new System.Drawing.Size(41, 13);
            this.Pochta.TabIndex = 3;
            this.Pochta.Text = "Pochta";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.outpass);
            this.tabPage2.Controls.Add(this.outemail);
            this.tabPage2.Controls.Add(this.logi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // outemail
            // 
            this.outemail.Location = new System.Drawing.Point(311, 44);
            this.outemail.Name = "outemail";
            this.outemail.Size = new System.Drawing.Size(100, 20);
            this.outemail.TabIndex = 1;
            // 
            // logi
            // 
            this.logi.Location = new System.Drawing.Point(311, 150);
            this.logi.Name = "logi";
            this.logi.Size = new System.Drawing.Size(100, 23);
            this.logi.TabIndex = 0;
            this.logi.Text = "login";
            this.logi.UseVisualStyleBackColor = true;
            this.logi.Click += new System.EventHandler(this.logi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parol";
            // 
            // outpass
            // 
            this.outpass.Location = new System.Drawing.Point(311, 106);
            this.outpass.Name = "outpass";
            this.outpass.PasswordChar = '*';
            this.outpass.Size = new System.Drawing.Size(100, 20);
            this.outpass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pochta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Avto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Avto.ResumeLayout(false);
            this.RegPage.ResumeLayout(false);
            this.RegPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.TextBox RegEmail;
        private System.Windows.Forms.TextBox RegPas;
        private System.Windows.Forms.TabControl Avto;
        private System.Windows.Forms.TabPage RegPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Pochta;
        private System.Windows.Forms.TextBox outemail;
        private System.Windows.Forms.Button logi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

