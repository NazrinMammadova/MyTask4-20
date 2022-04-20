using System;
using System.Collections.Generic;
using System.Text;

namespace StTask
{
   class Student
   {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Group{ get; set; }
        public int Point{ get; set; }
        public bool isGraduated { get; set; }
        public void Info()
        {
            Console.WriteLine($"{this.Name} {this.SurName} ") ;
        }

        public void FullInfo()
        {
            if (this.isGraduated==true)
            {
                Console.WriteLine($"\n Ad: {this.Name}\n Group: {this.Group} \n Soyad:{this.SurName}\n Topladigi bal:{this.Point} \n Mezundur ");
            }
            else
            {
                Console.WriteLine($"\n Ad: {this.Name}\n Group: {this.Group} \n Soyad:{this.SurName}\n Topladigi bal:{this.Point} \n Mezun deyil ");
            }
           
        }
        public void CheckScore()
        {
            if (this.Point>80)
            {
                Console.WriteLine(" ikinci imtahana gire biler");
            }
            else
            {
                Console.WriteLine("kifayet qeder bal toplamayib");
            }
        }
    }

   
}
