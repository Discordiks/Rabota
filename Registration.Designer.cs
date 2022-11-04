
namespace Rabota
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Pochta = new System.Windows.Forms.Label();
            this.RegEmail = new System.Windows.Forms.TextBox();
            this.Reg = new System.Windows.Forms.Button();
            this.RegPas = new System.Windows.Forms.TextBox();
            this.faml = new System.Windows.Forms.Label();
            this.imal = new System.Windows.Forms.Label();
            this.otchl = new System.Windows.Forms.Label();
            this.datahbl = new System.Windows.Forms.Label();
            this.Regfam = new System.Windows.Forms.TextBox();
            this.Regima = new System.Windows.Forms.TextBox();
            this.Regotch = new System.Windows.Forms.TextBox();
            this.Regdatahb = new System.Windows.Forms.TextBox();
            this.Regl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(789, 473);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Пароль";
            // 
            // Pochta
            // 
            this.Pochta.AutoSize = true;
            this.Pochta.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pochta.Location = new System.Drawing.Point(789, 373);
            this.Pochta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pochta.Name = "Pochta";
            this.Pochta.Size = new System.Drawing.Size(212, 36);
            this.Pochta.TabIndex = 8;
            this.Pochta.Text = "Логин (почта)";
            // 
            // RegEmail
            // 
            this.RegEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegEmail.Location = new System.Drawing.Point(790, 413);
            this.RegEmail.Margin = new System.Windows.Forms.Padding(4);
            this.RegEmail.Name = "RegEmail";
            this.RegEmail.Size = new System.Drawing.Size(347, 42);
            this.RegEmail.TabIndex = 6;
            // 
            // Reg
            // 
            this.Reg.BackColor = System.Drawing.Color.Lime;
            this.Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Reg.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reg.Location = new System.Drawing.Point(523, 632);
            this.Reg.Margin = new System.Windows.Forms.Padding(4);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(413, 45);
            this.Reg.TabIndex = 5;
            this.Reg.Text = "Зарегистрироваться";
            this.Reg.UseVisualStyleBackColor = false;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // RegPas
            // 
            this.RegPas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RegPas.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPas.Location = new System.Drawing.Point(790, 513);
            this.RegPas.Margin = new System.Windows.Forms.Padding(4);
            this.RegPas.Name = "RegPas";
            this.RegPas.PasswordChar = '*';
            this.RegPas.Size = new System.Drawing.Size(347, 42);
            this.RegPas.TabIndex = 7;
            // 
            // faml
            // 
            this.faml.AutoSize = true;
            this.faml.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faml.Location = new System.Drawing.Point(315, 274);
            this.faml.Name = "faml";
            this.faml.Size = new System.Drawing.Size(158, 36);
            this.faml.TabIndex = 10;
            this.faml.Text = "Фамилия";
            // 
            // imal
            // 
            this.imal.AutoSize = true;
            this.imal.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imal.Location = new System.Drawing.Point(315, 373);
            this.imal.Name = "imal";
            this.imal.Size = new System.Drawing.Size(79, 36);
            this.imal.TabIndex = 11;
            this.imal.Text = "Имя";
            // 
            // otchl
            // 
            this.otchl.AutoSize = true;
            this.otchl.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otchl.Location = new System.Drawing.Point(313, 473);
            this.otchl.Name = "otchl";
            this.otchl.Size = new System.Drawing.Size(150, 36);
            this.otchl.TabIndex = 12;
            this.otchl.Text = "Отчество";
            // 
            // datahbl
            // 
            this.datahbl.AutoSize = true;
            this.datahbl.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datahbl.Location = new System.Drawing.Point(789, 274);
            this.datahbl.Name = "datahbl";
            this.datahbl.Size = new System.Drawing.Size(246, 36);
            this.datahbl.TabIndex = 13;
            this.datahbl.Text = "Дата рождения";
            // 
            // Regfam
            // 
            this.Regfam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Regfam.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regfam.Location = new System.Drawing.Point(319, 314);
            this.Regfam.Margin = new System.Windows.Forms.Padding(4);
            this.Regfam.Name = "Regfam";
            this.Regfam.Size = new System.Drawing.Size(347, 42);
            this.Regfam.TabIndex = 14;
            // 
            // Regima
            // 
            this.Regima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Regima.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regima.Location = new System.Drawing.Point(319, 413);
            this.Regima.Margin = new System.Windows.Forms.Padding(4);
            this.Regima.Name = "Regima";
            this.Regima.Size = new System.Drawing.Size(347, 42);
            this.Regima.TabIndex = 15;
            // 
            // Regotch
            // 
            this.Regotch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Regotch.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regotch.Location = new System.Drawing.Point(319, 513);
            this.Regotch.Margin = new System.Windows.Forms.Padding(4);
            this.Regotch.Name = "Regotch";
            this.Regotch.Size = new System.Drawing.Size(347, 42);
            this.Regotch.TabIndex = 16;
            // 
            // Regdatahb
            // 
            this.Regdatahb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Regdatahb.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regdatahb.Location = new System.Drawing.Point(790, 314);
            this.Regdatahb.Margin = new System.Windows.Forms.Padding(4);
            this.Regdatahb.Name = "Regdatahb";
            this.Regdatahb.Size = new System.Drawing.Size(352, 42);
            this.Regdatahb.TabIndex = 17;
            // 
            // Regl
            // 
            this.Regl.AutoSize = true;
            this.Regl.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Regl.Location = new System.Drawing.Point(509, 163);
            this.Regl.Name = "Regl";
            this.Regl.Size = new System.Drawing.Size(427, 80);
            this.Regl.TabIndex = 18;
            this.Regl.Text = "Регистрация";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.Regl);
            this.Controls.Add(this.Regdatahb);
            this.Controls.Add(this.Regotch);
            this.Controls.Add(this.Regima);
            this.Controls.Add(this.Regfam);
            this.Controls.Add(this.datahbl);
            this.Controls.Add(this.otchl);
            this.Controls.Add(this.imal);
            this.Controls.Add(this.faml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pochta);
            this.Controls.Add(this.RegEmail);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.RegPas);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pochta;
        private System.Windows.Forms.TextBox RegEmail;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.TextBox RegPas;
        private System.Windows.Forms.Label faml;
        private System.Windows.Forms.Label imal;
        private System.Windows.Forms.Label otchl;
        private System.Windows.Forms.Label datahbl;
        private System.Windows.Forms.TextBox Regfam;
        private System.Windows.Forms.TextBox Regima;
        private System.Windows.Forms.TextBox Regotch;
        private System.Windows.Forms.TextBox Regdatahb;
        private System.Windows.Forms.Label Regl;
    }
}