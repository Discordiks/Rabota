
namespace Rabota
{
    partial class Vopros
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.delete = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.kod1 = new System.Windows.Forms.TextBox();
            this.kodq = new System.Windows.Forms.TextBox();
            this.nameq = new System.Windows.Forms.TextBox();
            this.typeq = new System.Windows.Forms.TextBox();
            this.testq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1408, 492);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1422, 527);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1414, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вопросы";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1414, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Школьники";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Lime;
            this.delete.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(40, 856);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(203, 66);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Lime;
            this.create.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(435, 839);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(203, 66);
            this.create.TabIndex = 3;
            this.create.Text = "Добавить";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.Lime;
            this.change.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(839, 839);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(203, 66);
            this.change.TabIndex = 4;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // kod1
            // 
            this.kod1.Location = new System.Drawing.Point(58, 557);
            this.kod1.Name = "kod1";
            this.kod1.Size = new System.Drawing.Size(100, 22);
            this.kod1.TabIndex = 5;
            this.kod1.Text = "Код";
            // 
            // kodq
            // 
            this.kodq.Location = new System.Drawing.Point(435, 574);
            this.kodq.Name = "kodq";
            this.kodq.Size = new System.Drawing.Size(100, 22);
            this.kodq.TabIndex = 6;
            this.kodq.Text = "Код";
            // 
            // nameq
            // 
            this.nameq.Location = new System.Drawing.Point(435, 621);
            this.nameq.Name = "nameq";
            this.nameq.Size = new System.Drawing.Size(100, 22);
            this.nameq.TabIndex = 7;
            this.nameq.Text = "Имя";
            // 
            // typeq
            // 
            this.typeq.Location = new System.Drawing.Point(435, 671);
            this.typeq.Name = "typeq";
            this.typeq.Size = new System.Drawing.Size(100, 22);
            this.typeq.TabIndex = 8;
            this.typeq.Text = "Тип вопроса";
            // 
            // testq
            // 
            this.testq.Location = new System.Drawing.Point(435, 716);
            this.testq.Name = "testq";
            this.testq.Size = new System.Drawing.Size(100, 22);
            this.testq.TabIndex = 9;
            this.testq.Text = "Тест";
            // 
            // Vopros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.testq);
            this.Controls.Add(this.typeq);
            this.Controls.Add(this.nameq);
            this.Controls.Add(this.kodq);
            this.Controls.Add(this.kod1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.create);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.tabControl1);
            this.Name = "Vopros";
            this.Text = "Redactor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox kod1;
        private System.Windows.Forms.TextBox kodq;
        private System.Windows.Forms.TextBox nameq;
        private System.Windows.Forms.TextBox typeq;
        private System.Windows.Forms.TextBox testq;
    }
}