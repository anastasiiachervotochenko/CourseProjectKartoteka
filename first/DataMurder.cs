using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace first
{
    public partial class DataMurder : Form
    {
        string str;
        List<Person> personsinKartoteka = new List<Person>();
        public DataMurder(string str)
        {
            InitializeComponent();
            this.str = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
                myKartoteka.readPersonsListFromFile();
                foreach (Person person in myKartoteka.personsinKartoteka)
                {
                    if (person.Surname == str)
                    {
                        textBox1.Text = person.Surname;
                        textBox2.Text = person.Name;
                        textBox3.Text = person.Nickname;
                        textBox4.Text = person.Height;
                        textBox5.Text = person.EyeColor;
                        textBox6.Text = person.HairColor;
                        textBox7.Text = person.Special;
                        textBox8.Text = person.Nationality;
                        textBox9.Text = person.BirthdayPlace;
                        textBox10.Text = person.BirthdayDay;
                        textBox11.Text = person.LastPlace;
                        textBox12.Text = person.Language;
                        textBox13.Text = person.LastDeal;
                        textBox14.Text = person.Measure;
                        textBox15.Text = person.Date;
                        break;
                    }
                }
            }
            catch { MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
