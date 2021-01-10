using System.Collections.Generic;
using System.Xml;

namespace first
{
    class Kartoteka
    {
        public List<Person> personsinKartoteka;
        public Kartoteka(List<Person> person)
        {
            personsinKartoteka = person;
        }
        public void readPersonsListFromFile()
        {
            personsinKartoteka = new List<Person>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\Kartoteka.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                Person person = new Person();
                XmlNode attr = xnode.Attributes.GetNamedItem("surname");
                if (attr != null)
                    person.Surname = attr.Value;
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                        person.Name = childnode.InnerText;
                    if (childnode.Name == "nickname")
                        person.Nickname = childnode.InnerText;
                    if (childnode.Name == "height")
                        person.Height = childnode.InnerText;
                    if (childnode.Name == "eyecolor")
                        person.EyeColor = childnode.InnerText;
                    if (childnode.Name == "haircolor")
                        person.HairColor = childnode.InnerText;
                    if (childnode.Name == "special")
                        person.Special = childnode.InnerText;
                    if (childnode.Name == "nationality")
                        person.Nationality = childnode.InnerText;
                    if (childnode.Name == "birthdayplace")
                        person.BirthdayPlace = childnode.InnerText;
                    if (childnode.Name == "birthdayday")
                        person.BirthdayDay = childnode.InnerText;
                    if (childnode.Name == "lastplace")
                        person.LastPlace = childnode.InnerText;
                    if (childnode.Name == "language")
                        person.Language = childnode.InnerText;
                    if (childnode.Name == "lastdeal")
                        person.LastDeal = childnode.InnerText;
                    if (childnode.Name == "measure")
                        person.Measure = childnode.InnerText;
                    if (childnode.Name == "date")
                        person.Date = childnode.InnerText;
                    if (childnode.Name == "alive")
                        person.Alive = childnode.InnerText;
                }
                personsinKartoteka.Add(person);
            }
        }
        public void Delete(Person p)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\Kartoteka.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNode temp = new XmlDocument();
            foreach (XmlNode xnode in xRoot)
            {
                XmlNode attr = xnode.Attributes.GetNamedItem("surname");
                if (attr.Value == p.Surname) 
                { 
                    temp = xnode;
                }
            }
            xRoot.RemoveChild(temp);
            xDoc.Save(@"..\..\Kartoteka.xml");
        }
        public Person Find(string str)
        {
            Person p=new Person();
            Kartoteka myKartoteka = new Kartoteka(personsinKartoteka);
            myKartoteka.readPersonsListFromFile();
            foreach (Person person in myKartoteka.personsinKartoteka)
            {
                if (person.Surname == str)
                {
                    p = person;
                    break;
                }
            }
            return p;
        }
        public void savePersonsListInFile()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"..\..\Kartoteka.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (Person person in personsinKartoteka)
            {
                string surname = person.Surname;
                string name = person.Name;
                string nickname = person.Nickname;
                string height = person.Height;
                string eyecolor = person.EyeColor;
                string haircolor = person.HairColor;
                string special = person.Special;
                string nationality = person.Nationality;
                string birthdayplace = person.BirthdayPlace;
                string birthdayday = person.BirthdayDay;
                string lastplace = person.LastPlace;
                string language = person.Language;
                string lastdeal = person.LastDeal;
                string measure = person.Measure;
                string date = person.Date;
                string alive = person.Alive;
                // создаем новый элемент person
                XmlElement personElm = xDoc.CreateElement("person");
                //создаем атрибут surname
                XmlAttribute surnameAttr = xDoc.CreateAttribute("surname");
                //создаем элементы
                XmlElement nameElm = xDoc.CreateElement("name");
                XmlElement nicknameElm = xDoc.CreateElement("nickname");
                XmlElement heightElm = xDoc.CreateElement("height");
                XmlElement eyecolorElm = xDoc.CreateElement("eyecolor");
                XmlElement haircolorElm = xDoc.CreateElement("haircolor");
                XmlElement specialElm = xDoc.CreateElement("special");
                XmlElement nationalityElm = xDoc.CreateElement("nationality");
                XmlElement birthdayplaceElm = xDoc.CreateElement("birthdayplace");
                XmlElement birthdaydayElm = xDoc.CreateElement("birthdayday");
                XmlElement lastplaceElm = xDoc.CreateElement("lastplace");
                XmlElement languageElm = xDoc.CreateElement("language");
                XmlElement lastdealElm = xDoc.CreateElement("lastdeal");
                XmlElement measureElm = xDoc.CreateElement("measure");
                XmlElement dateElm = xDoc.CreateElement("date");
                XmlElement aliveElm = xDoc.CreateElement("alive");
                //создаем текстовые значения для элементов и атрибута
                XmlText surnameText = xDoc.CreateTextNode(surname);
                XmlText nameText = xDoc.CreateTextNode(name);
                XmlText nicknameText = xDoc.CreateTextNode(nickname);
                XmlText heightText = xDoc.CreateTextNode(height);
                XmlText eyecolorText = xDoc.CreateTextNode(eyecolor);
                XmlText haircolorText = xDoc.CreateTextNode(haircolor);
                XmlText specialText = xDoc.CreateTextNode(special);
                XmlText nationalityText = xDoc.CreateTextNode(nationality);
                XmlText birthdayplaceText = xDoc.CreateTextNode(birthdayplace);
                XmlText birthdaydayText = xDoc.CreateTextNode(birthdayday);
                XmlText lastplaceText = xDoc.CreateTextNode(lastplace);
                XmlText languageText = xDoc.CreateTextNode(language);
                XmlText lastdealText = xDoc.CreateTextNode(lastdeal);
                XmlText measureText = xDoc.CreateTextNode(measure);
                XmlText dateText = xDoc.CreateTextNode(date);
                XmlText aliveText = xDoc.CreateTextNode(alive);
                //добавляем узлы
                surnameAttr.AppendChild(surnameText);
                nameElm.AppendChild(nameText);
                nicknameElm.AppendChild(nicknameText);
                heightElm.AppendChild(heightText);
                eyecolorElm.AppendChild(eyecolorText);
                haircolorElm.AppendChild(haircolorText);
                specialElm.AppendChild(specialText);
                nationalityElm.AppendChild(nationalityText);
                birthdayplaceElm.AppendChild(birthdayplaceText);
                birthdaydayElm.AppendChild(birthdaydayText);
                lastplaceElm.AppendChild(lastplaceText);
                languageElm.AppendChild(languageText);
                lastdealElm.AppendChild(lastdealText);
                measureElm.AppendChild(measureText);
                dateElm.AppendChild(dateText);
                aliveElm.AppendChild(aliveText);

                personElm.Attributes.Append(surnameAttr);
                personElm.AppendChild(nameElm);
                personElm.AppendChild(nicknameElm);
                personElm.AppendChild(heightElm);
                personElm.AppendChild(eyecolorElm);
                personElm.AppendChild(haircolorElm);
                personElm.AppendChild(specialElm);
                personElm.AppendChild(nationalityElm);
                personElm.AppendChild(birthdayplaceElm);
                personElm.AppendChild(birthdaydayElm);
                personElm.AppendChild(lastplaceElm);
                personElm.AppendChild(languageElm);
                personElm.AppendChild(lastdealElm);
                personElm.AppendChild(measureElm);
                personElm.AppendChild(dateElm);
                personElm.AppendChild(aliveElm);


                xRoot.AppendChild(personElm);


                XmlNode temp = new XmlDocument();
                int count = 0;
                foreach (XmlNode xnode in xRoot)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("surname");
                    if (attr.Value == surname && count != 0)
                    {
                        count++;
                    }
                    else if (attr.Value == surname && count == 0)
                    {
                        temp = xnode;
                        count++;
                    }
                }
                if (count == 2)
                {
                    xRoot.RemoveChild(temp);
                }
                xDoc.Save(@"..\..\Kartoteka.xml");
            }
        }
    }
}
