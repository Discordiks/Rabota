﻿
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outpass = new System.Windows.Forms.TextBox();
            this.outemail = new System.Windows.Forms.TextBox();
            this.logi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(599, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Почта";
            // 
            // outpass
            // 
            this.outpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.outpass.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outpass.Location = new System.Drawing.Point(606, 463);
            this.outpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outpass.Name = "outpass";
            this.outpass.PasswordChar = '*';
            this.outpass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.outpass.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.outpass.Size = new System.Drawing.Size(234, 42);
            this.outpass.TabIndex = 2;
            // 
            // outemail
            // 
            this.outemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.outemail.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outemail.Location = new System.Drawing.Point(605, 363);
            this.outemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outemail.Name = "outemail";
            this.outemail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.outemail.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.outemail.Size = new System.Drawing.Size(234, 42);
            this.outemail.TabIndex = 1;
            // 
            // logi
            // 
            this.logi.BackColor = System.Drawing.Color.Lime;
            this.logi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logi.Location = new System.Drawing.Point(439, 551);
            this.logi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logi.Name = "logi";
            this.logi.Size = new System.Drawing.Size(235, 33);
            this.logi.TabIndex = 0;
            this.logi.Text = "Войти";
            this.logi.UseVisualStyleBackColor = false;
            this.logi.Click += new System.EventHandler(this.logi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(786, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать аккаунт";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(588, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 106);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outpass);
            this.Controls.Add(this.logi);
            this.Controls.Add(this.outemail);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox outemail;
        private System.Windows.Forms.Button logi;
        private System.Windows.Forms.TextBox outpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

