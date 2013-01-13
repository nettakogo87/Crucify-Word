namespace Crucify_Word.PresentationLayer
{
    partial class MainWindow
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
            this.groupBoxAddCard = new System.Windows.Forms.GroupBox();
            this.buttonAddCard = new System.Windows.Forms.Button();
            this.textBoxTranslation = new System.Windows.Forms.TextBox();
            this.textBoxTranscription = new System.Windows.Forms.TextBox();
            this.textBoxForeignWord = new System.Windows.Forms.TextBox();
            this.labelTranslation = new System.Windows.Forms.Label();
            this.labelTranscription = new System.Windows.Forms.Label();
            this.labelForeignWord = new System.Windows.Forms.Label();
            this.buttonRemoveCard = new System.Windows.Forms.Button();
            this.groupBoxVocabulary = new System.Windows.Forms.GroupBox();
            this.dataGridViewCards = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForeignWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transcription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxAddCard.SuspendLayout();
            this.groupBoxVocabulary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCards)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddCard
            // 
            this.groupBoxAddCard.Controls.Add(this.buttonAddCard);
            this.groupBoxAddCard.Controls.Add(this.textBoxTranslation);
            this.groupBoxAddCard.Controls.Add(this.textBoxTranscription);
            this.groupBoxAddCard.Controls.Add(this.textBoxForeignWord);
            this.groupBoxAddCard.Controls.Add(this.labelTranslation);
            this.groupBoxAddCard.Controls.Add(this.labelTranscription);
            this.groupBoxAddCard.Controls.Add(this.labelForeignWord);
            this.groupBoxAddCard.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddCard.Name = "groupBoxAddCard";
            this.groupBoxAddCard.Size = new System.Drawing.Size(860, 100);
            this.groupBoxAddCard.TabIndex = 0;
            this.groupBoxAddCard.TabStop = false;
            this.groupBoxAddCard.Text = "Добавить Слово";
            // 
            // buttonAddCard
            // 
            this.buttonAddCard.Location = new System.Drawing.Point(694, 27);
            this.buttonAddCard.Name = "buttonAddCard";
            this.buttonAddCard.Size = new System.Drawing.Size(130, 23);
            this.buttonAddCard.TabIndex = 6;
            this.buttonAddCard.Text = "Добавить слово";
            this.buttonAddCard.UseVisualStyleBackColor = true;
            this.buttonAddCard.Click += new System.EventHandler(this.buttonAddCard_Click);
            // 
            // textBoxTranslation
            // 
            this.textBoxTranslation.Location = new System.Drawing.Point(508, 30);
            this.textBoxTranslation.Name = "textBoxTranslation";
            this.textBoxTranslation.Size = new System.Drawing.Size(180, 20);
            this.textBoxTranslation.TabIndex = 5;
            // 
            // textBoxTranscription
            // 
            this.textBoxTranscription.Location = new System.Drawing.Point(289, 30);
            this.textBoxTranscription.Name = "textBoxTranscription";
            this.textBoxTranscription.Size = new System.Drawing.Size(153, 20);
            this.textBoxTranscription.TabIndex = 4;
            // 
            // textBoxForeignWord
            // 
            this.textBoxForeignWord.Location = new System.Drawing.Point(54, 31);
            this.textBoxForeignWord.Name = "textBoxForeignWord";
            this.textBoxForeignWord.Size = new System.Drawing.Size(143, 20);
            this.textBoxForeignWord.TabIndex = 3;
            // 
            // labelTranslation
            // 
            this.labelTranslation.AutoSize = true;
            this.labelTranslation.Location = new System.Drawing.Point(448, 34);
            this.labelTranslation.Name = "labelTranslation";
            this.labelTranslation.Size = new System.Drawing.Size(54, 14);
            this.labelTranslation.TabIndex = 2;
            this.labelTranslation.Text = "Перевод:";
            // 
            // labelTranscription
            // 
            this.labelTranscription.AutoSize = true;
            this.labelTranscription.Location = new System.Drawing.Point(203, 34);
            this.labelTranscription.Name = "labelTranscription";
            this.labelTranscription.Size = new System.Drawing.Size(80, 14);
            this.labelTranscription.TabIndex = 1;
            this.labelTranscription.Text = "Транскрипция:";
            // 
            // labelForeignWord
            // 
            this.labelForeignWord.AutoSize = true;
            this.labelForeignWord.Location = new System.Drawing.Point(6, 34);
            this.labelForeignWord.Name = "labelForeignWord";
            this.labelForeignWord.Size = new System.Drawing.Size(42, 14);
            this.labelForeignWord.TabIndex = 0;
            this.labelForeignWord.Text = "Слово:";
            // 
            // buttonRemoveCard
            // 
            this.buttonRemoveCard.Location = new System.Drawing.Point(393, 19);
            this.buttonRemoveCard.Name = "buttonRemoveCard";
            this.buttonRemoveCard.Size = new System.Drawing.Size(130, 23);
            this.buttonRemoveCard.TabIndex = 2;
            this.buttonRemoveCard.Text = "Удалить слово";
            this.buttonRemoveCard.UseVisualStyleBackColor = true;
            this.buttonRemoveCard.Click += new System.EventHandler(this.buttonRemoveCard_Click);
            // 
            // groupBoxVocabulary
            // 
            this.groupBoxVocabulary.Controls.Add(this.dataGridViewCards);
            this.groupBoxVocabulary.Controls.Add(this.buttonRemoveCard);
            this.groupBoxVocabulary.Location = new System.Drawing.Point(12, 118);
            this.groupBoxVocabulary.Name = "groupBoxVocabulary";
            this.groupBoxVocabulary.Size = new System.Drawing.Size(860, 340);
            this.groupBoxVocabulary.TabIndex = 3;
            this.groupBoxVocabulary.TabStop = false;
            this.groupBoxVocabulary.Text = "Словарь";
            // 
            // dataGridViewCards
            // 
            this.dataGridViewCards.AllowUserToAddRows = false;
            this.dataGridViewCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ForeignWord,
            this.Transcription,
            this.Translation});
            this.dataGridViewCards.Location = new System.Drawing.Point(9, 48);
            this.dataGridViewCards.MultiSelect = false;
            this.dataGridViewCards.Name = "dataGridViewCards";
            this.dataGridViewCards.Size = new System.Drawing.Size(845, 286);
            this.dataGridViewCards.TabIndex = 3;
            this.dataGridViewCards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCards_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // ForeignWord
            // 
            this.ForeignWord.HeaderText = "Слово";
            this.ForeignWord.Name = "ForeignWord";
            this.ForeignWord.ReadOnly = true;
            this.ForeignWord.Width = 250;
            // 
            // Transcription
            // 
            this.Transcription.HeaderText = "Транскрипция";
            this.Transcription.Name = "Transcription";
            this.Transcription.ReadOnly = true;
            this.Transcription.Width = 250;
            // 
            // Translation
            // 
            this.Translation.HeaderText = "Перевод";
            this.Translation.Name = "Translation";
            this.Translation.ReadOnly = true;
            this.Translation.Width = 250;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 470);
            this.Controls.Add(this.groupBoxVocabulary);
            this.Controls.Add(this.groupBoxAddCard);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxAddCard.ResumeLayout(false);
            this.groupBoxAddCard.PerformLayout();
            this.groupBoxVocabulary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddCard;
        private System.Windows.Forms.Button buttonAddCard;
        private System.Windows.Forms.TextBox textBoxTranslation;
        private System.Windows.Forms.TextBox textBoxTranscription;
        private System.Windows.Forms.TextBox textBoxForeignWord;
        private System.Windows.Forms.Label labelTranslation;
        private System.Windows.Forms.Label labelTranscription;
        private System.Windows.Forms.Label labelForeignWord;
        private System.Windows.Forms.Button buttonRemoveCard;
        private System.Windows.Forms.GroupBox groupBoxVocabulary;
        private System.Windows.Forms.DataGridView dataGridViewCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn VID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VForeignWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn VTranscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn VTranslation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForeignWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transcription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Translation;
    }
}

