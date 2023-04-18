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
    }
}
