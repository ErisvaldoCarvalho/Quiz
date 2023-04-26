using System;
using System.Windows.Forms;

namespace WindowsFormsAppQuiz
{
    public partial class FormAnswerOptionRegister : Form
    {
        public FormAnswerOptionRegister()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerOptionBindingSource.EndEdit();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
