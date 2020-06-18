namespace cryptoSolver
{
    partial class MyFrom
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox_resource = new System.Windows.Forms.RichTextBox();
            this.richTextBox_result = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog_load = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_save = new System.Windows.Forms.SaveFileDialog();
            this.radioButtonShifr = new System.Windows.Forms.RadioButton();
            this.radioButtonDeshifr = new System.Windows.Forms.RadioButton();
            this.radioButtonCreateECP = new System.Windows.Forms.RadioButton();
            this.radioButtonCheckECP = new System.Windows.Forms.RadioButton();
            this.buttonGo = new System.Windows.Forms.Button();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox_resource);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox_result);
            this.splitContainer1.Size = new System.Drawing.Size(1138, 573);
            this.splitContainer1.SplitterDistance = 568;
            this.splitContainer1.TabIndex = 0;
            // 
            // richTextBox_resource
            // 
            this.richTextBox_resource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_resource.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_resource.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_resource.Name = "richTextBox_resource";
            this.richTextBox_resource.Size = new System.Drawing.Size(566, 571);
            this.richTextBox_resource.TabIndex = 0;
            this.richTextBox_resource.Text = "";
            // 
            // richTextBox_result
            // 
            this.richTextBox_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_result.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_result.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_result.Name = "richTextBox_result";
            this.richTextBox_result.Size = new System.Drawing.Size(564, 571);
            this.richTextBox_result.TabIndex = 0;
            this.richTextBox_result.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1138, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 19);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // radioButtonShifr
            // 
            this.radioButtonShifr.Checked = true;
            this.radioButtonShifr.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShifr.Location = new System.Drawing.Point(881, 607);
            this.radioButtonShifr.Name = "radioButtonShifr";
            this.radioButtonShifr.Size = new System.Drawing.Size(129, 24);
            this.radioButtonShifr.TabIndex = 2;
            this.radioButtonShifr.TabStop = true;
            this.radioButtonShifr.Text = "Зашифровать";
            this.radioButtonShifr.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeshifr
            // 
            this.radioButtonDeshifr.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDeshifr.Location = new System.Drawing.Point(881, 637);
            this.radioButtonDeshifr.Name = "radioButtonDeshifr";
            this.radioButtonDeshifr.Size = new System.Drawing.Size(129, 24);
            this.radioButtonDeshifr.TabIndex = 3;
            this.radioButtonDeshifr.Text = "Расшифровать";
            this.radioButtonDeshifr.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreateECP
            // 
            this.radioButtonCreateECP.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCreateECP.Location = new System.Drawing.Point(881, 667);
            this.radioButtonCreateECP.Name = "radioButtonCreateECP";
            this.radioButtonCreateECP.Size = new System.Drawing.Size(129, 24);
            this.radioButtonCreateECP.TabIndex = 4;
            this.radioButtonCreateECP.Text = "Сделать ЭЦП";
            this.radioButtonCreateECP.UseVisualStyleBackColor = true;
            // 
            // radioButtonCheckECP
            // 
            this.radioButtonCheckECP.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCheckECP.Location = new System.Drawing.Point(881, 697);
            this.radioButtonCheckECP.Name = "radioButtonCheckECP";
            this.radioButtonCheckECP.Size = new System.Drawing.Size(137, 24);
            this.radioButtonCheckECP.TabIndex = 5;
            this.radioButtonCheckECP.Text = "Проверить ЭЦП";
            this.radioButtonCheckECP.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(1039, 646);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(87, 35);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Запуск";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxMessage.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMessage.Location = new System.Drawing.Point(1, 602);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(874, 129);
            this.richTextBoxMessage.TabIndex = 7;
            this.richTextBoxMessage.Text = "";
            // 
            // MyFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 735);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.radioButtonCheckECP);
            this.Controls.Add(this.radioButtonCreateECP);
            this.Controls.Add(this.radioButtonDeshifr);
            this.Controls.Add(this.radioButtonShifr);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для симметричного шифрования/дешифрования";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox_resource;
        private System.Windows.Forms.RichTextBox richTextBox_result;
        private System.Windows.Forms.OpenFileDialog openFileDialog_load;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_save;
        private System.Windows.Forms.RadioButton radioButtonShifr;
        private System.Windows.Forms.RadioButton radioButtonDeshifr;
        private System.Windows.Forms.RadioButton radioButtonCreateECP;
        private System.Windows.Forms.RadioButton radioButtonCheckECP;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
    }
}

