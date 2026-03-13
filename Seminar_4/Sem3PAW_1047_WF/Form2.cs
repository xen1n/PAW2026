using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sem3PAW_1047_WF
{
    public partial class Form2 : Form
    {
        //ArrayList lista2;
        //public Form2(ArrayList lista)
        List<Student> lista2;
        public Form2(List<Student> lista)
        {
            InitializeComponent();
            lista2 = lista;
            foreach (Student s in lista)
                textBox1.Text += s.ToString() + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Student s in lista2)
            {
                ListViewItem itm = new ListViewItem(s.Cod.ToString());
                itm.SubItems.Add(s.Sex.ToString());
                itm.SubItems.Add(s.Varsta.ToString());
                itm.SubItems.Add(s.Nume);
                string rezultat = "";
                for (int i = 0; i < s.Note.Length; i++)
                    rezultat += s.Note[i] + ", ";
                itm.SubItems.Add(rezultat);
                listView1.Items.Add(itm);
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in listView1.Items)
                if(itm.Checked)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < lista2.Count; i++)
                        if (lista2[i].Cod == cod)
                            lista2.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("studenti.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, lista2);
            listView1.Items.Clear();
            fs.Close();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("studenti.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Student> lista3 = (List<Student>)bf.Deserialize(fs);
            foreach (Student s in lista3)
            {
                ListViewItem itm = new ListViewItem(s.Cod.ToString());
                itm.SubItems.Add(s.Sex.ToString());
                itm.SubItems.Add(s.Varsta.ToString());
                itm.SubItems.Add(s.Nume);
                string rezultat = "";
                for (int i = 0; i < s.Note.Length; i++)
                    rezultat += s.Note[i] + ", ";
                itm.SubItems.Add(rezultat);
                listView1.Items.Add(itm);
            }
            fs.Close();
        }
    }
}
