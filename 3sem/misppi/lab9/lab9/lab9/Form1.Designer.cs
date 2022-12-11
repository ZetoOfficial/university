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
            this.logLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "900*1000",
            "1100*1000",
            "1300*1100",
            "1400*1200",
            "1500*1280",
            "1600*1380"});
            this.comboBox1.Location = new System.Drawing.Point(22, 58);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 40);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.MouseHover += new System.EventHandler(this.comboBox1_MouseHover);
            // 
            // redBttn
            // 
            this.redBttn.AutoSize = true;
            this.redBttn.Location = new System.Drawing.Point(11, 47);
            this.redBttn.Margin = new System.Windows.Forms.Padding(6);
            this.redBttn.Name = "redBttn";
            this.redBttn.Size = new System.Drawing.Size(139, 36);
            this.redBttn.TabIndex = 5;
            this.redBttn.TabStop = true;
            this.redBttn.Text = "красный";
            this.redBttn.UseVisualStyleBackColor = true;
            this.redBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // blueBttn
            // 
            this.blueBttn.AutoSize = true;
            this.blueBttn.Location = new System.Drawing.Point(11, 100);
            this.blueBttn.Margin = new System.Windows.Forms.Padding(6);
            this.blueBttn.Name = "blueBttn";
            this.blueBttn.Size = new System.Drawing.Size(135, 36);
            this.blueBttn.TabIndex = 2;
            this.blueBttn.TabStop = true;
            this.blueBttn.Text = "голубой";
            this.blueBttn.UseVisualStyleBackColor = true;
            this.blueBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // greenBttn
            // 
            this.greenBttn.AutoSize = true;
            this.greenBttn.Location = new System.Drawing.Point(11, 154);
            this.greenBttn.Margin = new System.Windows.Forms.Padding(6);
            this.greenBttn.Name = "greenBttn";
            this.greenBttn.Size = new System.Drawing.Size(140, 36);
            this.greenBttn.TabIndex = 3;
            this.greenBttn.TabStop = true;
            this.greenBttn.Text = "зеленый";
            this.greenBttn.UseVisualStyleBackColor = true;
            this.greenBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // grayBttn
            // 
            this.grayBttn.AutoSize = true;
            this.grayBttn.Location = new System.Drawing.Point(11, 207);
            this.grayBttn.Margin = new System.Windows.Forms.Padding(6);
            this.grayBttn.Name = "grayBttn";
            this.grayBttn.Size = new System.Drawing.Size(114, 36);
            this.grayBttn.TabIndex = 4;
            this.grayBttn.TabStop = true;
            this.grayBttn.Text = "серый";
            this.grayBttn.UseVisualStyleBackColor = true;
            this.grayBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // whiteBttn
            // 
            this.whiteBttn.AutoSize = true;
            this.whiteBttn.Location = new System.Drawing.Point(11, 260);
            this.whiteBttn.Margin = new System.Windows.Forms.Padding(6);
            this.whiteBttn.Name = "whiteBttn";
            this.whiteBttn.Size = new System.Drawing.Size(116, 36);
            this.whiteBttn.TabIndex = 1;
            this.whiteBttn.TabStop = true;
            this.whiteBttn.Text = "белый";
            this.whiteBttn.UseVisualStyleBackColor = true;
            this.whiteBttn.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // yellowBttn
            // 
            this.yellowBttn.AutoSize = true;
            this.yellowBttn.Location = new System.Drawing.Point(11, 314);
            this.yellowBttn.Margin = new System.Windows.Forms.Padding(6);
            this.yellowBttn.Name = "yellowBttn";
            this.yellowBttn.Size = new System.Drawing.Size(130, 36);
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
            this.groupBox1.Location = new System.Drawing.Point(30, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(217, 371);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор цвета";
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // disableComboBox
            // 
            this.disableComboBox.AutoSize = true;
            this.disableComboBox.Location = new System.Drawing.Point(258, 166);
            this.disableComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.disableComboBox.Name = "disableComboBox";
            this.disableComboBox.Size = new System.Drawing.Size(461, 36);
            this.disableComboBox.TabIndex = 8;
            this.disableComboBox.Text = "Запрещение изменений в ComboBox";
            this.disableComboBox.UseVisualStyleBackColor = true;
            this.disableComboBox.CheckedChanged += new System.EventHandler(this.disableComboBox_CheckedChanged);
            this.disableComboBox.MouseHover += new System.EventHandler(this.disableComboBox_MouseHover);
            // 
            // disableRadioBox
            // 
            this.disableRadioBox.AutoSize = true;
            this.disableRadioBox.Location = new System.Drawing.Point(258, 220);
            this.disableRadioBox.Margin = new System.Windows.Forms.Padding(6);
            this.disableRadioBox.Name = "disableRadioBox";
            this.disableRadioBox.Size = new System.Drawing.Size(651, 36);
            this.disableRadioBox.TabIndex = 9;
            this.disableRadioBox.Text = "Запрещение изменений переключателей RadioButton";
            this.disableRadioBox.UseVisualStyleBackColor = true;
            this.disableRadioBox.CheckedChanged += new System.EventHandler(this.disableRadioBox_CheckedChanged);
            this.disableRadioBox.MouseHover += new System.EventHandler(this.disableRadioBox_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1350, 44);
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 36);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.MouseHover += new System.EventHandler(this.toolStripMenuItem1_MouseHover);
            // 
            // добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem
            // 
            this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem.Name = "добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem";
            this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem.Size = new System.Drawing.Size(1764, 44);
            this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem.Text = "Добавить элемент из TextBox1 в ListBox1";
            this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem.Click += new System.EventHandler(this.добавитьЭлементИзTextBox1ВListBox1ToolStripMenuItem_Click);
            // 
            // удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem
            // 
            this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem.Name = "удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem";
            this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem.Size = new System.Drawing.Size(1764, 44);
            this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem.Text = "Удалить элемент из ListBox1 и ListBox2";
            this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem.Click += new System.EventHandler(this.удалитьЭлементИзListBox1ИListBox2ToolStripMenuItem_Click);
            // 
            // произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem
            // 
            this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Name = "произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4Чи" +
    "слаВнестиВОтдельныйСписокListBox2ToolStripMenuItem";
            this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Size = new System.Drawing.Size(1764, 44);
            this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Text = "Произведение первых 4 положительных чисел, у которых дробная часть нечетная, если" +
    " есть, то эти 4 числа внести в отдельный список ListBox2";
            this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Click += new System.EventHandler(this.произведениеПервых4ПоложительныхЧиселУКоторыхДробнаяЧастьНечетнаяЕслиЕстьТоЭти4ЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem_Click);
            // 
            // среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem
            // 
            this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Name = "среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдел" +
    "ьныйСписокListBox2ToolStripMenuItem";
            this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Size = new System.Drawing.Size(1764, 44);
            this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Text = "Среднее геометрическое дробной части положительных чисел, если есть, то эти числа" +
    " внести в отдельный список ListBox2";
            this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem.Click += new System.EventHandler(this.среднееГеометрическоеДробнойЧастиПоложительныхЧиселЕслиЕстьТоЭтиЧислаВнестиВОтдельныйСписокListBox2ToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(258, 290);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(219, 196);
            this.listBox1.TabIndex = 11;
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 32;
            this.listBox2.Location = new System.Drawing.Point(492, 290);
            this.listBox2.Margin = new System.Windows.Forms.Padding(6);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(219, 196);
            this.listBox2.TabIndex = 12;
            this.listBox2.MouseHover += new System.EventHandler(this.listBox2_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(726, 290);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 196);
            this.textBox1.TabIndex = 13;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem,
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem,
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem,
            this.найтиПалиндромыToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(697, 156);
            this.contextMenuStrip1.Text = "Контекстное меню";
            // 
            // добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem
            // 
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem.Name = "добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem";
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem.Size = new System.Drawing.Size(696, 38);
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem.Text = "Добавить строку из TextBox2 в список ListBox3";
            this.добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem_Click);
            // 
            // удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem
            // 
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem.Name = "удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem";
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem.Size = new System.Drawing.Size(696, 38);
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem.Text = "Удалить выделенный элемент из списка ListBox3";
            this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem_Click);
            // 
            // найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem
            // 
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem.Name = "найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem";
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem.Size = new System.Drawing.Size(696, 38);
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem.Text = "Найти текст, составленный из строк макс и мин длины";
            this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem.Click += new System.EventHandler(this.найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem_Click);
            // 
            // найтиПалиндромыToolStripMenuItem
            // 
            this.найтиПалиндромыToolStripMenuItem.Name = "найтиПалиндромыToolStripMenuItem";
            this.найтиПалиндромыToolStripMenuItem.Size = new System.Drawing.Size(696, 38);
            this.найтиПалиндромыToolStripMenuItem.Text = "Найти палиндромы";
            this.найтиПалиндромыToolStripMenuItem.Click += new System.EventHandler(this.найтиПалиндромыToolStripMenuItem_Click);
            // 
            // listBox3
            // 
            this.listBox3.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 32;
            this.listBox3.Location = new System.Drawing.Point(492, 503);
            this.listBox3.Margin = new System.Windows.Forms.Padding(6);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox3.Size = new System.Drawing.Size(219, 196);
            this.listBox3.TabIndex = 14;
            this.listBox3.MouseHover += new System.EventHandler(this.listBox3_MouseHover);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(726, 503);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 196);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.MouseHover += new System.EventHandler(this.textBox2_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1031);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 26, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1350, 42);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(237, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(22, 503);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(99, 32);
            this.logLabel.TabIndex = 17;
            this.logLabel.Text = "loglabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 1073);
            this.Controls.Add(this.logLabel);
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
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem добавитьПустуюСтрокуИзTextBox2ВСписокListBox3ToolStripMenuItem;
        private ToolStripMenuItem удалитьВыделенныйЭлементИзСпискаListBox3ToolStripMenuItem;
        private ToolStripMenuItem найтиТекстСоставленныйИзСтрокМаксИМинДлиныToolStripMenuItem;
        private ToolStripMenuItem найтиПалиндромыToolStripMenuItem;
        private ListBox listBox3;
        private TextBox textBox2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label logLabel;
    }
}