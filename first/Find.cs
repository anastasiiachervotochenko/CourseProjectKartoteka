using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace first
{
    public partial class Find : Form
    {
        List<Person> personsinKartoteka = new List<Person>();
        List<Person> murder = new List<Person>();
        public Find()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
            myKartoteka.readPersonsListFromFile();
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && comboBox1.Text == "" && comboBox2.Text == "" && textBox7.Text == "" && comboBox3.Text == "" && textBox9.Text == "" && dateTimePicker1.Text == "" && textBox11.Text == "" && textBox12.Text == "" && comboBox4.Text == "" && textBox14.Text == "" && textBox15.Text == "")
            {
                dataGridView1.Rows.Clear();
                foreach (Person person in myKartoteka.personsinKartoteka)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = person.Surname;
                    dataGridView1.Rows[n].Cells[1].Value = person.Name;
                    dataGridView1.Rows[n].Cells[2].Value = person.Nickname;
                    dataGridView1.Rows[n].Cells[3].Value = person.Height;
                    dataGridView1.Rows[n].Cells[4].Value = person.EyeColor;
                    dataGridView1.Rows[n].Cells[5].Value = person.HairColor;
                    dataGridView1.Rows[n].Cells[6].Value = person.Special;
                    dataGridView1.Rows[n].Cells[7].Value = person.Nationality;
                    dataGridView1.Rows[n].Cells[8].Value = person.BirthdayPlace;
                    dataGridView1.Rows[n].Cells[9].Value = person.BirthdayDay;
                    dataGridView1.Rows[n].Cells[10].Value = person.LastPlace;
                    dataGridView1.Rows[n].Cells[11].Value = person.Language;
                    dataGridView1.Rows[n].Cells[12].Value = person.LastDeal;
                    dataGridView1.Rows[n].Cells[13].Value = person.Measure;
                    dataGridView1.Rows[n].Cells[14].Value = person.Date;
                }
            }
            else
            {
                int count = 15;
                int d = 0;
                foreach (Person person in myKartoteka.personsinKartoteka)
                {
                    d++;
                }
                int[] arr = new int[d];
                int i = 0;
                foreach (Person person in myKartoteka.personsinKartoteka)
                {
                    int c = 0;
                    if (textBox1.Text !=""  && textBox1.Text == person.Surname) { c++; }
                    if (textBox2.Text != "" && textBox2.Text == person.Name) { c++; }
                    if (textBox3.Text != "" && textBox3.Text == person.Nickname) { c++; }
                    if (textBox4.Text != "" && textBox4.Text == person.Height) { c++; }
                    if (comboBox1.Text != "" && comboBox1.Text == person.EyeColor) { c++; }
                    if (comboBox2.Text != "" && comboBox2.Text == person.HairColor) { c++; }
                    if (textBox7.Text != "" && textBox7.Text == person.Special) { c++; }
                    if (comboBox3.Text != "" && comboBox3.Text == person.Nationality) { c++; }
                    if (textBox9.Text != "" && textBox9.Text == person.BirthdayPlace) { c++; }
                    if (dateTimePicker1.Text != "" && dateTimePicker1.Text == person.BirthdayDay) { c++; }
                    if (textBox11.Text != "" && textBox11.Text == person.LastPlace) { c++; }
                    if (textBox12.Text != "" && textBox12.Text == person.Language) { c++; }
                    if (comboBox4.Text != "" && comboBox4.Text == person.LastDeal) { c++; }
                    if (textBox14.Text != "" && textBox14.Text == person.Measure) { c++; }
                    if (textBox15.Text != "" && textBox15.Text == person.Date) { c++; }
                    arr[i] = c;
                    i++;
                }
                while (count >= 0)
                {
                    for(int j = 0; j < d; j++)
                    {
                        if (arr[j] == count)
                        {
                            murder.Add(myKartoteka.personsinKartoteka[j]);
                        }
                    }
                    count--;
                }
                dataGridView1.Rows.Clear();
                foreach (Person person in murder)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = person.Surname;
                    dataGridView1.Rows[n].Cells[1].Value = person.Name;
                    dataGridView1.Rows[n].Cells[2].Value = person.Nickname;
                    dataGridView1.Rows[n].Cells[3].Value = person.Height;
                    dataGridView1.Rows[n].Cells[4].Value = person.EyeColor;
                    dataGridView1.Rows[n].Cells[5].Value = person.HairColor;
                    dataGridView1.Rows[n].Cells[6].Value = person.Special;
                    dataGridView1.Rows[n].Cells[7].Value = person.Nationality;
                    dataGridView1.Rows[n].Cells[8].Value = person.BirthdayPlace;
                    dataGridView1.Rows[n].Cells[9].Value = person.BirthdayDay;
                    dataGridView1.Rows[n].Cells[10].Value = person.LastPlace;
                    dataGridView1.Rows[n].Cells[11].Value = person.Language;
                    dataGridView1.Rows[n].Cells[12].Value = person.LastDeal;
                    dataGridView1.Rows[n].Cells[13].Value = person.Measure;
                    dataGridView1.Rows[n].Cells[14].Value = person.Date;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = null;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    foreach (Person person in murder)
                    {
                        myWritet.WriteLine(person.Surname + ";" + person.Name + ";" + person.Nickname + ";" + person.Height + ";" + person.EyeColor + ";" + person.HairColor + ";" + person.Special + ";" + person.Nationality + ";" + person.BirthdayPlace + ";" + person.BirthdayDay + ";" + person.LastPlace + ";" + person.Language + ";" + person.LastDeal + ";" + person.Measure + ";" + person.Date);
                    }
                    myWritet.Close();
                    myStream.Close();
                }
            }
        }
      
    }
}

