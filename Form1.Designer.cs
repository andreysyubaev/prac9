namespace prac9
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
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.Button();
            this.loadfile = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_paste = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(40, 42);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(214, 20);
            this.surname.TabIndex = 0;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(40, 94);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(214, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите фамилию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите имя";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 212);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_left
            // 
            this.button_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_left.Location = new System.Drawing.Point(40, 340);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(75, 43);
            this.button_left.TabIndex = 5;
            this.button_left.Text = "<<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_right.Location = new System.Drawing.Point(179, 340);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(75, 43);
            this.button_right.TabIndex = 6;
            this.button_right.Text = ">>";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // savefile
            // 
            this.savefile.Location = new System.Drawing.Point(308, 54);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(99, 53);
            this.savefile.TabIndex = 7;
            this.savefile.Text = "Сохранить в файл";
            this.savefile.UseVisualStyleBackColor = true;
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // loadfile
            // 
            this.loadfile.Location = new System.Drawing.Point(425, 54);
            this.loadfile.Name = "loadfile";
            this.loadfile.Size = new System.Drawing.Size(99, 53);
            this.loadfile.TabIndex = 8;
            this.loadfile.Text = "Загрузить из файла";
            this.loadfile.UseVisualStyleBackColor = true;
            this.loadfile.Click += new System.EventHandler(this.loadfile_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(344, 121);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(141, 23);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(344, 151);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(141, 23);
            this.button_edit.TabIndex = 10;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(344, 180);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(141, 23);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_paste
            // 
            this.button_paste.Location = new System.Drawing.Point(344, 209);
            this.button_paste.Name = "button_paste";
            this.button_paste.Size = new System.Drawing.Size(141, 23);
            this.button_paste.TabIndex = 12;
            this.button_paste.Text = "Вставить";
            this.button_paste.UseVisualStyleBackColor = true;
            this.button_paste.Click += new System.EventHandler(this.button_paste_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(344, 238);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(141, 23);
            this.button_clean.TabIndex = 13;
            this.button_clean.Text = "Очистить";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(344, 267);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(141, 23);
            this.button_sort.TabIndex = 14;
            this.button_sort.Text = "Сортировка";
            this.button_sort.UseVisualStyleBackColor = true;
            this.button_sort.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.button_sort);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_paste);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.loadfile);
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.surname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button savefile;
        private System.Windows.Forms.Button loadfile;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_paste;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_sort;
    }
}

