namespace egzamin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string firstPass = passwordBox.Text;
            string secondPass = passwordBox2.Text;
            bool checkEmail = email.Contains("@");

            if (checkEmail == false)
            {
                label_answer.Text = "nieprawid³owy adres e-mail";
            }
            if (firstPass != secondPass)
            {
                label_answer.Text = "Has³a siê rózni¹";
            }
            if (checkEmail == true && firstPass == secondPass)
            {
                label_answer.Text = "Witaj " + email;
            }

        }

    }
}