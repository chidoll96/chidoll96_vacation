using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class refeigerator{
        public struct list
        {
           public string Name,Iden; 
        }
        private List<list> drinklist = new List<list>();
        public void function()
        {
            int funnum, drinknum;
            string name, iden;  
            list wow = new list();
            while(true){
                Console.WriteLine("할일 선택");
                Console.WriteLine("1.넣기");
                Console.WriteLine("2.빼기");
                Console.WriteLine("3.조회");
                Console.WriteLine("4.종료");
                funnum = Int32.Parse(Console.ReadLine());
                if (funnum == 1)
                {
                    Console.WriteLine("넣을 술의 종류는?");
                    Console.WriteLine("1. 와인, 2. 소주, 3. 맥주");
                    drinknum = Int32.Parse(Console.ReadLine());
                    if (drinknum == 1)
                    {   
                        Console.WriteLine("넣을 와인의 이름은?");
                        name="와인 :"+Console.ReadLine();
                        wow.Name=name;
                        Console.WriteLine("넣을 와인의 연식은?");
                        iden=Console.ReadLine();
                        wow.Iden = iden;
                        drinklist.Add(wow);
                    }
                    else if (drinknum == 2)
                    {
                        Console.WriteLine("넣을 소주의 이름은?");
                        name ="소주 :" +Console.ReadLine();
                        wow.Name = name;
                        Console.WriteLine("넣을 소주의 도수는?");
                        iden = Console.ReadLine();
                        wow.Iden = iden;
                        drinklist.Add(wow); ;
                    }
                    else
                    {
                        Console.WriteLine("넣을 맥주의 이름은?");
                        name ="맥주 :" +Console.ReadLine();
                        wow.Name = name;
                        Console.WriteLine("넣을 맥주의 종류는?");
                        iden = Console.ReadLine();
                        wow.Iden = iden;
                        drinklist.Add(wow);
                    }
                }
                if (funnum == 2)
                {
                        Console.WriteLine("뺄 술의 이름은?");
                        name = Console.ReadLine();
                        for(int i=0;i<drinklist.Count;i++)
                        {
                            if (drinklist[i].Name == name)
                            {
                                drinklist.RemoveAt(i);
                            }
                            else
                            {
                                Console.WriteLine("냉장고에 없는 물건");
                                break;
                            }
                        }
                }
                else if (funnum == 3)
                {
                    foreach (var item in drinklist)
                    {
                        Console.WriteLine(item.Name + " " + item.Iden);
                    }
                }
                else if (funnum == 4)
                    break;
            }
        }
    }
    class drink{
        protected string type;
        protected string name;
        protected string property;
    
        public virtual void sound()
        {
            Console.WriteLine("술 : 알코올");
        }
    }
    class wine : drink{
      
        public override void sound()
        {
            Console.WriteLine("와인 : 포도로 만듬");
        }
    }
    class soju : drink
    {
        public override void sound()
        {
            Console.WriteLine("소주 : 에탄올로 만듬");
        }
    }
    class beer : drink
    { 
    public override void sound()
        {
            Console.WriteLine("맥주 : 보리로 만듬");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            refeigerator abc = new refeigerator();
            drink Drink = new drink();
            drink Beer = new beer();
            drink Soju = new soju();
            drink Wine = new wine();
            Drink.sound();
            Beer.sound();
            Soju.sound();
            Wine.sound();
            abc.function();
            
        }
    }
}
