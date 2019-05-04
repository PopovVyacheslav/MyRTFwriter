namespace MyRTFwriter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельИнструментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.Panel();
            this.cms2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.скрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hattHint = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.cms1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вырезатьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.bRedo = new System.Windows.Forms.Button();
            this.bUndo = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.bPaste = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.bCut = new System.Windows.Forms.Button();
            this.bFileClose = new System.Windows.Forms.Button();
            this.bFileSave = new System.Windows.Forms.Button();
            this.bFileOpen = new System.Windows.Forms.Button();
            this.bFileNew = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.cms2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cms1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.создатьToolStripMenuItem.Text = "Созд&ать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.bFileNew_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.bFileOpen_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.bFileSave_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить &как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.выходToolStripMenuItem.Text = "&Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.bExit_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.панельИнструментовToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "&Вид";
            // 
            // панельИнструментовToolStripMenuItem
            // 
            this.панельИнструментовToolStripMenuItem.Checked = true;
            this.панельИнструментовToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.панельИнструментовToolStripMenuItem.Name = "панельИнструментовToolStripMenuItem";
            this.панельИнструментовToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.панельИнструментовToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.панельИнструментовToolStripMenuItem.Text = "&Панель инструментов";
            this.панельИнструментовToolStripMenuItem.Click += new System.EventHandler(this.панельИнструментовToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменаToolStripMenuItem,
            this.повторитьToolStripMenuItem,
            this.toolStripSeparator2,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "&Редактирование";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.вырезатьToolStripMenuItem.Text = "&Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.bCut_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.копироватьToolStripMenuItem.Text = "&Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.вставитьToolStripMenuItem.Text = "Вс&тавить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "&О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.ContextMenuStrip = this.cms2;
            this.ToolBar.Controls.Add(this.bRedo);
            this.ToolBar.Controls.Add(this.bUndo);
            this.ToolBar.Controls.Add(this.bExit);
            this.ToolBar.Controls.Add(this.bHelp);
            this.ToolBar.Controls.Add(this.bPaste);
            this.ToolBar.Controls.Add(this.bCopy);
            this.ToolBar.Controls.Add(this.bCut);
            this.ToolBar.Controls.Add(this.bFileClose);
            this.ToolBar.Controls.Add(this.bFileSave);
            this.ToolBar.Controls.Add(this.bFileOpen);
            this.ToolBar.Controls.Add(this.bFileNew);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(800, 48);
            this.ToolBar.TabIndex = 1;
            // 
            // cms2
            // 
            this.cms2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скрытьToolStripMenuItem});
            this.cms2.Name = "cms2";
            this.cms2.Size = new System.Drawing.Size(116, 26);
            // 
            // скрытьToolStripMenuItem
            // 
            this.скрытьToolStripMenuItem.Name = "скрытьToolStripMenuItem";
            this.скрытьToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.скрытьToolStripMenuItem.Text = "Скрыть";
            this.скрытьToolStripMenuItem.Click += new System.EventHandler(this.панельИнструментовToolStripMenuItem_Click);
            // 
            // hattHint
            // 
            this.hattHint.IsBalloon = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // rtbText
            // 
            this.rtbText.ContextMenuStrip = this.cms1;
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 72);
            this.rtbText.Name = "rtbText";
            this.rtbText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbText.Size = new System.Drawing.Size(800, 356);
            this.rtbText.TabIndex = 3;
            this.rtbText.Text = "";
            // 
            // cms1
            // 
            this.cms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem1,
            this.вставитьToolStripMenuItem1,
            this.вставитьToolStripMenuItem2});
            this.cms1.Name = "cms1";
            this.cms1.Size = new System.Drawing.Size(140, 70);
            // 
            // вырезатьToolStripMenuItem1
            // 
            this.вырезатьToolStripMenuItem1.Name = "вырезатьToolStripMenuItem1";
            this.вырезатьToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.вырезатьToolStripMenuItem1.Text = "Вырезать";
            this.вырезатьToolStripMenuItem1.Click += new System.EventHandler(this.bCut_Click);
            // 
            // вставитьToolStripMenuItem1
            // 
            this.вставитьToolStripMenuItem1.Name = "вставитьToolStripMenuItem1";
            this.вставитьToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem1.Text = "Копировать";
            this.вставитьToolStripMenuItem1.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // вставитьToolStripMenuItem2
            // 
            this.вставитьToolStripMenuItem2.Name = "вставитьToolStripMenuItem2";
            this.вставитьToolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem2.Text = "Вставить";
            this.вставитьToolStripMenuItem2.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // openFD
            // 
            this.openFD.Filter = "RTF файлы|*.rtf";
            this.openFD.Title = "Открыть";
            // 
            // saveFD
            // 
            this.saveFD.Filter = "RTF файлы|*.rtf";
            this.saveFD.Title = "Сохранить";
            // 
            // bRedo
            // 
            this.bRedo.Image = global::MyRTFwriter.Properties.Resources.redo;
            this.bRedo.Location = new System.Drawing.Point(271, 7);
            this.bRedo.Name = "bRedo";
            this.bRedo.Size = new System.Drawing.Size(36, 36);
            this.bRedo.TabIndex = 10;
            this.hattHint.SetToolTip(this.bRedo, "Повторить");
            this.bRedo.UseVisualStyleBackColor = true;
            this.bRedo.Click += new System.EventHandler(this.bRedo_Click);
            // 
            // bUndo
            // 
            this.bUndo.Image = global::MyRTFwriter.Properties.Resources.undo;
            this.bUndo.Location = new System.Drawing.Point(229, 7);
            this.bUndo.Name = "bUndo";
            this.bUndo.Size = new System.Drawing.Size(36, 36);
            this.bUndo.TabIndex = 9;
            this.hattHint.SetToolTip(this.bUndo, "Отменить");
            this.bUndo.UseVisualStyleBackColor = true;
            this.bUndo.Click += new System.EventHandler(this.bUndo_Click);
            // 
            // bExit
            // 
            this.bExit.Image = global::MyRTFwriter.Properties.Resources.exit;
            this.bExit.Location = new System.Drawing.Point(581, 7);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(36, 36);
            this.bExit.TabIndex = 8;
            this.hattHint.SetToolTip(this.bExit, "Выход");
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bHelp
            // 
            this.bHelp.Image = global::MyRTFwriter.Properties.Resources.help;
            this.bHelp.Location = new System.Drawing.Point(513, 7);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(36, 36);
            this.bHelp.TabIndex = 7;
            this.hattHint.SetToolTip(this.bHelp, "Справка");
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // bPaste
            // 
            this.bPaste.Image = global::MyRTFwriter.Properties.Resources.paste;
            this.bPaste.Location = new System.Drawing.Point(416, 7);
            this.bPaste.Name = "bPaste";
            this.bPaste.Size = new System.Drawing.Size(36, 36);
            this.bPaste.TabIndex = 6;
            this.hattHint.SetToolTip(this.bPaste, "Вставить");
            this.bPaste.UseVisualStyleBackColor = true;
            this.bPaste.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // bCopy
            // 
            this.bCopy.Image = global::MyRTFwriter.Properties.Resources.copy;
            this.bCopy.Location = new System.Drawing.Point(374, 7);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(36, 36);
            this.bCopy.TabIndex = 5;
            this.hattHint.SetToolTip(this.bCopy, "Копировать");
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // bCut
            // 
            this.bCut.Image = global::MyRTFwriter.Properties.Resources.cut;
            this.bCut.Location = new System.Drawing.Point(332, 7);
            this.bCut.Name = "bCut";
            this.bCut.Size = new System.Drawing.Size(36, 36);
            this.bCut.TabIndex = 4;
            this.hattHint.SetToolTip(this.bCut, "Вырезать");
            this.bCut.UseVisualStyleBackColor = true;
            this.bCut.Click += new System.EventHandler(this.bCut_Click);
            // 
            // bFileClose
            // 
            this.bFileClose.Image = global::MyRTFwriter.Properties.Resources.file_close;
            this.bFileClose.Location = new System.Drawing.Point(141, 7);
            this.bFileClose.Name = "bFileClose";
            this.bFileClose.Size = new System.Drawing.Size(36, 36);
            this.bFileClose.TabIndex = 3;
            this.hattHint.SetToolTip(this.bFileClose, "Закрыть");
            this.bFileClose.UseVisualStyleBackColor = true;
            this.bFileClose.Click += new System.EventHandler(this.bFileClose_Click);
            // 
            // bFileSave
            // 
            this.bFileSave.Image = global::MyRTFwriter.Properties.Resources.file_save;
            this.bFileSave.Location = new System.Drawing.Point(99, 7);
            this.bFileSave.Name = "bFileSave";
            this.bFileSave.Size = new System.Drawing.Size(36, 36);
            this.bFileSave.TabIndex = 2;
            this.hattHint.SetToolTip(this.bFileSave, "Сохранить");
            this.bFileSave.UseVisualStyleBackColor = true;
            this.bFileSave.Click += new System.EventHandler(this.bFileSave_Click);
            // 
            // bFileOpen
            // 
            this.bFileOpen.Image = global::MyRTFwriter.Properties.Resources.file_open;
            this.bFileOpen.Location = new System.Drawing.Point(57, 7);
            this.bFileOpen.Name = "bFileOpen";
            this.bFileOpen.Size = new System.Drawing.Size(36, 36);
            this.bFileOpen.TabIndex = 1;
            this.hattHint.SetToolTip(this.bFileOpen, "Открыть");
            this.bFileOpen.UseVisualStyleBackColor = true;
            this.bFileOpen.Click += new System.EventHandler(this.bFileOpen_Click);
            // 
            // bFileNew
            // 
            this.bFileNew.Image = global::MyRTFwriter.Properties.Resources.file_new;
            this.bFileNew.Location = new System.Drawing.Point(15, 7);
            this.bFileNew.Name = "bFileNew";
            this.bFileNew.Size = new System.Drawing.Size(36, 36);
            this.bFileNew.TabIndex = 0;
            this.hattHint.SetToolTip(this.bFileNew, "Создать");
            this.bFileNew.UseVisualStyleBackColor = true;
            this.bFileNew.Click += new System.EventHandler(this.bFileNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.отменаToolStripMenuItem.Text = "&Отменить";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.bUndo_Click);
            // 
            // повторитьToolStripMenuItem
            // 
            this.повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            this.повторитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.повторитьToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.повторитьToolStripMenuItem.Text = "&Повторить";
            this.повторитьToolStripMenuItem.Click += new System.EventHandler(this.bRedo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.cms2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cms1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельИнструментовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel ToolBar;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bPaste;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button bCut;
        private System.Windows.Forms.Button bFileClose;
        private System.Windows.Forms.Button bFileSave;
        private System.Windows.Forms.Button bFileOpen;
        private System.Windows.Forms.Button bFileNew;
        private System.Windows.Forms.ToolTip hattHint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.ContextMenuStrip cms1;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cms2;
        private System.Windows.Forms.ToolStripMenuItem скрытьToolStripMenuItem;
        private System.Windows.Forms.Button bRedo;
        private System.Windows.Forms.Button bUndo;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повторитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

