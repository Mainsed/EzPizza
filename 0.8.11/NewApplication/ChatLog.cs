using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using NewApplication;

namespace NewApplication
{
    class ChatLog
    {
        private MainForm MF;
        private RequestProcessing RP;
        public static bool SClose = false;
        public ChatLog(MainForm mainform, RequestProcessing reqproc)
        {
            MF = mainform;
            RP = reqproc;
        } 

        public void programUsage()
        {
            string MidTime="";
            if (MF.EnterDate.Hour < MF.CloseDate.Hour) MidTime += MF.CloseDate.Hour - MF.EnterDate.Hour;

            else MidTime += MF.EnterDate.Hour - MF.CloseDate.Hour;
            MidTime += ':';
            if (MF.EnterDate.Minute < MF.CloseDate.Minute) MidTime += MF.CloseDate.Minute - MF.EnterDate.Minute;

            else MidTime += MF.EnterDate.Minute - MF.CloseDate.Minute;
            MidTime += ':';
            if (MF.EnterDate.Second < MF.CloseDate.Second) MidTime += MF.CloseDate.Second - MF.EnterDate.Second;

            else MidTime += MF.EnterDate.Second - MF.CloseDate.Second;

            try {
                StreamWriter csvWrite = new StreamWriter("programUsage.csv", true);
                csvWrite.WriteLine(MF.EnterDate.ToString() + "; " + MidTime + "; " + MF.CloseDate.ToString());
                csvWrite.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка открытия файла: programUsage.csv\n");
                return;
            }
        }

        public void LoadChat()
        {
            XmlDocument xxDoc = new XmlDocument();
            try
            {
                xxDoc.Load("chatLog.xml");
            }
            catch
            {
                MF.isError = true;
                MessageBox.Show("Даннi з логу чату пошкодженi", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                XmlElement xxRoot = xxDoc.DocumentElement;
                if (xxRoot.HasChildNodes)
                    foreach (XmlNode xNode in xxRoot.ChildNodes)
                    {
                        MF.ListBox.Items.Add(xNode.InnerText);
                    }
                else
                {
                    MF.ListBox.Items.Add("Вас вітає EZPizza!");
                    MF.ListBox.Items.Add("За допомогою цього боту ви можете");
                    MF.ListBox.Items.Add("легко обрати та замовити піцу від");
                    MF.ListBox.Items.Add("багатьох закладів нашого міста");
                    MF.ListBox.Items.Add("додому чи в офіс!");
                    MF.ListBox.Items.Add("Скористайтесь підказками, щоб розпочати:");

                }
                RP.Instruction();
            }
        }

        public void SaveChat()
        {
            if (!MF.isError)
            {
                DialogResult dg = MessageBox.Show("Зберегти історію чату?", "Вихід!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                XmlDocument xDoc = new XmlDocument();
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        xDoc.Load("chatLog.xml");
                    }
                    catch
                    {
                        MF.isError = true;
                        MessageBox.Show("Виникла помилка при збереженнi, можливо файл для збереження пошкоджен, або не iснує", "Помилка!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    finally
                    {
                        XmlElement xRoot = xDoc.DocumentElement;
                        xRoot.IsEmpty = true;
                        xDoc.Save("chatLog.xml");
                        XmlElement Message;
                        XmlText MessageText;
                        foreach (string a in MF.ListBox.Items)
                        {
                            xDoc.Load("chatLog.xml");
                            xRoot = xDoc.DocumentElement;
                            Message = xDoc.CreateElement("Message");
                            MessageText = xDoc.CreateTextNode(a);
                            Message.AppendChild(MessageText);
                            xRoot.AppendChild(Message);
                            xDoc.Save("chatLog.xml");
                            Message.IsEmpty = true;
                            xRoot.IsEmpty = true;
                            MessageText = null;
                        }
                    }
                }
                else
                {
                    xDoc.Load("chatLog.xml");
                    XmlElement xRoot = xDoc.DocumentElement;
                    xRoot.IsEmpty = true;
                    xDoc.Save("chatLog.xml");
                }
                SClose = true;
            }
        }
    }
}
