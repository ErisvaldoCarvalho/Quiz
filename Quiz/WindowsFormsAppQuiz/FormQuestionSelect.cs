using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppPrincipal;

namespace WindowsFormsAppQuiz
{
    public partial class FormQuestionSelect : Form
    {
        public FormQuestionSelect(bool _select = false)
        {
            InitializeComponent();
            buttonSelect.Visible = _select;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                questionBindingSource.DataSource = new QuestionBLL().GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (new HandleErro().GetId(ex) == 1)
                {
                    using (FormCreateConnection frm = new FormCreateConnection())
                    {
                        frm.ShowDialog();
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormQuestionRegister frm = new FormQuestionRegister())
            {
                frm.ShowDialog();
            }
        }
    }
}
