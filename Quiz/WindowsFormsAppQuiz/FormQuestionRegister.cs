using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppQuiz
{
    public partial class FormQuestionRegister : Form
    {
        private int id;
        public FormQuestionRegister(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }
        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (id == 0)
                    new QuestionBLL().Add((Question)questionBindingSource.Current);
                else
                    new QuestionBLL().Update((Question)questionBindingSource.Current);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormQuestionRegister_Load(object sender, EventArgs e)
        {
            if (id == 0)
                questionBindingSource.AddNew();
            else
                questionBindingSource.DataSource = new QuestionBLL().GetById(id);
        }

        private void FormQuestionRegister_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Abort;
        }

        private void buttonDeleteOption_Click(object sender, EventArgs e)
        {
            try
            {
                new QuestionBLL().Delete(((Question)questionBindingSource.Current).Id);
                answerOptionsBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddOption_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormAnswerOptionRegister frm = new FormAnswerOptionRegister())
                {
                    frm.ShowDialog();
                    answerOptionsBindingSource.AddNew();
                    ((AnswerOption)answerOptionsBindingSource.Current).Description = ((AnswerOption)frm.AnswerOptionBindingSource.Current).Description;
                    ((AnswerOption)answerOptionsBindingSource.Current).IsCorrect = ((AnswerOption)frm.AnswerOptionBindingSource.Current).IsCorrect;
                    ((AnswerOption)answerOptionsBindingSource.Current).Image = ((AnswerOption)frm.AnswerOptionBindingSource.Current).Image;
                    answerOptionsBindingSource.EndEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
