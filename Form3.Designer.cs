﻿
namespace Rabota
{
    partial class Form3
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
            this.matem = new System.Windows.Forms.Button();
            this.rus_z = new System.Windows.Forms.Button();
            this.liter = new System.Windows.Forms.Button();
            this.genshin = new System.Windows.Forms.Button();
            this.fio = new System.Windows.Forms.Label();
            this.Pochta = new System.Windows.Forms.Button();
            this.redprof = new System.Windows.Forms.Button();
            this.procent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matem
            // 
            this.matem.BackColor = System.Drawing.Color.Lime;
            this.matem.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matem.Location = new System.Drawing.Point(202, 137);
            this.matem.Name = "matem";
            this.matem.Size = new System.Drawing.Size(270, 67);
            this.matem.TabIndex = 0;
            this.matem.Text = "Математика";
            this.matem.UseVisualStyleBackColor = false;
            this.matem.Click += new System.EventHandler(this.matem_Click);
            // 
            // rus_z
            // 
            this.rus_z.BackColor = System.Drawing.Color.Lime;
            this.rus_z.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rus_z.Location = new System.Drawing.Point(202, 242);
            this.rus_z.Name = "rus_z";
            this.rus_z.Size = new System.Drawing.Size(270, 67);
            this.rus_z.TabIndex = 1;
            this.rus_z.Text = "Русский язык";
            this.rus_z.UseVisualStyleBackColor = false;
            // 
            // liter
            // 
            this.liter.BackColor = System.Drawing.Color.Lime;
            this.liter.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liter.Location = new System.Drawing.Point(202, 345);
            this.liter.Name = "liter";
            this.liter.Size = new System.Drawing.Size(270, 67);
            this.liter.TabIndex = 2;
            this.liter.Text = "Литература";
            this.liter.UseVisualStyleBackColor = false;
            // 
            // genshin
            // 
            this.genshin.BackColor = System.Drawing.Color.Lime;
            this.genshin.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genshin.Location = new System.Drawing.Point(202, 447);
            this.genshin.Name = "genshin";
            this.genshin.Size = new System.Drawing.Size(270, 67);
            this.genshin.TabIndex = 3;
            this.genshin.Text = "Геншин";
            this.genshin.UseVisualStyleBackColor = false;
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fio.Location = new System.Drawing.Point(994, 61);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(89, 36);
            this.fio.TabIndex = 4;
            this.fio.Text = "label1";
            // 
            // Pochta
            // 
            this.Pochta.BackColor = System.Drawing.Color.Lime;
            this.Pochta.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pochta.Location = new System.Drawing.Point(951, 163);
            this.Pochta.Name = "Pochta";
            this.Pochta.Size = new System.Drawing.Size(270, 67);
            this.Pochta.TabIndex = 5;
            this.Pochta.Text = "Почта";
            this.Pochta.UseVisualStyleBackColor = false;
            // 
            // redprof
            // 
            this.redprof.BackColor = System.Drawing.Color.Lime;
            this.redprof.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redprof.Location = new System.Drawing.Point(951, 259);
            this.redprof.Name = "redprof";
            this.redprof.Size = new System.Drawing.Size(270, 95);
            this.redprof.TabIndex = 6;
            this.redprof.Text = "Редактировать профиль";
            this.redprof.UseVisualStyleBackColor = false;
            // 
            // procent
            // 
            this.procent.BackColor = System.Drawing.Color.Lime;
            this.procent.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procent.Location = new System.Drawing.Point(951, 396);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(270, 87);
            this.procent.TabIndex = 7;
            this.procent.Text = "Процент выполнения";
            this.procent.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.redprof);
            this.Controls.Add(this.Pochta);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.genshin);
            this.Controls.Add(this.liter);
            this.Controls.Add(this.rus_z);
            this.Controls.Add(this.matem);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button matem;
        private System.Windows.Forms.Button rus_z;
        private System.Windows.Forms.Button liter;
        private System.Windows.Forms.Button genshin;
        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.Button Pochta;
        private System.Windows.Forms.Button redprof;
        private System.Windows.Forms.Button procent;
    }
}