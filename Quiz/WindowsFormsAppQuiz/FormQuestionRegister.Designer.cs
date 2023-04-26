namespace WindowsFormsAppQuiz
{
    partial class FormQuestionRegister
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
            System.Windows.Forms.Label contextLabel;
            System.Windows.Forms.Label commandLabel;
            this.contextTextBox = new System.Windows.Forms.TextBox();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.answerOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.answerOptionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAddOption = new System.Windows.Forms.Button();
            this.buttonDeleteOption = new System.Windows.Forms.Button();
            this.buttonViewOption = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditImageCommand = new System.Windows.Forms.Button();
            this.buttonEditImageOption = new System.Windows.Forms.Button();
            contextLabel = new System.Windows.Forms.Label();
            commandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextLabel
            // 
            contextLabel.AutoSize = true;
            contextLabel.Location = new System.Drawing.Point(12, 57);
            contextLabel.Name = "contextLabel";
            contextLabel.Size = new System.Drawing.Size(49, 13);
            contextLabel.TabIndex = 1;
            contextLabel.Text = "Contexto";
            // 
            // commandLabel
            // 
            commandLabel.AutoSize = true;
            commandLabel.Location = new System.Drawing.Point(12, 175);
            commandLabel.Name = "commandLabel";
            commandLabel.Size = new System.Drawing.Size(108, 13);
            commandLabel.TabIndex = 3;
            commandLabel.Text = "Comando da questão";
            // 
            // contextTextBox
            // 
            this.contextTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionBindingSource, "Context", true));
            this.contextTextBox.Location = new System.Drawing.Point(15, 73);
            this.contextTextBox.Multiline = true;
            this.contextTextBox.Name = "contextTextBox";
            this.contextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contextTextBox.Size = new System.Drawing.Size(545, 99);
            this.contextTextBox.TabIndex = 2;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(Models.Question);
            // 
            // commandTextBox
            // 
            this.commandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionBindingSource, "Command", true));
            this.commandTextBox.Location = new System.Drawing.Point(15, 191);
            this.commandTextBox.Multiline = true;
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandTextBox.Size = new System.Drawing.Size(545, 36);
            this.commandTextBox.TabIndex = 4;
            // 
            // answerOptionsBindingSource
            // 
            this.answerOptionsBindingSource.DataMember = "AnswerOptions";
            this.answerOptionsBindingSource.DataSource = this.questionBindingSource;
            // 
            // answerOptionsDataGridView
            // 
            this.answerOptionsDataGridView.AutoGenerateColumns = false;
            this.answerOptionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answerOptionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1});
            this.answerOptionsDataGridView.DataSource = this.answerOptionsBindingSource;
            this.answerOptionsDataGridView.Location = new System.Drawing.Point(15, 261);
            this.answerOptionsDataGridView.Name = "answerOptionsDataGridView";
            this.answerOptionsDataGridView.RowHeadersWidth = 51;
            this.answerOptionsDataGridView.Size = new System.Drawing.Size(545, 142);
            this.answerOptionsDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn1.HeaderText = "Count";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsReadOnly";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsReadOnly";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(566, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 72);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(566, 261);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 142);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // buttonAddOption
            // 
            this.buttonAddOption.Location = new System.Drawing.Point(323, 232);
            this.buttonAddOption.Name = "buttonAddOption";
            this.buttonAddOption.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOption.TabIndex = 7;
            this.buttonAddOption.Text = "&Adicionar";
            this.buttonAddOption.UseVisualStyleBackColor = true;
            this.buttonAddOption.Click += new System.EventHandler(this.buttonAddOption_Click);
            // 
            // buttonDeleteOption
            // 
            this.buttonDeleteOption.Location = new System.Drawing.Point(404, 232);
            this.buttonDeleteOption.Name = "buttonDeleteOption";
            this.buttonDeleteOption.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteOption.TabIndex = 7;
            this.buttonDeleteOption.Text = "&Remover";
            this.buttonDeleteOption.UseVisualStyleBackColor = true;
            this.buttonDeleteOption.Click += new System.EventHandler(this.buttonDeleteOption_Click);
            // 
            // buttonViewOption
            // 
            this.buttonViewOption.Location = new System.Drawing.Point(485, 232);
            this.buttonViewOption.Name = "buttonViewOption";
            this.buttonViewOption.Size = new System.Drawing.Size(75, 23);
            this.buttonViewOption.TabIndex = 7;
            this.buttonViewOption.Text = "&Visualizar";
            this.buttonViewOption.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(632, 409);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "&Gravar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonExit.Location = new System.Drawing.Point(713, 409);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "&Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 43);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastro de questão";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEditImageCommand
            // 
            this.buttonEditImageCommand.Location = new System.Drawing.Point(738, 71);
            this.buttonEditImageCommand.Name = "buttonEditImageCommand";
            this.buttonEditImageCommand.Size = new System.Drawing.Size(50, 23);
            this.buttonEditImageCommand.TabIndex = 7;
            this.buttonEditImageCommand.Text = "&Editar";
            this.buttonEditImageCommand.UseVisualStyleBackColor = true;
            // 
            // buttonEditImageOption
            // 
            this.buttonEditImageOption.Location = new System.Drawing.Point(738, 232);
            this.buttonEditImageOption.Name = "buttonEditImageOption";
            this.buttonEditImageOption.Size = new System.Drawing.Size(50, 23);
            this.buttonEditImageOption.TabIndex = 7;
            this.buttonEditImageOption.Text = "E&ditar";
            this.buttonEditImageOption.UseVisualStyleBackColor = true;
            // 
            // FormQuestionRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEditImageOption);
            this.Controls.Add(this.buttonEditImageCommand);
            this.Controls.Add(this.buttonViewOption);
            this.Controls.Add(this.buttonDeleteOption);
            this.Controls.Add(this.buttonAddOption);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answerOptionsDataGridView);
            this.Controls.Add(commandLabel);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(contextLabel);
            this.Controls.Add(this.contextTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuestionRegister";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de questão";
            this.Load += new System.EventHandler(this.FormQuestionRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormQuestionRegister_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerOptionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.TextBox contextTextBox;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.BindingSource answerOptionsBindingSource;
        private System.Windows.Forms.DataGridView answerOptionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonAddOption;
        private System.Windows.Forms.Button buttonDeleteOption;
        private System.Windows.Forms.Button buttonViewOption;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditImageCommand;
        private System.Windows.Forms.Button buttonEditImageOption;
    }
}