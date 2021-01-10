using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace first
{
    public partial class Edit : Form
    {
        private string str;
        List<Person> personsinKartoteka = new List<Person>();
        public Edit(string str)
        {
            InitializeComponent();
            this.str = str;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
                myKartoteka.readPersonsListFromFile();
                Person person = myKartoteka.Find(str);
                
                        textBox1.Text = person.Surname;
                        textBox2.Text = person.Name;
                        textBox3.Text = person.Nickname;
                        textBox4.Text = person.Height;
                        comboBox1.Text = person.EyeColor;
                        comboBox2.Text = person.HairColor;
                        textBox7.Text = person.Special;
                        comboBox3.Text = person.Nationality;
                        textBox9.Text = person.BirthdayPlace;
                        dateTimePicker1.Text = person.BirthdayDay;
                        textBox11.Text = person.LastPlace;
                        textBox12.Text = person.Language;
                        comboBox4.Text = person.LastDeal;
                        textBox14.Text = person.Measure;
                        textBox15.Text = person.Date;
                        myKartoteka.personsinKartoteka.Remove(person);
                        myKartoteka.Delete(person);
            }
            catch { MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
                myKartoteka.readPersonsListFromFile();
                int k = 0;
                foreach (Person person in myKartoteka.personsinKartoteka)
                {
                    if (person.Surname == textBox1.Text)
                    {
                        k++;
                    }
                }
                if (textBox1.Text.Length < 2 || textBox1.Text.Equals("") || k != 0)
                    MessageBox.Show("Вы не ввели не коректну фамілію", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (textBox2.Text.Length < 2 || textBox2.Text.Equals(""))
                    MessageBox.Show("Вы не ввели не коректне ім'я", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (textBox3.Text.Length < 2 && textBox3.Text != "")
                    MessageBox.Show("Вы не ввели не коректну кличку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (textBox4.Text.Length != 3 && textBox4.Text != "")
                    MessageBox.Show("Вы не ввели не коректний зріст", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (comboBox1.Text.Length < 2 && comboBox1.Text != "")
                    MessageBox.Show("Вы не ввели не коректний колір очей", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (comboBox2.Text.Length < 2 && comboBox2.Text != "")
                    MessageBox.Show("Вы не ввели не коректний колір волосся", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (textBox7.Text.Length < 2 && textBox7.Text != "")
                    MessageBox.Show("Вы не ввели не коректні особливі прикмети ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (comboBox3.Text.Length < 4 || comboBox3.Text.Equals(""))
                    MessageBox.Show("Вы не ввели не коректне громадянство", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (textBox9.Text.Length < 2 && textBox9.Text != "")
                    MessageBox.Show("Вы не ввели не коректне місце народження", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
               
                else if (textBox11.Text.Length < 3 || textBox11.Text.Equals(""))
                    MessageBox.Show("Вы не ввели не коректне останнє місце проживання", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (textBox12.Text.Length < 2 && textBox12.Text != "")
                    MessageBox.Show("Вы не ввели не коректні дані про знання мов", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (comboBox4.Text.Length < 4 || comboBox4.Text.Equals(""))
                    MessageBox.Show("Вы не ввели не коректну назву останньої справи", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (textBox14.Text.Length < 2 && textBox14.Text != "")
                    MessageBox.Show("Вы не ввели не коректний запобіжний захід", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else if (textBox15.Text.Length < 2 || textBox15.Text.Equals(""))
                    MessageBox.Show("Вы не ввели не коректний срок дії покарання", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                else
                {
                    Person person = new Person();
                    person.Surname = textBox1.Text;
                    person.Name = textBox2.Text;
                    person.Nickname = textBox3.Text;
                    person.Height = textBox4.Text;
                    person.EyeColor = comboBox1.Text;
                    person.HairColor = comboBox2.Text;
                    person.Special = textBox7.Text;
                    person.Nationality = comboBox3.Text;
                    person.BirthdayPlace = textBox9.Text;
                    person.BirthdayDay = dateTimePicker1.Text;
                    person.LastPlace = textBox11.Text;
                    person.Language = textBox12.Text;
                    person.LastDeal = comboBox4.Text;
                    person.Measure = textBox14.Text;
                    person.Date = textBox15.Text;
                    person.Alive = "true";
                    myKartoteka.personsinKartoteka.Add(person);
                    myKartoteka.savePersonsListInFile();
                    MessageBox.Show("Файл успішно збережено", "Збережено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch { MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = null;
        }
    }
}
