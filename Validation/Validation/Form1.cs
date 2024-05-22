namespace Validation {
    public partial class Form1 : Form
    {
        bool valid = true;
        Validator v = new Validator();
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BTNREGISTER_Click(object sender, EventArgs e)
        {
            if (!v.IsValidEmail(TBEMAIL.Text))
            {
                MessageBox.Show("Invalid Email");
                valid = false;
            }

            if (TBUSERNAME.Text == "")
            {
                MessageBox.Show("No Username");
                valid = false;
            }

            if (!v.IsValidPassword(TBPASSWORD.Text))
            {
                MessageBox.Show("Invalid Password");
                valid = false;
            }
            String gender = "";
            if(RBFEMALE.Checked || RBMALE.Checked)
            {
                if (RBMALE.Checked)
                {
                    gender = RBMALE.Text;
                }

                if (RBFEMALE.Checked)
                {
                    gender = RBFEMALE.Text;
                }
            }
            else
            {
                MessageBox.Show("Choose gender");
                valid = false;
            }

            if(valid)
            {
                Person p = new Person();
                p.setUsername(TBUSERNAME.Text);
                p.setPassword(TBPASSWORD.Text);
                p.setEmail(TBEMAIL.Text);
                p.setGender(gender);
                p.setBirthdate(DATETIME.Value);

                Display D = new Display(p);
                D.ShowDialog();
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
