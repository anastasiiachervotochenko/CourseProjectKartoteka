using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace first
{
    public partial class MyArxiv : Form
    {
        List<Person> personsinArxiv = new List<Person>();
        List<Person> personsinKartoteka = new List<Person>();
        public MyArxiv()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Arxiv myArxiv = new Arxiv(personsinArxiv);
            myArxiv.readPersonsListFromFile();
            dataGridView1.Rows.Clear();
            foreach (Person person in myArxiv.personsinArxiv)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = person.Surname;
                dataGridView1.Rows[n].Cells[1].Value = person.Name;
                dataGridView1.Rows[n].Cells[2].Value = person.Nationality;
                dataGridView1.Rows[n].Cells[3].Value = person.BirthdayDay;
                dataGridView1.Rows[n].Cells[4].Value = person.LastPlace;
                dataGridView1.Rows[n].Cells[5].Value = person.LastDeal;
                dataGridView1.Rows[n].Cells[6].Value = person.Alive;
            }
            myArxiv.savePersonsListInFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
            Arxiv myArxiv = new Arxiv(personsinArxiv);
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    myKartoteka.readPersonsListFromFile();
                    myArxiv.readPersonsListFromFile();
                    Person temp = myArxiv.Find(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    if (temp.Alive == "true")
                    {
                        myArxiv.personsinArxiv.Remove(temp);
                        myArxiv.Delete(temp);
                        myKartoteka.personsinKartoteka.Add(temp);//разобраться почему не работает
                        myKartoteka.savePersonsListInFile();
                        MessageBox.Show("Злочинця перенесено до картотеки", "Збережено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else { MessageBox.Show("Оберіть живу людину", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Оберіть строку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("Оберіть строку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
