namespace WindowsFormsAppQuiz
{
    partial class FormAnswerOptionRegister
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
            System.Windows.Forms.Label descriptionLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.isCorrectCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonEditImageOption = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerOptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cadastro de opções";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerOptionBindingSource
            // 
            this.AnswerOptionBindingSource.DataSource = typeof(Models.AnswerOption);
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 43);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AnswerOptionBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 59);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(505, 20);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.AnswerOptionBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(15, 114);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(502, 226);
            this.imagePictureBox.TabIndex = 12;
            this.imagePictureBox.TabStop = false;
            // 
            // isCorrectCheckBox
            // 
            this.isCorrectCheckBox.AutoSize = true;
            this.isCorrectCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.AnswerOptionBindingSource, "IsCorrect", true));
            this.isCorrectCheckBox.Location = new System.Drawing.Point(523, 62);
            this.isCorrectCheckBox.Name = "isCorrectCheckBox";
            this.isCorrectCheckBox.Size = new System.Drawing.Size(107, 17);
            this.isCorrectCheckBox.TabIndex = 13;
            this.isCorrectCheckBox.Text = "&Resposta correta";
            this.isCorrectCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonEditImageOption
            // 
            this.buttonEditImageOption.Location = new System.Drawing.Point(467, 85);
            this.buttonEditImageOption.Name = "buttonEditImageOption";
            this.buttonEditImageOption.Size = new System.Drawing.Size(50, 23);
            this.buttonEditImageOption.TabIndex = 14;
            this.buttonEditImageOption.Text = "E&ditar";
            this.buttonEditImageOption.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.buttonExit.Location = new System.Drawing.Point(555, 346);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "&Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(474, 346);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "&Gravar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormAnswerOptionRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 381);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEditImageOption);
            this.Controls.Add(this.isCorrectCheckBox);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnswerOptionRegister";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de opções";
            ((System.ComponentModel.ISupportInitialize)(this.AnswerOptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.CheckBox isCorrectCheckBox;
        private System.Windows.Forms.Button buttonEditImageOption;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.BindingSource AnswerOptionBindingSource;
    }
}