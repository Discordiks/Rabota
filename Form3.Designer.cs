
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.rus_z.Location = new System.Drawing.Point(202, 245);
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
            this.liter.Location = new System.Drawing.Point(202, 352);
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
            this.genshin.Location = new System.Drawing.Point(193, 453);
            this.genshin.Name = "genshin";
            this.genshin.Size = new System.Drawing.Size(270, 67);
            this.genshin.TabIndex = 3;
            this.genshin.Text = "Геншин";
            this.genshin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1061, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}