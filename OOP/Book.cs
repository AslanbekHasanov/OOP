using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Book
    {
        //1- vazifa
        //construktor: default
        public Book()
        {
            
        }
        //construktor: nomi nomli fieldga qiymat berish
        public Book(string nomi)
        {
            this.nomi = nomi;
        }
        //private kurinishidagi fieldlar
        private string nomi = "Sariq dev";
        private string muallifi = "Xudoyberdi To'xtaboyev";
        private decimal narxi = 50000;

        //kitob nomini olish
        public void GetBookName()
        {
            Console.WriteLine($"Kitob nomi: {this.nomi}");
        }
        
        //2- vazifa
        //2.1-vazifa
        //fieldlar uchun propertylar
        public string Nomi 
        {
            get
            {
                return this.nomi;
            }
            set
            {
                this.nomi = value;

            } 
        }
        public string Muallifi 
        {
            get
            {
                return this.muallifi;
            }
            set
            {
                this.muallifi = value;
            }
        }
        public decimal Narxi 
        {
            get
            {
                return this.narxi; 
            }
            set
            {
                this.narxi = value;
            }
        }

        public void GetFieldsInClass()
        {
            Console.WriteLine($"Kitob nomi: {this.nomi}");
            Console.WriteLine($"Kitob muallifi: {this.muallifi}");
            Console.WriteLine($"Kitob narxi: {this.narxi}");
        }
        //3-vazifa

        public string Haqida { get; set; }

        public DateTime IshlabChiqarilganSana { get; set; }

        public void GetBookInfo()
        {
            Console.WriteLine($"Kitob nomi: {this.nomi}");
            Console.WriteLine($"Kitob narxi: {this.narxi}");
            Console.WriteLine($"Kitob muallifi: {this.muallifi}");
            Console.WriteLine($"Kitob haqida: {this.Haqida}");
            Console.WriteLine($"Kitob ishlab chiqarilgan sana: {this.IshlabChiqarilganSana}");
        }





    }
}
