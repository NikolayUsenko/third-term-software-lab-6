namespace software_lab6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnChooseFileWithData = new Button();
            txtChooseFileWithData = new TextBox();
            btnChooseFolderToSave = new Button();
            txtChooseFolderToSave = new TextBox();
            btnChooseFont = new Button();
            txtChooseFont = new TextBox();
            textBoxN = new TextBox();
            textBoxInputN = new TextBox();
            btnCalcU = new Button();
            btnCloseForm = new Button();
            SuspendLayout();
            // 
            // btnChooseFileWithData
            // 
            btnChooseFileWithData.AutoSize = true;
            btnChooseFileWithData.Location = new Point(38, 29);
            btnChooseFileWithData.Margin = new Padding(2);
            btnChooseFileWithData.Name = "btnChooseFileWithData";
            btnChooseFileWithData.Size = new Size(203, 36);
            btnChooseFileWithData.TabIndex = 0;
            btnChooseFileWithData.Text = "Выбор файла с данными";
            btnChooseFileWithData.UseVisualStyleBackColor = true;
            btnChooseFileWithData.Click += btnChooseFileWithData_Click;
            // 
            // txtChooseFileWithData
            // 
            txtChooseFileWithData.Location = new Point(283, 36);
            txtChooseFileWithData.Margin = new Padding(2);
            txtChooseFileWithData.Name = "txtChooseFileWithData";
            txtChooseFileWithData.Size = new Size(306, 27);
            txtChooseFileWithData.TabIndex = 1;
            // 
            // btnChooseFolderToSave
            // 
            btnChooseFolderToSave.AutoSize = true;
            btnChooseFolderToSave.Location = new Point(38, 85);
            btnChooseFolderToSave.Margin = new Padding(2);
            btnChooseFolderToSave.Name = "btnChooseFolderToSave";
            btnChooseFolderToSave.Size = new Size(203, 36);
            btnChooseFolderToSave.TabIndex = 2;
            btnChooseFolderToSave.Text = "Сохранить в...";
            btnChooseFolderToSave.UseVisualStyleBackColor = true;
            btnChooseFolderToSave.Click += btnChooseFolderToSave_Click;
            // 
            // txtChooseFolderToSave
            // 
            txtChooseFolderToSave.Location = new Point(283, 90);
            txtChooseFolderToSave.Margin = new Padding(2);
            txtChooseFolderToSave.Name = "txtChooseFolderToSave";
            txtChooseFolderToSave.Size = new Size(306, 27);
            txtChooseFolderToSave.TabIndex = 3;
            // 
            // btnChooseFont
            // 
            btnChooseFont.AutoSize = true;
            btnChooseFont.Location = new Point(38, 146);
            btnChooseFont.Margin = new Padding(2);
            btnChooseFont.Name = "btnChooseFont";
            btnChooseFont.Size = new Size(211, 34);
            btnChooseFont.TabIndex = 4;
            btnChooseFont.Text = "Выбрать шрифт для формы";
            btnChooseFont.UseVisualStyleBackColor = true;
            btnChooseFont.Click += btnChooseFont_Click;
            // 
            // txtChooseFont
            // 
            txtChooseFont.Location = new Point(283, 151);
            txtChooseFont.Margin = new Padding(2);
            txtChooseFont.Name = "txtChooseFont";
            txtChooseFont.Size = new Size(306, 27);
            txtChooseFont.TabIndex = 5;
            txtChooseFont.Text = "Образец шрифта";
            // 
            // textBoxN
            // 
            textBoxN.BackColor = SystemColors.Control;
            textBoxN.BorderStyle = BorderStyle.None;
            textBoxN.Font = new Font("Segoe UI", 15F);
            textBoxN.Location = new Point(39, 219);

            textBoxN.Margin = new Padding(2);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(46, 34);
            textBoxN.TabIndex = 6;
            textBoxN.Text = "n = ";
            // 
            // textBoxInputN
            // 
            textBoxInputN.Location = new Point(89, 227);
            textBoxInputN.Margin = new Padding(2);
            textBoxInputN.Name = "textBoxInputN";
            textBoxInputN.Size = new Size(153, 27);
            textBoxInputN.TabIndex = 7;
            textBoxInputN.TextChanged += textBoxInputN_TextChanged;
            // 
            // btnCalcU
            // 
            btnCalcU.AutoSize = true;
            btnCalcU.Location = new Point(400, 314);
            btnCalcU.Margin = new Padding(2);
            btnCalcU.Name = "btnCalcU";
            btnCalcU.Size = new Size(94, 30);
            btnCalcU.TabIndex = 8;
            btnCalcU.Text = "В&ычислить\r\n";
            btnCalcU.UseVisualStyleBackColor = true;
            btnCalcU.Click += btnCalcU_Click;
            // 
            // btnCloseForm
            // 
            btnCloseForm.AutoSize = true;
            btnCloseForm.Location = new Point(498, 314);
            btnCloseForm.Margin = new Padding(2);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(90, 30);
            btnCloseForm.TabIndex = 9;
            btnCloseForm.Text = "З&акрыть";
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnCloseForm);
            Controls.Add(btnCalcU);
            Controls.Add(textBoxInputN);
            Controls.Add(textBoxN);
            Controls.Add(txtChooseFont);
            Controls.Add(btnChooseFont);
            Controls.Add(txtChooseFolderToSave);
            Controls.Add(btnChooseFolderToSave);
            Controls.Add(txtChooseFileWithData);
            Controls.Add(btnChooseFileWithData);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Тестирование диалоговых окон";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChooseFileWithData;
        private TextBox txtChooseFileWithData;
        private Button btnChooseFolderToSave;
        private TextBox txtChooseFolderToSave;
        private Button btnChooseFont;
        private TextBox txtChooseFont;
        private TextBox textBoxN;
        private TextBox textBoxInputN;
        private Button btnCalcU;
        private Button btnCloseForm;
    }
}
