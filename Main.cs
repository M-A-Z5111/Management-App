namespace FinalProject
{
    public partial class Main : Form
    {
        private Form activeform;
        public Main()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form newform, object sender)
        {
            activeform = newform;
            newform.TopLevel = false;
            newform.FormBorderStyle = FormBorderStyle.None;
            newform.Dock = DockStyle.Fill;
            newform.BringToFront();
            newform.Show();

        }
        private void Airplaneform_Click(object sender, EventArgs e)
        {
            AirplaneForm AF = new AirplaneForm();
            AF.StartPosition = FormStartPosition.Manual;
            AF.Show();

        }

        private void TravelerForm_Click(object sender, EventArgs e)
        {
            TravelerForm TF = new TravelerForm();
            TF.StartPosition = FormStartPosition.Manual;
            TF.Show();

        }

        private void TicketForm_Click(object sender, EventArgs e)
        {
            TicketForm TiF = new TicketForm();
            TiF.StartPosition = FormStartPosition.Manual;
            TiF.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}