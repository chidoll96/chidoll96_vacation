using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace 가계부
{
    
    
    class date
    {
        private static int added_date { get; set; }
        public int add_date()
        {
            Console.WriteLine("add date");
            int input_date = Int32.Parse(Console.ReadLine());
            
            return added_date = input_date;
        }
        public void search_date()
        {
            Console.Write("date : " + added_date + " ");
        }  
    }
    class contents
    { 
        private static string added_contents { get; set; }
        public string add_contents()
        {
            Console.WriteLine("add contents");
            string Contents = Console.ReadLine();
            return added_contents=Contents;
        }
       
        public void search()
        {
            Console.Write("Contents : "+added_contents+"   ");
        }

    }
       class money
       {
           private static int added_money { get; set; }
           private static int tomoney { get; set; }
           public int add_money()
           {
               Console.WriteLine("add money");
               int Money = Int32.Parse(Console.ReadLine());
               return added_money = Money;
           }
           public int total()
           {
               return tomoney += added_money;
           }
           public void search_money()
           {
               Console.Write("Money : " +added_money+" ");
           }
         
           public void search_total()
           {
               Console.WriteLine("Total : "+tomoney);
           }
       }
    class moneybook
    {
        public struct Moneybook
        {
            public int date; public int money; public string contents; public int total;
        }
        public void run()
        {
             date Date = new date();
            contents Contents = new contents();
            money Money = new money();
            List < moneybook.Moneybook >book= new List<moneybook.Moneybook>();
            
            while (true)
            {
                Console.WriteLine("1.Add" +  '\n' + "2.search" + '\n' + "3.quit");
                int num = Int32.Parse(Console.ReadLine());
                if (num == 1)
                {
                  moneybook.Moneybook a = new moneybook.Moneybook();
                   
                  a.date= Date.add_date();
                  a.money=Money.add_money();
                  a.total =Money.total();
                  a.contents=Contents.add_contents();
                  book.Add(a);
                   
                }
                else if (num==2)
                {
                   
                        for (int i = 0; i < book.Count; i++)
                        {
                            Console.WriteLine("date : {0} money : {1} contents : {2} total : {3}", book[i].date, book[i].money, book[i].contents, book[i].total);
                        }
                   }
                else if (num == 3)
                {
                    break;
                }
            }
        }
       }
       

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Money Book Project.");
            moneybook Moneybook = new moneybook();
            Moneybook.run();
        }
    }
}
