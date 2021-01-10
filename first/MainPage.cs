using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace first
{
    public partial class MainPage : Form
    {
        List<Person> personsinArxiv = new List<Person>();
        List<Person> personsinKartoteka = new List<Person>();
        List<Person> choose = new List<Person>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
            myKartoteka.readPersonsListFromFile();
            dataGridView1.Rows.Clear();
            foreach (Person person in myKartoteka.personsinKartoteka)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = person.Surname;
                dataGridView1.Rows[n].Cells[1].Value = person.Name;
                dataGridView1.Rows[n].Cells[2].Value = person.Nationality;
                dataGridView1.Rows[n].Cells[3].Value = person.BirthdayDay;
                dataGridView1.Rows[n].Cells[4].Value = person.LastPlace;
                dataGridView1.Rows[n].Cells[5].Value = person.LastDeal;
                dataGridView1.Rows[n].Cells[6].Value = person.Date;
            }
            myKartoteka.savePersonsListInFile();
        }


        //додати до картотеки
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPerson form = new AddPerson();
            form.Show();
        }
        //відкрити архів
        private void Arxiv_Click(object sender, EventArgs e)
        {
            MyArxiv form = new MyArxiv();
            form.Show();
        }
        //оновити список
        private void Restart_Click(object sender, EventArgs e)
        {
            try
            {
                Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
                myKartoteka.readPersonsListFromFile();
                dataGridView1.Rows.Clear();
                foreach (Person person in myKartoteka.personsinKartoteka)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = person.Surname;
                    dataGridView1.Rows[n].Cells[1].Value = person.Name;
                    dataGridView1.Rows[n].Cells[2].Value = person.Nationality;
                    dataGridView1.Rows[n].Cells[3].Value = person.BirthdayDay;
                    dataGridView1.Rows[n].Cells[4].Value = person.LastPlace;
                    dataGridView1.Rows[n].Cells[5].Value = person.LastDeal;
                    dataGridView1.Rows[n].Cells[6].Value = person.Date;
                }
                myKartoteka.savePersonsListInFile();
            }
            catch
            {
                MessageBox.Show("Помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //відкрити дані по обраній людині
        private void Detail_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    DataMurder form = new DataMurder(s);
                    form.Show();
                }
                else { MessageBox.Show("Оберіть строку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("Оберіть строку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //додати в архів
        private void AddArxiv_Click(object sender, EventArgs e)
        {
            Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
            Arxiv myArxiv = new Arxiv(personsinArxiv);

            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    myKartoteka.readPersonsListFromFile();
                    myArxiv.readPersonsListFromFile();
                    Person temp = myKartoteka.Find(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    myKartoteka.personsinKartoteka.Remove(temp);
                    myKartoteka.Delete(temp);
                    DialogResult result = MessageBox.Show("Людина померла?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No)
                    {
                        myArxiv.personsinArxiv.Add(temp);
                        myArxiv.savePersonsListInFile();
                    }
                    else
                    {
                        temp.Alive = "false";
                        myArxiv.personsinArxiv.Add(temp);
                        myArxiv.savePersonsListInFile();
                    }
                }
                else { MessageBox.Show("Оберіть строку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("Оберіть строку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //реедагувати дані
        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    Autorize form = new Autorize(s);
                    form.Show();
                }
                else { MessageBox.Show("Оберіть строку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("Оберіть строку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //зберігти вибірку
        private void Chose_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    foreach (Person person in choose)
                    {
                        myWritet.WriteLine("Прізвище: " + person.Surname);
                        myWritet.WriteLine("Ім'я: " + person.Name);
                        if (person.Nickname != "")
                        {
                            myWritet.WriteLine("Кличка: " + person.Nickname);
                        }
                        if (person.Height != "")
                        {
                            myWritet.WriteLine("Зріст: " + person.Height);
                        }
                        if (person.EyeColor != "")
                        {
                            myWritet.WriteLine("Колір очей: " + person.EyeColor);
                        }
                        if (person.HairColor != "")
                        {
                            myWritet.WriteLine("Колір волосся: " + person.HairColor);
                        }
                        if (person.Special != "")
                        {
                            myWritet.WriteLine("Особливі прикмети: " + person.Special);
                        }
                        myWritet.WriteLine("Громадянство: " + person.Nationality);
                        if (person.BirthdayPlace != "")
                        {
                            myWritet.WriteLine("Місце народження: " + person.BirthdayPlace);
                        }
                        myWritet.WriteLine("Дата народження: " + person.BirthdayDay);
                        myWritet.WriteLine("Останнє місце проживання: " + person.LastPlace);
                        if (person.Language != "")
                        {
                            myWritet.WriteLine("Знання мов: " + person.Language);
                        }
                        myWritet.WriteLine("Остання справа: " + person.LastDeal);
                        if (person.Measure != "")
                        {
                            myWritet.WriteLine("Запобіжний захід: " + person.Measure);
                        }
                        myWritet.WriteLine("Срок дії покарання: " + person.Date);
                        myWritet.WriteLine("Людина жива: " + person.Alive);
                        myWritet.WriteLine("////////////////////");
                    }
                    choose = new List<Person>();
                    myWritet.Close();
                    myStream.Close();
                }
            }
        }
        //відсортувати список
        private void sort_Click(object sender, EventArgs e)
        {
            Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
            myKartoteka.readPersonsListFromFile();
            myKartoteka.personsinKartoteka.Sort();
            myKartoteka.savePersonsListInFile();
        }
        //пошук по критеріям
        private void find_Click(object sender, EventArgs e)
        {
            Find form = new Find();
            form.Show();
        }
        //додати у вибірку
        private void AddIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
                    myKartoteka.readPersonsListFromFile();
                    choose.Add(myKartoteka.Find(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Додано до вибірки", "Збережено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Оберіть строку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch { MessageBox.Show("Оберіть строку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
// добавить выпадающие списки
// сохранять результат поиска в виде таблицы - есть
// добавить все методы в форму и вызывать их как функцию - есть