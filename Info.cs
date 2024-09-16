using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shubenokAleks1
{
    public static class Info
    {
        public static Agent agentProd = new Agent();
        public static Agent agentEdit = new Agent();

        public static List<string> typeAg = new List<string>
        {
            new string ("Первый тип"),
            new string ("Второй тип"),
            new string ("Третий тип"),


        };




        public static List<string> prior = new List<string>
        {
            new string ("Первый приоритет"),
            new string ("Второй приоритет"),
            new string ("Третий приоритет"),


        };
        public static List<Agent> agents = new List<Agent>
        {
            new Agent
            {
                id = 0,
                namecomp="Компания1",
                amount=12000,
                address="gfffffffffffffffff",
                fioDir="Анатолий Викторович Земляков",
                prior="Первый приоритет",
                INN="5643634564536",
                Kpp="5355235355",
                phone="793366622233",
                mail="fgds@uygtiyu.tt",
                imgpath="img1.png",
                type="Второй тип",
                prodazhi = new List<Prodazha>{
                    new Prodazha{
                    date=new string ("02.04.2001 17:47"),
                    kolvo = 111333,
                    
                    },

                    new Prodazha{
                    date=new string ("23.08.2021 17:07"),
                    kolvo = 20000,

                    },

                }

            },
             new Agent
            {
                 id = 1,
                namecomp="Компания2",
                amount=900000,
                address="hjgggghhhhhhhhhhhhhhh",
                fioDir="Анастасия Викторовна Кудряшова",
                prior="Первый приоритет",
                INN="562333564536",
                Kpp="23333333",
                phone="79331232233",
                mail="аhjkjk@wdwww.tt",
                imgpath="img2.png",
                type="Третий тип",
                 prodazhi = new List<Prodazha>{
                    new Prodazha{
                    date=new string ("11.09.2021 13:47"),
                    kolvo = 129000,

                    },

                    new Prodazha{
                    date=new string ("20.08.2013 17:07"),
                    kolvo = 300000,

                    },

                }


            },
              new Agent
            {
                  id = 2,
                namecomp="Компания3",
                amount=200000,
                address="ghiuiuiuiiu",
                fioDir="Михаил Алексеевич Казанцев",
                prior="Второй приоритет",
                INN="989989889",
                Kpp="3444343443",
                phone="79119092233",
                mail="qwqwww@gfgf.tt",
                imgpath="img3.png",
                type="Второй тип",
                  prodazhi = new List<Prodazha>{
                    new Prodazha{
                    date=new string ("28.11.2020 13:47"),
                    kolvo = 19000,

                    },

                    new Prodazha{
                    date=new string ("20.08.2013 09:07"),
                    kolvo = 150000,

                    },

                }

            },
              new Agent
            {
                  id = 3,
                namecomp="Компания4",
                amount=30000,
                address="ghiuiuiuiiu",
                fioDir="Виктор Николаевич Мирошниченко",
                prior="Третий приоритет",
                INN="556556565",
                Kpp="676656",
                phone="79119091111",
                mail="mmmmm@eegf.ff",
                imgpath="img4.png",
                type="Третий тип",
                prodazhi = new List<Prodazha>{
                    new Prodazha{
                    date=new string ("17.11.2020 13:47"),
                    kolvo = 190000,

                    },

                    new Prodazha{
                    date=new string ("20.08.2013 09:07"),
                    kolvo = 2000,

                    },

                }

            },
               new Agent
            {
                   id= 4,
                namecomp="Компания5",
                amount=120000,
                address="dfdfdcccccc",
                fioDir="Алла Николаевна Рыбакова",
                prior="Первый приоритет",
                INN="929229992",
                Kpp="344443433",
                phone="79237771111",
                mail="ааа@ee44gf.ff",
                imgpath="img5.png",
                type="Первый тип",
                prodazhi = new List<Prodazha>{
                    new Prodazha{
                    date=new string ("10.11.2010 13:47"),
                    kolvo = 300000,

                    },

                    new Prodazha{
                    date=new string ("20.08.2005 09:07"),
                    kolvo = 200010,

                    },

                }

            },

                new Agent
            {
                    id = 5,
                namecomp="Компания6",
                amount=500000,
                address="dfsdfsssss",
                fioDir="Андрей Андреевич Валютин",
                prior="Первый приоритет",
                INN="6622939",
                Kpp="78787878",
                phone="79112228881",
                mail="IUYioyh@jkj.rf",
                imgpath="img7.png",
                type="Второй тип",
                 prodazhi = new List<Prodazha>{
                    new Prodazha{
                    date=new string ("07.11.2010 13:47"),
                    kolvo = 1000,

                    },

                    new Prodazha{
                    date=new string ("20.08.2005 09:07"),
                    kolvo = 189000,

                    },

                }

            },

                 new Agent
            {
                     id= 6,
                namecomp="Компания2",
                amount=700000,
                address="tyhthddhtdf",
                fioDir="Мария Николаевна Абрамова",
                prior="Второй приоритет",
                INN="788799999",
                Kpp="342222222",
                phone="79110001100",
                mail="frffdfff@ooo.ff",
                imgpath="img8.png",
                type="Первый тип",

                prodazhi = new List<Prodazha>{
                    new Prodazha{
                    date=new string ("07.11.2010 13:47"),
                    kolvo = 26000,

                    },

                    new Prodazha{
                    date=new string ("20.08.2005 09:07"),
                    kolvo = 20000,

                    },

                }

            },




        };
    }

    public class Prodazha
    {
        public string date { get; set; }

        public int kolvo { get; set; }
    
    }


    public class Agent
    {
        public int id { get; set; }
        public string namecomp { get; set; }
        public string fioDir { get; set; }
        public int amount { get; set; }
        public string phone { get; set; }
        public string imgpath { get; set; }
        public string disc { get; set; }
        public string mail { get; set; }
        public string prior { get; set; }

        public string INN { get; set; }

        public string Kpp { get; set; }
        public string address { get; set; }
        public string type { get; set;}
        public int allprod { get; set; }
        public List<Prodazha> prodazhi { get; set; }

    }
}
