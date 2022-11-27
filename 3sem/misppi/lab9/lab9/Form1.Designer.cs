namespace lab9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.redBttn = new System.Windows.Forms.RadioButton();
            this.blueBttn = new System.Windows.Forms.RadioButton();
            this.greenBttn = new System.Windows.Forms.RadioButton();
            this.grayBttn = new System.Windows.Forms.RadioButton();
            this.whiteBttn = new System.Windows.Forms.RadioButton();
            this.yellowBttn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disableComboBox = new System.Windows.Forms.CheckBox();
            this.disableRadioBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromListBox1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изListBox2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиПалиндромыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "500*500",
            "600*700",
            "800*700",
            "900*700",
            "1000*800",
            "1280*720"});
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseHover += new System.EventHandler(this.comboBox1_MouseHover);
            // 
            // redBttn
            // 
            this.redBttn.AutoSize = true;
            this.redBttn.Location = new System.Drawing.Point(6, 22);
            this.redBttn.Name = "redBttn";
            this.redBttn.Size = new System.Drawing.Size(73, 19);
            this.redBttn.TabIndex = 5;
            this.redBttn.TabStop = true;
            this.redBttn.Text = "красный";
            this.redBttn.UseVisualStyleBackColor = true;
            this.redBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // blueBttn
            // 
            this.blueBttn.AutoSize = true;
            this.blueBttn.Location = new System.Drawing.Point(6, 47);
            this.blueBttn.Name = "blueBttn";
            this.blueBttn.Size = new System.Drawing.Size(71, 19);
            this.blueBttn.TabIndex = 2;
            this.blueBttn.TabStop = true;
            this.blueBttn.Text = "голубой";
            this.blueBttn.UseVisualStyleBackColor = true;
            this.blueBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // greenBttn
            // 
            this.greenBttn.AutoSize = true;
            this.greenBttn.Location = new System.Drawing.Point(6, 72);
            this.greenBttn.Name = "greenBttn";
            this.greenBttn.Size = new System.Drawing.Size(72, 19);
            this.greenBttn.TabIndex = 3;
            this.greenBttn.TabStop = true;
            this.greenBttn.Text = "зеленый";
            this.greenBttn.UseVisualStyleBackColor = true;
            this.greenBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // grayBttn
            // 
            this.grayBttn.AutoSize = true;
            this.grayBttn.Location = new System.Drawing.Point(6, 97);
            this.grayBttn.Name = "grayBttn";
            this.grayBttn.Size = new System.Drawing.Size(60, 19);
            this.grayBttn.TabIndex = 4;
            this.grayBttn.TabStop = true;
            this.grayBttn.Text = "серый";
            this.grayBttn.UseVisualStyleBackColor = true;
            this.grayBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // whiteBttn
            // 
            this.whiteBttn.AutoSize = true;
            this.whiteBttn.Location = new System.Drawing.Point(6, 122);
            this.whiteBttn.Name = "whiteBttn";
            this.whiteBttn.Size = new System.Drawing.Size(61, 19);
            this.whiteBttn.TabIndex = 1;
            this.whiteBttn.TabStop = true;
            this.whiteBttn.Text = "белый";
            this.whiteBttn.UseVisualStyleBackColor = true;
            this.whiteBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // yellowBttn
            // 
            this.yellowBttn.AutoSize = true;
            this.yellowBttn.Location = new System.Drawing.Point(6, 147);
            this.yellowBttn.Name = "yellowBttn";
            this.yellowBttn.Size = new System.Drawing.Size(68, 19);
            this.yellowBttn.TabIndex = 6;
            this.yellowBttn.TabStop = true;
            this.yellowBttn.Text = "желтый";
            this.yellowBttn.UseVisualStyleBackColor = true;
            this.yellowBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.redBttn);
            this.groupBox1.Controls.Add(this.yellowBttn);
            this.groupBox1.Controls.Add(this.blueBttn);
            this.groupBox1.Controls.Add(this.whiteBttn);
            this.groupBox1.Controls.Add(this.greenBttn);
            this.groupBox1.Controls.Add(this.grayBttn);
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор цвета";
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // disableComboBox
            // 
            this.disableComboBox.AutoSize = true;
            this.disableComboBox.Location = new System.Drawing.Point(139, 78);
            this.disableComboBox.Name = "disableComboBox";
            this.disableComboBox.Size = new System.Drawing.Size(232, 19);
            this.disableComboBox.TabIndex = 8;
            this.disableComboBox.Text = "Запрещение изменений в ComboBox";
            this.disableComboBox.UseVisualStyleBackColor = true;
            this.disableComboBox.MouseHover += new System.EventHandler(this.disableComboBox_MouseHover);
            // 
            // disableRadioBox
            // 
            this.disableRadioBox.AutoSize = true;
            this.disableRadioBox.Location = new System.Drawing.Point(139, 103);
            this.disableRadioBox.Name = "disableRadioBox";
            this.disableRadioBox.Size = new System.Drawing.Size(325, 19);
            this.disableRadioBox.TabIndex = 9;
            this.disableRadioBox.Text = "Запрещение изменений переключателей RadioButton";
            this.disableRadioBox.UseVisualStyleBackColor = true;
            this.disableRadioBox.CheckedChanged += new System.EventHandler(this.disableRadioBox_CheckedChanged);
            this.disableRadioBox.MouseHover += new System.EventHandler(this.disableRadioBox_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem,
            this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem,
            this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem,
            this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.MouseHover += new System.EventHandler(this.toolStripMenuItem1_MouseHover);
            // 
            // добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem
            // 
            this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem.Name = "добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem";
            this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem.Size = new System.Drawing.Size(875, 22);
            this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem.Text = "Добавить элемент из TextBox1 в ListBox1";
            this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem.Click += new System.EventHandler(this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem_Click);
            // 
            // удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem
            // 
            this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromListBox1ToolStripMenuItem,
            this.изListBox2ToolStripMenuItem});
            this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem.Name = "удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem";
            this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem.Size = new System.Drawing.Size(875, 22);
            this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem.Text = "Удалить элемент из ListBox1 и ListBox2";
            // 
            // fromListBox1ToolStripMenuItem
            // 
            this.fromListBox1ToolStripMenuItem.Name = "fromListBox1ToolStripMenuItem";
            this.fromListBox1ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fromListBox1ToolStripMenuItem.Text = "Из ListBox1";
            this.fromListBox1ToolStripMenuItem.Click += new System.EventHandler(this.fromListBox1ToolStripMenuItem_Click);
            // 
            // изListBox2ToolStripMenuItem
            // 
            this.изListBox2ToolStripMenuItem.Name = "изListBox2ToolStripMenuItem";
            this.изListBox2ToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.изListBox2ToolStripMenuItem.Text = "Из ListBox2";
            this.изListBox2ToolStripMenuItem.Click += new System.EventHandler(this.изListBox2ToolStripMenuItem_Click);
            // 
            // произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem
            // 
            this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Name = "произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4Чи" +
    "слаВнестиВОтдельныйСписокListBox2ToolStripMenuItem";
            this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Size = new System.Drawing.Size(875, 22);
            this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Text = "Произведение первых 4 положительных чисел, у которых дробная часть нечетная, если" +
    " есть, то эти 4 числа внести в отдельный список ListBox2";
            this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Click += new System.EventHandler(this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem_Click);
            // 
            // среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem
            // 
            this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Name = "среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдел" +
    "ьныйСписокListBox2ToolStripMenuItem";
            this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Size = new System.Drawing.Size(875, 22);
            this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Text = "Среднее геометрическое дробной части положительных чисел, если есть, то эти числа" +
    " внести в отдельный список ListBox2";
            this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Click += new System.EventHandler(this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(139, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 94);
            this.listBox1.TabIndex = 11;
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(265, 136);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 94);
            this.listBox2.TabIndex = 12;
            this.listBox2.MouseHover += new System.EventHandler(this.listBox2_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 136);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 94);
            this.textBox1.TabIndex = 13;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem,
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem,
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem,
            this.найтиПалиндромыToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(379, 92);
            this.contextMenuStrip1.Text = "Контекстное меню";
            // 
            // добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem
            // 
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem.Name = "добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem";
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem.Size = new System.Drawing.Size(378, 22);
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem.Text = "Добавить строку из TextBox2 в список ListBox3";
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem_Click);
            // 
            // удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem
            // 
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem.Name = "удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem";
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem.Size = new System.Drawing.Size(378, 22);
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem.Text = "Удалить выделенный элемент из списка ListBox3";
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem_Click);
            // 
            // найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem
            // 
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem.Name = "найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem";
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem.Size = new System.Drawing.Size(378, 22);
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem.Text = "Найти текст, составленный из строк макс и мин длины";
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem.Click += new System.EventHandler(this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem_Click);
            // 
            // найтиПалиндромыToolStripMenuItem
            // 
            this.найтиПалиндромыToolStripMenuItem.Name = "найтиПалиндромыToolStripMenuItem";
            this.найтиПалиндромыToolStripMenuItem.Size = new System.Drawing.Size(378, 22);
            this.найтиПалиндромыToolStripMenuItem.Text = "Найти палиндромы";
            this.найтиПалиндромыToolStripMenuItem.Click += new System.EventHandler(this.найтиПалиндромыToolStripMenuItem_Click);
            // 
            // listBox3
            // 
            this.listBox3.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(265, 236);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 94);
            this.listBox3.TabIndex = 14;
            this.listBox3.MouseHover += new System.EventHandler(this.listBox3_MouseHover);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 236);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 94);
            this.textBox2.TabIndex = 15;
            this.textBox2.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 481);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(727, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 503);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.disableRadioBox);
            this.Controls.Add(this.disableComboBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private RadioButton redBttn;
        private RadioButton blueBttn;
        private RadioButton greenBttn;
        private RadioButton grayBttn;
        private RadioButton whiteBttn;
        private RadioButton yellowBttn;
        private GroupBox groupBox1;
        private CheckBox disableComboBox;
        private CheckBox disableRadioBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private ToolStripMenuItem удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem;
        private ToolStripMenuItem произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem;
        private ToolStripMenuItem среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem;
        private ToolStripMenuItem fromListBox1ToolStripMenuItem;
        private ToolStripMenuItem изListBox2ToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem;
        private ToolStripMenuItem удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem;
        private ToolStripMenuItem найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem;
        private ToolStripMenuItem найтиПалиндромыToolStripMenuItem;
        private ListBox listBox3;
        private TextBox textBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}