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
    class RequestProcessing
    {
        private MainForm MF;
        public RequestProcessing(MainForm form)
        {
            MF = form;
        }
        bool ForOrder = false;
        public int iterator, Price;
        string instr;
        public Offerlist[] Offers;
        public Shoplist[] Shops;
        public Offerlist[] Pizzas;
        public Offerlist[] Basket;
        public List<Shoplist> Ulist;

        double sale()
        {
            double s = 1;
            if (Price > 1001)
                s = 0.9;
            if (Basket.Length > 8)
                s = 0.85;
            return s;
        }

        //Инструкции пользователю
        public void Help()
        {
            if (ForOrder == true)
            {
                MF.ListBox.Items.Add("*Так* для підтвердження");
                MF.ListBox.Items.Add("Або спробуйте обрати іншу");
            }
            else if (Shops != null)
            {
                MF.ListBox.Items.Add("Напишіть назву закладу чи");
                MF.ListBox.Items.Add("порядковий номер пропозиції");
                MF.ListBox.Items.Add("на піцу, яку ви бажаєте замовити");
                MF.ListBox.Items.Add("Або спробуйте обрати іншу");
            }
            else
            {
                MF.ListBox.Items.Add("В розділі *меню* оберіть різновид");
                MF.ListBox.Items.Add("піци, написавши назву зі списку");
            }
            MF.ListBox.SelectedIndex = MF.ListBox.Items.Count - 1;
            MF.ListBox.SelectedIndex = -1;
        }
        public void Instruction()
        {
            MF.ListBox.Items.Add("*Меню* або відповідна кнопка");
            MF.ListBox.Items.Add("   - для виклику меню");
            MF.ListBox.Items.Add("*Допомога* або *Підказка*");
            MF.ListBox.Items.Add("   - якщо щось не зрозуміло");
            MF.ListBox.Items.Add("*Команди* або відповідна кнопка");
            MF.ListBox.Items.Add("   - для відображення доступнх команд");
            MF.ListBox.Items.Add("*Кошик* або відповідна кнопка");
            MF.ListBox.Items.Add("   - щоб переглянути кошик замовлень");
            MF.ListBox.SelectedIndex = MF.ListBox.Items.Count - 1;
            MF.ListBox.SelectedIndex = -1;
        }
        //Вызов меню
        public void Pizza_Menu()
        {
            Shops = null;
            ForOrder = false;
            for (var i = 0; i < Pizzas.Length; i++)
            {
                MF.ListBox.Items.Add(Pizzas[i].PizzaName);
                for (var j = 0; j < Pizzas[i].Elements.Length; j++)
                {
                    MF.ListBox.Items.Add("     - " + Pizzas[i].Elements[j]);
                }
                MF.ListBox.SelectedIndex = MF.ListBox.Items.Count - 1;
                MF.ListBox.SelectedIndex = -1;
            }
        }
        //Выбор вида пиццы
        public void Shop_menu()
        {
            for (var j = 0; j < Pizzas.Length; j++)
            {
                if (instr == Pizzas[j].PizzaName.ToUpper())
                {
                    ForOrder = false;
                    BinSerch(Pizzas[j].Id);
                    MF.ListBox.Items.Add("Оберіть пропозицію за номером");
                    MF.ListBox.Items.Add("або за назвою закладу");
                    for (var k = 0; k < Shops.Length; k++)
                    {
                        MF.ListBox.Items.Add(k + 1 + ")" + Shops[k].PizzaName + " " + Shops[k].ShopName + " - "
                            + Shops[k].Size + "см/" + Shops[k].Cost + "грн");
                    }
                    MF.ListBox.SelectedIndex = MF.ListBox.Items.Count - 1;
                    MF.ListBox.SelectedIndex = -1;
                    break;
                }
            }
        }
        //Выбор заведения
        public void Order_menu()
        {
            if (Shops != null)
            {
                for (var j = 0; j < Shops.Length; j++)
                {
                    if (instr == Shops[j].ShopName.ToUpper() || instr == Shops[j].In.ToString())
                    {
                        MF.ListBox.Items.Add("Додати до кошику:");
                        MF.ListBox.Items.Add(Shops[j].PizzaName + " " + Shops[j].Size + "см/"
                            + Shops[j].Cost + "грн " + "від " + Shops[j].ShopName + "?");
                        iterator = j;
                        ForOrder = true;
                        MF.ListBox.SelectedIndex = MF.ListBox.Items.Count - 1;
                        MF.ListBox.SelectedIndex = -1;
                        break;
                    }
                }
            }
        }

        //Добавить в корзину
        public void Order_q()
        {
            if (ForOrder == true)
            {
                ForOrder = false;
                Ulist.Add(Shops[iterator]);
                Shops = null;
                MF.ListBox.Items.Add("Успішно додано в кошик!");
                MF.ListBox.SelectedIndex = MF.ListBox.Items.Count - 1;
                MF.ListBox.SelectedIndex = -1;
            }
        }
        //Корзина
        public void Basket_menu()
        {

            Basket = Ulist.ToArray();
            Price = 0;
            MF.ListBox.Items.Add("Ваш кошик:");
            for (var j = 0; j < Basket.Length; j++)
            {
                Price += Basket[j].Cost;
                MF.ListBox.Items.Add(Basket[j].PizzaName + " " + Basket[j].Size + "см/"
                        + Basket[j].Cost + "грн " + "від " + Basket[j].ShopName);
            }
            MF.ListBox.Items.Add("Загальна ціна - " + Price + "грн");
            MF.ListBox.Items.Add("Ціна зі знижкою - " + Price*sale() + "грн");
            MF.ListBox.Items.Add("Щоб замовити, натисніть");
            MF.ListBox.Items.Add("відповідну кнопку знизу!");
            MF.ListBox.SelectedIndex = MF.ListBox.Items.Count - 1;
            MF.ListBox.SelectedIndex = -1;
        }
        //Кастомный бинарный поиск и формирование выбранного пользователем меню
        void BinSerch(int key)
        {
            int midd, left, right, n = 0;
            List<Shoplist> Slist = new List<Shoplist>();
            Shoplist Stemp = new Shoplist();
            left = 0;
            right = Offers.Length;
            while (left < right)
            {
                midd = (left + right) / 2;
                if (key < Offers[midd].Id)
                    right = midd - 1;
                else if (key > Offers[midd].Id)
                    left = midd + 1;
                else
                {
                    for (int i = left; i < right; i++)
                        if (Offers[i].Id == key)
                        {
                            n++;
                            Stemp = new Shoplist();
                            Stemp.Cost = Offers[i].Cost;
                            Stemp.Elements = Offers[i].Elements;
                            Stemp.Id = Offers[i].Id;
                            Stemp.PizzaName = Offers[i].PizzaName;
                            Stemp.ShopName = Offers[i].ShopName;
                            Stemp.Size = Offers[i].Size;
                            Stemp.In = n;
                            Slist.Add(Stemp);
                            Stemp = null;
                        }
                    right = left;
                }
            }
            Shops = Slist.ToArray();
        }

        //Алгоритм сортировки по индексам
        public void BubbleSort()
        {
            Offerlist Otemp = new Offerlist();
            for (int i = 0; i < Offers.Length - 1; i++)
            {
                bool f = false;
                for (int j = 0; j < Offers.Length - i - 1; j++)
                {
                    if (Offers[j + 1].Id < Offers[j].Id)
                    {
                        f = true;
                        Otemp = Offers[j + 1];
                        Offers[j + 1] = Offers[j];
                        Offers[j] = Otemp;
                    }
                }
                if (!f) break;
            }
        }
        //Обработка запроса
        public void UserRequest()
        {
            MF.AddBox.Text = MF.AddBox.Text.Trim();
            MF.ListBox.Items.Add(MF.AddBox.Text);
            MF.ListBox.SelectedIndex = MF.ListBox.Items.Count - 1;
            MF.ListBox.SelectedIndex = -1;
            instr = MF.AddBox.Text.ToUpper();
            switch (instr)
            {
                case "МЕНЮ":
                    Pizza_Menu();
                    break;
                case "КОМАНДИ":
                    Instruction();
                    break;
                case "ПІДКАЗКА":
                    Help();
                    break;
                case "ДОПОМОГА":
                    Help();
                    break;
                case "КОШИК":
                    Basket_menu();
                    break;
                case "ТАК":
                    Order_q();
                    break;
                default:
                    Shop_menu();
                    Order_menu();
                    break;
            }
            MF.AddBox.Clear();
            MF.AddBox.Focus();
            instr = null;
        }

    }
}
