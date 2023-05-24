namespace kp1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Write_stop = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.open_folder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Text_name = new System.Windows.Forms.TextBox();
            this.open_file = new System.Windows.Forms.Button();
            this.replace = new System.Windows.Forms.TextBox();
            this.rep = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.registr_click = new System.Windows.Forms.Button();
            this.Registr = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.number_of_words = new System.Windows.Forms.Button();
            this.Count_line = new System.Windows.Forms.Button();
            this.Write_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(815, 316);
            this.textBox1.TabIndex = 0;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(833, 12);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(808, 20);
            this.Path.TabIndex = 1;
            this.Path.Text = "Укажите полный путь для блокнота";
            this.Path.Enter += new System.EventHandler(this.Path_Enter);
            this.Path.Leave += new System.EventHandler(this.Path_Leave);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(833, 143);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(264, 66);
            this.Create.TabIndex = 3;
            this.Create.Text = "Создать файл";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Write_stop
            // 
            this.Write_stop.Location = new System.Drawing.Point(12, 334);
            this.Write_stop.Name = "Write_stop";
            this.Write_stop.Size = new System.Drawing.Size(240, 66);
            this.Write_stop.TabIndex = 4;
            this.Write_stop.Text = "Остновить запись в файл";
            this.Write_stop.UseVisualStyleBackColor = true;
            this.Write_stop.Click += new System.EventHandler(this.Write_Click);
            // 
            // open_folder
            // 
            this.open_folder.Location = new System.Drawing.Point(833, 64);
            this.open_folder.Name = "open_folder";
            this.open_folder.Size = new System.Drawing.Size(264, 73);
            this.open_folder.TabIndex = 5;
            this.open_folder.Text = "Открыть папку";
            this.open_folder.UseVisualStyleBackColor = true;
            this.open_folder.Click += new System.EventHandler(this.open_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Text_name
            // 
            this.Text_name.Location = new System.Drawing.Point(833, 38);
            this.Text_name.Name = "Text_name";
            this.Text_name.Size = new System.Drawing.Size(264, 20);
            this.Text_name.TabIndex = 7;
            this.Text_name.Text = "Укажите имя файла";
            this.Text_name.Enter += new System.EventHandler(this.Text_name_Enter);
            this.Text_name.Leave += new System.EventHandler(this.Text_name_Leave);
            // 
            // open_file
            // 
            this.open_file.Location = new System.Drawing.Point(1103, 64);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(264, 73);
            this.open_file.TabIndex = 8;
            this.open_file.Text = "Открыть файл";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.open_file_Click_1);
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(833, 241);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(264, 20);
            this.replace.TabIndex = 9;
            this.replace.Text = "Укажите слово или символ на котрое заменяете";
            this.replace.Enter += new System.EventHandler(this.replace_Enter);
            this.replace.Leave += new System.EventHandler(this.replace_Leave);
            // 
            // rep
            // 
            this.rep.Location = new System.Drawing.Point(833, 267);
            this.rep.Name = "rep";
            this.rep.Size = new System.Drawing.Size(264, 38);
            this.rep.TabIndex = 10;
            this.rep.Text = "заменить";
            this.rep.UseVisualStyleBackColor = true;
            this.rep.Click += new System.EventHandler(this.rep_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(833, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Укажите слово или символ котрое заменяете";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // registr_click
            // 
            this.registr_click.Location = new System.Drawing.Point(1104, 267);
            this.registr_click.Name = "registr_click";
            this.registr_click.Size = new System.Drawing.Size(297, 38);
            this.registr_click.TabIndex = 13;
            this.registr_click.Text = "заменить";
            this.registr_click.UseVisualStyleBackColor = true;
            this.registr_click.Click += new System.EventHandler(this.registr_click_Click);
            // 
            // Registr
            // 
            this.Registr.Location = new System.Drawing.Point(1103, 189);
            this.Registr.Name = "Registr";
            this.Registr.Size = new System.Drawing.Size(297, 20);
            this.Registr.TabIndex = 15;
            this.Registr.Text = "Укажите слово которое вы хотите заменить";
            this.Registr.Enter += new System.EventHandler(this.Registr_Enter);
            this.Registr.Leave += new System.EventHandler(this.Registr_Leave);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1104, 217);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Верхний регистр";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1103, 241);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(108, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Нижний регистр";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1221, 217);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Весь текст";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(528, 334);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(299, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "Укажите слово, чтобы узнать кол-во повторений";
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // number_of_words
            // 
            this.number_of_words.Location = new System.Drawing.Point(528, 362);
            this.number_of_words.Name = "number_of_words";
            this.number_of_words.Size = new System.Drawing.Size(297, 38);
            this.number_of_words.TabIndex = 20;
            this.number_of_words.Text = "Узнать";
            this.number_of_words.UseVisualStyleBackColor = true;
            this.number_of_words.Click += new System.EventHandler(this.number_of_words_Click);
            // 
            // Count_line
            // 
            this.Count_line.Location = new System.Drawing.Point(528, 423);
            this.Count_line.Name = "Count_line";
            this.Count_line.Size = new System.Drawing.Size(297, 59);
            this.Count_line.TabIndex = 21;
            this.Count_line.Text = "Узнать кол-во строк";
            this.Count_line.UseVisualStyleBackColor = true;
            this.Count_line.Click += new System.EventHandler(this.Count_line_Click);
            // 
            // Write_start
            // 
            this.Write_start.Location = new System.Drawing.Point(258, 334);
            this.Write_start.Name = "Write_start";
            this.Write_start.Size = new System.Drawing.Size(240, 66);
            this.Write_start.TabIndex = 22;
            this.Write_start.Text = "Начать запись в файл";
            this.Write_start.UseVisualStyleBackColor = true;
            this.Write_start.Click += new System.EventHandler(this.Write_start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1103, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 44);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 591);
            this.Controls.Add(this.Write_start);
            this.Controls.Add(this.Count_line);
            this.Controls.Add(this.number_of_words);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Registr);
            this.Controls.Add(this.registr_click);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.rep);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.Text_name);
            this.Controls.Add(this.open_folder);
            this.Controls.Add(this.Write_stop);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Write_stop;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button open_folder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Text_name;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.TextBox replace;
        private System.Windows.Forms.Button rep;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button registr_click;
        private System.Windows.Forms.TextBox Registr;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button number_of_words;
        private System.Windows.Forms.Button Count_line;
        private System.Windows.Forms.Button Write_start;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

