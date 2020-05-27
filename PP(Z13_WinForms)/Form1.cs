using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PP_Z13_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Client
        {
            public abstract string PrintInfo();
            public abstract bool IsClientByDate(DateTime date);
        }
        public class Investor : Client
        {
            public string Surname { get; set; }
            public DateTime DepositDate { get; set; }
            public decimal DepositAmount { get; set; }
            public double DepositInterest { get; set; }

            public Investor(string surname, DateTime depositDate, decimal depositAmount, double depositInteres)
            {
                Surname = surname;
                DepositDate = depositDate;
                DepositAmount = depositAmount;
                DepositInterest = depositInteres;
            }

            public override string PrintInfo()
            {
                string s = "";
                s+="Фамилия вкладчика: " + Surname + "\n";
                s +="Дата открытия вклада: " + DepositDate.ToShortDateString() + "\n";
                s +="Размер вклада: " + DepositAmount + "\n";
                s +="Процент по вкладу: " + DepositInterest + "%\n";
                return s;
            }

            public override bool IsClientByDate(DateTime date)
            {
                if (DepositDate == date)
                    return true;
                return false;
            }
        }
        public class Creditor : Client
        {
            public string Surname { get; set; }
            public DateTime CreditDate { get; set; }
            public decimal CreditAmount { get; set; }
            public double CreditInterest { get; set; }
            public decimal CreditBalance { get; set; }

            public Creditor(string surname, DateTime creditDate, decimal creditAmount, double creditInterest,
                            decimal creditBalance)
            {
                Surname = surname;
                CreditDate = creditDate;
                CreditAmount = creditAmount;
                CreditInterest = creditInterest;
                CreditBalance = creditBalance;
            }

            public override string PrintInfo()
            {
                string s = "";
                s += "Фамилия кредитора: " + Surname + "\n";
                s += "Дата выдачи кредита: " + CreditDate.ToShortDateString() + "\n";
                s += "Размер кредита: " + CreditAmount + "\n";
                s += "Процент по кредиту: " + CreditInterest + "%\n";
                s += "Остаток долга: " + CreditBalance + "\n";
                return s;
            }

            public override bool IsClientByDate(DateTime date)
            {
                if (CreditDate == date)
                    return true;
                return false;
            }
        }
        public class Organization : Client
        {
            public string Name { get; set; }
            public DateTime AccountDate { get; set; }
            public int AccountNumber { get; set; }
            public decimal AccountAmount { get; set; }

            public Organization(string name, DateTime accountDate, int accountNumber, decimal accountAmount)
            {
                Name = name;
                AccountDate = accountDate;
                AccountNumber = accountNumber;
                AccountAmount = accountAmount;
            }

            public override string PrintInfo()
            {
                string s = "";
                s += "Название организации: " + Name + "\n";
                s += "Дата открытия счета: " + AccountDate.ToShortDateString() + "\n";
                s += "Номер счета: " + AccountNumber + "\n";
                s += "Сумма на счету: " + AccountAmount + "\n";
                return s;
            }

            public override bool IsClientByDate(DateTime date)
            {
                if (AccountDate == date)
                    return true;
                return false;
            }
        }
        private void Result_Click(object sender, EventArgs e)
        {
            string rez = "";
            List<Client> clientList = new List<Client>();
            StreamReader sr = new StreamReader(@"C:\Users\Алина\Desktop\file.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (s.Length == 5)
                {
                    clientList.Add(new Creditor(s[0], Convert.ToDateTime(s[1]), Convert.ToDecimal(s[2]),
                                                      Convert.ToDouble(s[3]), Convert.ToDecimal(s[4])));
                }
                if (s.Length == 4)
                {
                    int number;
                    if (Int32.TryParse(s[2], out number))
                    {
                        clientList.Add(new Organization(s[0], Convert.ToDateTime(s[1]),
                                                     number, Convert.ToDecimal(s[3])));
                    }
                    else
                    {
                        clientList.Add(new Investor(s[0], Convert.ToDateTime(s[1]),
                                  Convert.ToDecimal(s[2]), Convert.ToDouble(s[3])));
                    }
                }
            }
            sr.Close();
            foreach (Client client in clientList)
            {
                rez +=client.PrintInfo()+ "\n";
            }
            roster.Text = rez.ToString();

            DateTime askDate = new DateTime(2019, 8, 9);
            int foundClients = 0;

            foreach (Client client in clientList)
            {
                if (client.IsClientByDate(askDate))
                {
                    search.Text = client.PrintInfo();
                    foundClients++;
                }
            }
            if (foundClients == 0)
            {
                search.Text = "Клиенты по данной дате не найдены!";
            }
        }
    }
}
