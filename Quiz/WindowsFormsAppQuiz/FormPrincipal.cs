using System.Windows.Forms;

namespace WindowsFormsAppQuiz
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void questõesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (FormQuestionSelect frm = new FormQuestionSelect())
            {
                frm.ShowDialog();
            }
        }
    }
}
