using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validation
{

    public partial class Display : Form
    {
        private Person _person;
        private bool isDragging = false;
        private Point lastCursorPosition;
        public Display(Person person)
        {
            InitializeComponent();
            this._person = person;
        }

        private void Display_Load(object sender, EventArgs e)
        {
            LBUSERNAME.Text = _person.getUsername();
            LBEMAIL.Text = _person.getEmail();
            LBPASSWORD.Text = _person.getPassword();
            LBGENDER.Text = _person.getGender();
            LBBIRTHDATE.Text = _person.getBirthdate().ToString("MMM d, yyyy");
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursorPosition = e.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastCursorPosition.X;
                int deltaY = e.Y - lastCursorPosition.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
                lastCursorPosition = e.Location;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void BTNREGISTER_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
