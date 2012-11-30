namespace Crucify_Word
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordTranslateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordСловоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordLabel = new System.Windows.Forms.Label();
            this.addTranscriptionLabel = new System.Windows.Forms.Label();
            this.addTranslationLabel = new System.Windows.Forms.Label();
            this.addWordTextBox = new System.Windows.Forms.TextBox();
            this.addTranscriptionTextBox = new System.Windows.Forms.TextBox();
            this.addTranslationTextBox = new System.Windows.Forms.TextBox();
            this.addWordTipLabel = new System.Windows.Forms.Label();
            this.addWordPanel = new System.Windows.Forms.Panel();
            this.addWordButton = new System.Windows.Forms.Button();
            this.vocabularyPanel = new System.Windows.Forms.Panel();
            this.wordDataGridView = new System.Windows.Forms.DataGridView();
            this.wordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transcriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.addWordPanel.SuspendLayout();
            this.vocabularyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingToolStripMenuItem,
            this.vocabularyToolStripMenuItem,
            this.journalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trainingToolStripMenuItem
            // 
            this.trainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordTranslateToolStripMenuItem});
            this.trainingToolStripMenuItem.Name = "trainingToolStripMenuItem";
            this.trainingToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.trainingToolStripMenuItem.Text = "Тренировки";
            // 
            // wordTranslateToolStripMenuItem
            // 
            this.wordTranslateToolStripMenuItem.Name = "wordTranslateToolStripMenuItem";
            this.wordTranslateToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.wordTranslateToolStripMenuItem.Text = "Слово-перевод";
            this.wordTranslateToolStripMenuItem.Click += new System.EventHandler(this.wordTranslateToolStripMenuItem_Click);
            // 
            // vocabularyToolStripMenuItem
            // 
            this.vocabularyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordListToolStripMenuItem,
            this.addWordСловоToolStripMenuItem});
            this.vocabularyToolStripMenuItem.Name = "vocabularyToolStripMenuItem";
            this.vocabularyToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.vocabularyToolStripMenuItem.Text = "Словарь";
            // 
            // wordListToolStripMenuItem
            // 
            this.wordListToolStripMenuItem.Name = "wordListToolStripMenuItem";
            this.wordListToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.wordListToolStripMenuItem.Text = "Список";
            this.wordListToolStripMenuItem.Click += new System.EventHandler(this.wordListToolStripMenuItem_Click);
            // 
            // addWordСловоToolStripMenuItem
            // 
            this.addWordСловоToolStripMenuItem.Name = "addWordСловоToolStripMenuItem";
            this.addWordСловоToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addWordСловоToolStripMenuItem.Text = "Добавить слово";
            this.addWordСловоToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click);
            // 
            // journalToolStripMenuItem
            // 
            this.journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            this.journalToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.journalToolStripMenuItem.Text = "Журнал";
            // 
            // addWordLabel
            // 
            this.addWordLabel.AutoSize = true;
            this.addWordLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWordLabel.Location = new System.Drawing.Point(38, 40);
            this.addWordLabel.Name = "addWordLabel";
            this.addWordLabel.Size = new System.Drawing.Size(66, 22);
            this.addWordLabel.TabIndex = 1;
            this.addWordLabel.Text = "Слово";
            // 
            // addTranscriptionLabel
            // 
            this.addTranscriptionLabel.AutoSize = true;
            this.addTranscriptionLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTranscriptionLabel.Location = new System.Drawing.Point(38, 101);
            this.addTranscriptionLabel.Name = "addTranscriptionLabel";
            this.addTranscriptionLabel.Size = new System.Drawing.Size(131, 22);
            this.addTranscriptionLabel.TabIndex = 2;
            this.addTranscriptionLabel.Text = "Транскрипция";
            // 
            // addTranslationLabel
            // 
            this.addTranslationLabel.AutoSize = true;
            this.addTranslationLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTranslationLabel.Location = new System.Drawing.Point(38, 164);
            this.addTranslationLabel.Name = "addTranslationLabel";
            this.addTranslationLabel.Size = new System.Drawing.Size(88, 22);
            this.addTranslationLabel.TabIndex = 3;
            this.addTranslationLabel.Text = "Перевод";
            // 
            // addWordTextBox
            // 
            this.addWordTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWordTextBox.Location = new System.Drawing.Point(193, 37);
            this.addWordTextBox.Name = "addWordTextBox";
            this.addWordTextBox.Size = new System.Drawing.Size(248, 29);
            this.addWordTextBox.TabIndex = 4;
            this.addWordTextBox.TextChanged += new System.EventHandler(this.addWordTextBox_TextChanged);
            // 
            // addTranscriptionTextBox
            // 
            this.addTranscriptionTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTranscriptionTextBox.Location = new System.Drawing.Point(193, 98);
            this.addTranscriptionTextBox.Name = "addTranscriptionTextBox";
            this.addTranscriptionTextBox.Size = new System.Drawing.Size(248, 29);
            this.addTranscriptionTextBox.TabIndex = 5;
            // 
            // addTranslationTextBox
            // 
            this.addTranslationTextBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTranslationTextBox.Location = new System.Drawing.Point(193, 161);
            this.addTranslationTextBox.Name = "addTranslationTextBox";
            this.addTranslationTextBox.Size = new System.Drawing.Size(248, 29);
            this.addTranslationTextBox.TabIndex = 6;
            this.addTranslationTextBox.TextChanged += new System.EventHandler(this.addTranslationTextBox_TextChanged);
            // 
            // addWordTipLabel
            // 
            this.addWordTipLabel.AutoSize = true;
            this.addWordTipLabel.Location = new System.Drawing.Point(39, 9);
            this.addWordTipLabel.Name = "addWordTipLabel";
            this.addWordTipLabel.Size = new System.Drawing.Size(258, 14);
            this.addWordTipLabel.TabIndex = 7;
            this.addWordTipLabel.Text = "Транскрипцию и часть речи можно не указывать";
            // 
            // addWordPanel
            // 
            this.addWordPanel.Controls.Add(this.addWordButton);
            this.addWordPanel.Controls.Add(this.addWordTipLabel);
            this.addWordPanel.Controls.Add(this.addTranslationTextBox);
            this.addWordPanel.Controls.Add(this.addTranscriptionTextBox);
            this.addWordPanel.Controls.Add(this.addWordTextBox);
            this.addWordPanel.Controls.Add(this.addTranslationLabel);
            this.addWordPanel.Controls.Add(this.addTranscriptionLabel);
            this.addWordPanel.Controls.Add(this.addWordLabel);
            this.addWordPanel.Location = new System.Drawing.Point(118, 46);
            this.addWordPanel.Name = "addWordPanel";
            this.addWordPanel.Size = new System.Drawing.Size(518, 271);
            this.addWordPanel.TabIndex = 8;
            // 
            // addWordButton
            // 
            this.addWordButton.Enabled = false;
            this.addWordButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWordButton.Location = new System.Drawing.Point(193, 214);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(137, 35);
            this.addWordButton.TabIndex = 8;
            this.addWordButton.Text = "Добавить";
            this.addWordButton.UseVisualStyleBackColor = true;
            this.addWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // vocabularyPanel
            // 
            this.vocabularyPanel.Controls.Add(this.wordDataGridView);
            this.vocabularyPanel.Location = new System.Drawing.Point(12, 28);
            this.vocabularyPanel.Name = "vocabularyPanel";
            this.vocabularyPanel.Size = new System.Drawing.Size(870, 400);
            this.vocabularyPanel.TabIndex = 9;
            this.vocabularyPanel.Visible = false;
            // 
            // wordDataGridView
            // 
            this.wordDataGridView.AllowUserToAddRows = false;
            this.wordDataGridView.AllowUserToDeleteRows = false;
            this.wordDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.wordDataGridView.ColumnHeadersHeight = 30;
            this.wordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.wordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordColumn,
            this.transcriptionColumn,
            this.translationColumn,
            this.progressColumn});
            this.wordDataGridView.Location = new System.Drawing.Point(13, 16);
            this.wordDataGridView.Name = "wordDataGridView";
            this.wordDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.wordDataGridView.Size = new System.Drawing.Size(837, 368);
            this.wordDataGridView.TabIndex = 0;
            // 
            // wordColumn
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            this.wordColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.wordColumn.HeaderText = "Слово";
            this.wordColumn.MinimumWidth = 100;
            this.wordColumn.Name = "wordColumn";
            this.wordColumn.ReadOnly = true;
            this.wordColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wordColumn.Width = 230;
            // 
            // transcriptionColumn
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            this.transcriptionColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.transcriptionColumn.HeaderText = "Транскрипция";
            this.transcriptionColumn.MinimumWidth = 100;
            this.transcriptionColumn.Name = "transcriptionColumn";
            this.transcriptionColumn.ReadOnly = true;
            this.transcriptionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.transcriptionColumn.Width = 230;
            // 
            // translationColumn
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            this.translationColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.translationColumn.HeaderText = "Перевод";
            this.translationColumn.MinimumWidth = 100;
            this.translationColumn.Name = "translationColumn";
            this.translationColumn.ReadOnly = true;
            this.translationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.translationColumn.Width = 230;
            // 
            // progressColumn
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            this.progressColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.progressColumn.HeaderText = "Прогресс";
            this.progressColumn.MinimumWidth = 100;
            this.progressColumn.Name = "progressColumn";
            this.progressColumn.ReadOnly = true;
            this.progressColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 440);
            this.Controls.Add(this.vocabularyPanel);
            this.Controls.Add(this.addWordPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.addWordPanel.ResumeLayout(false);
            this.addWordPanel.PerformLayout();
            this.vocabularyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordTranslateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordСловоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalToolStripMenuItem;
        private System.Windows.Forms.Label addWordLabel;
        private System.Windows.Forms.Label addTranscriptionLabel;
        private System.Windows.Forms.Label addTranslationLabel;
        private System.Windows.Forms.TextBox addWordTextBox;
        private System.Windows.Forms.TextBox addTranscriptionTextBox;
        private System.Windows.Forms.TextBox addTranslationTextBox;
        private System.Windows.Forms.Label addWordTipLabel;
        private System.Windows.Forms.Panel addWordPanel;
        private System.Windows.Forms.Button addWordButton;
        private System.Windows.Forms.Panel vocabularyPanel;
        private System.Windows.Forms.DataGridView wordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transcriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn progressColumn;
    }
}

