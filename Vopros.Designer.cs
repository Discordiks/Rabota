
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_Question_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.kod1 = new System.Windows.Forms.TextBox();
            this.kodq = new System.Windows.Forms.TextBox();
            this.nameq = new System.Windows.Forms.TextBox();
            this.typeq = new System.Windows.Forms.TextBox();
            this.testq = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.kodsh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.testidDataGridViewTextBoxColumn,
            this.Type_Question_name});
            this.dataGridView1.DataSource = this.questionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1407, 494);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // testidDataGridViewTextBoxColumn
            // 
            this.testidDataGridViewTextBoxColumn.DataPropertyName = "test_id";
            this.testidDataGridViewTextBoxColumn.HeaderText = "Тест";
            this.testidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.testidDataGridViewTextBoxColumn.Name = "testidDataGridViewTextBoxColumn";
            // 
            // Type_Question_name
            // 
            this.Type_Question_name.DataPropertyName = "Type_Question_name";
            this.Type_Question_name.HeaderText = "Тип вопроса";
            this.Type_Question_name.MinimumWidth = 6;
            this.Type_Question_name.Name = "Type_Question_name";
            this.Type_Question_name.ReadOnly = true;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(Rabota.Entity.Question);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1421, 527);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1413, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вопросы";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1413, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Школьники";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1407, 494);
            this.dataGridView2.TabIndex = 0;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Lime;
            this.delete.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(31, 825);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.create.Location = new System.Drawing.Point(408, 825);
            this.create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.change.Location = new System.Drawing.Point(825, 825);
            this.change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(203, 66);
            this.change.TabIndex = 4;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // kod1
            // 
            this.kod1.Location = new System.Drawing.Point(59, 558);
            this.kod1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kod1.Name = "kod1";
            this.kod1.Size = new System.Drawing.Size(100, 22);
            this.kod1.TabIndex = 5;
            this.kod1.Text = "Код";
            // 
            // kodq
            // 
            this.kodq.Location = new System.Drawing.Point(408, 574);
            this.kodq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kodq.Name = "kodq";
            this.kodq.Size = new System.Drawing.Size(100, 22);
            this.kodq.TabIndex = 6;
            this.kodq.Text = "Код";
            // 
            // nameq
            // 
            this.nameq.Location = new System.Drawing.Point(408, 622);
            this.nameq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameq.Name = "nameq";
            this.nameq.Size = new System.Drawing.Size(100, 22);
            this.nameq.TabIndex = 7;
            this.nameq.Text = "Имя";
            // 
            // typeq
            // 
            this.typeq.Location = new System.Drawing.Point(408, 671);
            this.typeq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeq.Name = "typeq";
            this.typeq.Size = new System.Drawing.Size(100, 22);
            this.typeq.TabIndex = 8;
            this.typeq.Text = "Тип вопроса";
            // 
            // testq
            // 
            this.testq.Location = new System.Drawing.Point(408, 716);
            this.testq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testq.Name = "testq";
            this.testq.Size = new System.Drawing.Size(100, 22);
            this.testq.TabIndex = 9;
            this.testq.Text = "Тест";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(812, 716);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Тест";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(812, 671);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Тип вопроса";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(812, 622);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Имя";
            // 
            // kodsh
            // 
            this.kodsh.Location = new System.Drawing.Point(812, 574);
            this.kodsh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kodsh.Name = "kodsh";
            this.kodsh.Size = new System.Drawing.Size(100, 22);
            this.kodsh.TabIndex = 10;
            this.kodsh.Text = "Код";
            // 
            // Vopros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1421, 977);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.kodsh);
            this.Controls.Add(this.testq);
            this.Controls.Add(this.typeq);
            this.Controls.Add(this.nameq);
            this.Controls.Add(this.kodq);
            this.Controls.Add(this.kod1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.create);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Vopros";
            this.Text = "Redactor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox kodsh;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeQuestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Question_name;
    }
}