namespace WindowsFormsAppQuiz
{
    partial class FormQuestionSelect
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
            this.disciplineDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDisciplineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerOptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // disciplineDataGridView
            // 
            this.disciplineDataGridView.AllowUserToAddRows = false;
            this.disciplineDataGridView.AllowUserToDeleteRows = false;
            this.disciplineDataGridView.AllowUserToOrderColumns = true;
            this.disciplineDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disciplineDataGridView.AutoGenerateColumns = false;
            this.disciplineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.contextDataGridViewTextBoxColumn,
            this.commandDataGridViewTextBoxColumn,
            this.contextImageDataGridViewImageColumn,
            this.idDisciplineDataGridViewTextBoxColumn,
            this.disciplineDataGridViewTextBoxColumn,
            this.answerOptionsDataGridViewTextBoxColumn});
            this.disciplineDataGridView.DataSource = this.questionBindingSource;
            this.disciplineDataGridView.Location = new System.Drawing.Point(12, 101);
            this.disciplineDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.disciplineDataGridView.Name = "disciplineDataGridView";
            this.disciplineDataGridView.ReadOnly = true;
            this.disciplineDataGridView.RowHeadersWidth = 51;
            this.disciplineDataGridView.RowTemplate.Height = 24;
            this.disciplineDataGridView.Size = new System.Drawing.Size(871, 350);
            this.disciplineDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // contextDataGridViewTextBoxColumn
            // 
            this.contextDataGridViewTextBoxColumn.DataPropertyName = "Context";
            this.contextDataGridViewTextBoxColumn.HeaderText = "Context";
            this.contextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contextDataGridViewTextBoxColumn.Name = "contextDataGridViewTextBoxColumn";
            this.contextDataGridViewTextBoxColumn.ReadOnly = true;
            this.contextDataGridViewTextBoxColumn.Width = 125;
            // 
            // commandDataGridViewTextBoxColumn
            // 
            this.commandDataGridViewTextBoxColumn.DataPropertyName = "Command";
            this.commandDataGridViewTextBoxColumn.HeaderText = "Command";
            this.commandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commandDataGridViewTextBoxColumn.Name = "commandDataGridViewTextBoxColumn";
            this.commandDataGridViewTextBoxColumn.ReadOnly = true;
            this.commandDataGridViewTextBoxColumn.Width = 125;
            // 
            // contextImageDataGridViewImageColumn
            // 
            this.contextImageDataGridViewImageColumn.DataPropertyName = "ContextImage";
            this.contextImageDataGridViewImageColumn.HeaderText = "ContextImage";
            this.contextImageDataGridViewImageColumn.MinimumWidth = 6;
            this.contextImageDataGridViewImageColumn.Name = "contextImageDataGridViewImageColumn";
            this.contextImageDataGridViewImageColumn.ReadOnly = true;
            this.contextImageDataGridViewImageColumn.Width = 125;
            // 
            // idDisciplineDataGridViewTextBoxColumn
            // 
            this.idDisciplineDataGridViewTextBoxColumn.DataPropertyName = "IdDiscipline";
            this.idDisciplineDataGridViewTextBoxColumn.HeaderText = "IdDiscipline";
            this.idDisciplineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDisciplineDataGridViewTextBoxColumn.Name = "idDisciplineDataGridViewTextBoxColumn";
            this.idDisciplineDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDisciplineDataGridViewTextBoxColumn.Width = 125;
            // 
            // disciplineDataGridViewTextBoxColumn
            // 
            this.disciplineDataGridViewTextBoxColumn.DataPropertyName = "Discipline";
            this.disciplineDataGridViewTextBoxColumn.HeaderText = "Discipline";
            this.disciplineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.disciplineDataGridViewTextBoxColumn.Name = "disciplineDataGridViewTextBoxColumn";
            this.disciplineDataGridViewTextBoxColumn.ReadOnly = true;
            this.disciplineDataGridViewTextBoxColumn.Width = 125;
            // 
            // answerOptionsDataGridViewTextBoxColumn
            // 
            this.answerOptionsDataGridViewTextBoxColumn.DataPropertyName = "AnswerOptions";
            this.answerOptionsDataGridViewTextBoxColumn.HeaderText = "AnswerOptions";
            this.answerOptionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.answerOptionsDataGridViewTextBoxColumn.Name = "answerOptionsDataGridViewTextBoxColumn";
            this.answerOptionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.answerOptionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(Models.Question);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.Location = new System.Drawing.Point(713, 455);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(88, 26);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Se&lecionar";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(808, 457);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 26);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "&Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 71);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(465, 22);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(484, 68);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 26);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "&Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(565, 68);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 26);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "&Alterar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(645, 68);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 26);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "A&dicionar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(727, 68);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 26);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "&Excluir";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonView.Location = new System.Drawing.Point(808, 68);
            this.buttonView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 26);
            this.buttonView.TabIndex = 5;
            this.buttonView.Text = "&Visualizar";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(899, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "Questões";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar por";
            // 
            // FormQuestionSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.disciplineDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "FormQuestionSelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questões";
            ((System.ComponentModel.ISupportInitialize)(this.disciplineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView disciplineDataGridView;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn contextImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDisciplineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerOptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource questionBindingSource;
    }
}