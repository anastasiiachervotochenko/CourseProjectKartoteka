using System;
using System.Windows.Forms;

namespace first
{
    public partial class Autorize : Form
    {
        string str;
        public Autorize(string str)
        {
            InitializeComponent();
            this.str = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (password.Text == "12345")
            {
                Edit form = new Edit(str);
                form.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильно введено пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

