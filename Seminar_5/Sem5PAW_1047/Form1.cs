using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Sem5PAW_1047
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("nbrfxrates.xml");
            string str = sr.ReadToEnd();
            sr.Close();

            XmlReader reader = XmlReader.Create(new StringReader(str));
            while(reader.Read())
            {
                if(reader.Name== "PublishingDate" &&
                    reader.NodeType==XmlNodeType.Element)
                {
                    reader.Read();
                    tbData.Text = reader.Value;
                }
                if(reader.Name=="Rate" &&
                    reader.NodeType==XmlNodeType.Element)
                {
                    string atribut = reader["currency"];
                    if(atribut=="EUR")
                    {
                        reader.Read();
                        tbEUR.Text = reader.Value;
                    }
                    else
                        if (atribut == "GBP")
                    {
                        reader.Read();
                        tbGBP.Text = reader.Value;
                    }
                    else
                        if (atribut == "USD")
                    {
                        reader.Read();
                        tbUSD.Text = reader.Value;
                    }
                    else
                        if (atribut == "XAU")
                    {
                        reader.Read();
                        tbXAU.Text = reader.Value;
                    }
                }
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream,
                Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            //scriere nod parinte
            writer.WriteStartElement("CursValutar");

                //scriere noduri copil
                writer.WriteStartElement("DataCurs");
                writer.WriteValue(tbData.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("CursEUR");
                writer.WriteAttributeString("valuta", "EUR");
                writer.WriteValue(tbEUR.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("CursGBP");
                writer.WriteAttributeString("valuta", "GBP");
                writer.WriteValue(tbGBP.Text);
                writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Close();

            string xml = Encoding.UTF8.GetString(memStream.ToArray());

            memStream.Close();

            StreamWriter sw = new StreamWriter("fisier.xml");
            sw.WriteLine(xml);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("CursValutar");
            treeView1.Nodes.Add(parinte);

            TreeNode copil = new TreeNode(tbData.Text);
            parinte.Nodes.Add(copil);

            TreeNode nepot1 = new TreeNode(tbEUR.Text);
            copil.Nodes.Add(nepot1);

            TreeNode nepot2 = new TreeNode(tbGBP.Text);
            copil.Nodes.Add(nepot2);

            treeView1.ExpandAll();
        }
    }
}
