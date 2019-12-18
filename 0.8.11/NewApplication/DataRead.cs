using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using NewApplication;

namespace NewApplication
{
    class DataRead
    {
        private RequestProcessing RP;
        private MainForm MF;

        public DataRead(RequestProcessing reqproc, MainForm mainform)
        {
            RP = reqproc;
            MF = mainform;
        }
        public int OfferCount;

        void nameindex(int i)
        {
            if (i < OfferCount)
                for (var j = 0; j < i; j++)
                {
                    if (RP.Offers[i].PizzaName != RP.Offers[j].PizzaName && RP.Offers[i].Id == RP.Offers[j].Id)
                    {
                        RP.Offers[i].Id++;
                    }
                }
        }
        public void ReadData()
        {
            RP.Ulist = new List<Shoplist>();
            XmlDocument xDoc = new XmlDocument();
            try
            {
                xDoc.Load("Menu.xml");
            }
            catch
            {
                MF.isError = true;
                MessageBox.Show("Даннi меню пошкодженi", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                XmlElement xRoot = xDoc.DocumentElement;
                OfferCount = 0;
                foreach (XmlNode node in xRoot.ChildNodes) //подсчет элементов
                {
                    OfferCount++;
                }
                RP.Offers = new Offerlist[OfferCount];
                for (var k = 0; k < OfferCount; k++)
                    RP.Offers[k] = new Offerlist();
                int i = 0;
                List<Offerlist> Plist = new List<Offerlist>();
                int f = 0;
                foreach (XmlNode node in xRoot.ChildNodes)
                {
                    foreach (XmlNode xNode in node.ChildNodes)
                    {
                        if (xNode.Name == "PizzaryName")
                        {
                            RP.Offers[i].ShopName = xNode.InnerText;
                        }
                        else if (xNode.Name == "PizzaName")
                        {
                            RP.Offers[i].PizzaName = xNode.InnerText;
                        }
                        else if (xNode.Name == "PizzaRadius")
                        {
                            RP.Offers[i].Size = xNode.InnerText;
                        }
                        else if (xNode.Name == "PizzaElements")
                        {
                            int j = 0;
                            foreach (XmlNode xNodeX in xNode.ChildNodes)
                            {
                                j++;
                            }
                            RP.Offers[i].Elements = new string[j];
                            j = 0;
                            foreach (XmlNode xNodeX in xNode.ChildNodes)
                            {
                                RP.Offers[i].Elements[j] = xNodeX.InnerText;
                                j++;
                            }
                        }
                        else if (xNode.Name == "Cost")
                        {
                            RP.Offers[i].Cost = Convert.ToInt32(xNode.InnerText);
                        }
                    }
                    //Индексирование
                    nameindex(i);                   
                    //Перечень пиццы
                    Offerlist Ptemp = new Offerlist();
                    if (RP.Offers[i].Id > f)
                    {
                        Ptemp.Id = f = RP.Offers[i].Id;
                        Ptemp.PizzaName = RP.Offers[i].PizzaName;
                        Ptemp.Elements = new string[RP.Offers[i].Elements.Length];
                        Ptemp.Elements = RP.Offers[i].Elements;
                        Plist.Add(Ptemp);
                    }
                    i++;
                }
                RP.Pizzas = Plist.ToArray();
            }
        }
    }
}
