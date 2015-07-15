using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Prac
{
    class Refrigerator
    {
        private List<Drink> Items = new List<Drink>();
        public void run()
        {
            bool isEnd = false;
            while (!isEnd)
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("It is Refrigerator Program. What do you want?");
                Console.WriteLine("1: Insert  2: Withdraw  3: View  4: Exit");
                int command = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (command)
                {
                    case 1:
                        Console.WriteLine("Please Input Type, Name, Add-Property.");
                        Console.WriteLine("<Example>\nSoju\nChamISeul\n14\n");
                        string tmpType = Console.ReadLine();
                        string tmpName = Console.ReadLine();
                        string tmpProperty = Console.ReadLine();
                        InputItems(tmpType, tmpName, tmpProperty);
                        break;
                    case 2:
                        Console.WriteLine("Please Input Withdraw name");
                        string tmpIndex = Console.ReadLine();
                        WithdrawItems(tmpIndex);
                        break;
                    case 3:
                        ViewItems();
                        break;
                    case 4:
                        isEnd = true;
                        break;
                }
            }
        }

        public void InputItems(string type, string name, string property)
        {
            Console.Clear();
            Drink drink = new Drink();
            if (type == "Wine")
            {
                drink = new Wine(name, property);
                Items.Add(drink);
                Console.WriteLine("Completed.");
            }
            else if (type == "Soju")
            {
                drink = new Soju(name, property);
                Items.Add(drink);
                Console.WriteLine("Completed.");
            }
            else if (type == "Beer")
            {
                drink = new Beer(name, property);
                Items.Add(drink);
                Console.WriteLine("Completed.");
            }
            else
            {
                Console.WriteLine("Invalid Input..");
            }
        }

        public void WithdrawItems(string removeItem)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].NAME == removeItem)
                {
                    Items.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine("Completed.");
        }

        public void ViewItems()
        {
            foreach (Drink drink in Items)
            {
                if (drink.TYPE == "Wine")
                {
                    Console.WriteLine("This is Wine and It names " + drink.NAME + " and It's " + drink.PROPERTY + " Years old.");
                }
                else if (drink.TYPE == "Soju")
                {
                    Console.WriteLine("This is Soju and It names " + drink.NAME + " and It's " +drink.PROPERTY + " Contents.");
                }
                else if (drink.TYPE == "Beer")
                {
                    Beer beer = (Beer)drink;
                    Console.WriteLine("This is Beer and It names " + beer.NAME + " and It's " + beer.PROPERTY + " Type.");
                }
                else
                {
                    Console.WriteLine("??????????????????????????");
                }
            }
        }
    }

    class Drink
    {
        protected string m_name;
        protected string m_property;
        protected string m_type;
        public string NAME
        {
            get { return m_name; }
            set { m_name = value; }
        }
        public string PROPERTY
        {
            get { return m_property; }
            set { m_property = value; }
        }
        public string TYPE
        {
            get { return m_type; }
            set { m_type = value; }
        }
    }
    class Wine : Drink
    {
        public Wine(string inputName, string inputProp)
        {
            m_type = "Wine";
            m_name = inputName;
            m_property = inputProp;
        }
    }
    class Soju : Drink
    {
         public Soju(string inputName, string inputProp)
        {
            m_type = "Soju";
            m_name = inputName;
            m_property = inputProp;
        }
    }
    class Beer : Drink
    {
          public Beer(string inputName, string inputProp)
        {
            m_type = "Beer";
            m_name = inputName;
            m_property = inputProp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator refri = new Refrigerator();
            refri.run();
        }
    }
}
