using System;

namespace StTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Tasks:
         //   1.Verilen cumleni(Meselen: bU tasKI metHodla yAzmAliSiz)
         //   capitalized(her sozun bash herfi boyuk)
         //   formatinda geriye qaytaran bir method yazin
         //   (Bu Taski Methodla Yazmalisiz formatinda qayitmalidi)

            //Task start
            string str = "bU tasKI metHodla yAzmAliSiz";
             toCapitalize(str);




            // 2. Student classi yaradirsiz. Name, Surname, Group, Point,
            // isGraduated(mezun olub olmadigi ile bagli boolean bir type olacaq) field-leri olacaq.
            // Student classindan instance alindigi zaman birbasha
            // student field-lerinin deyerleri dinamik sekilde teyin olunsun.      
            // Studentin Ad ve soyadini geriye qaytaran bir method yazirsiz.
            //Studentin butun deyerlerini geriye qaytaran bir method yazirsiz.
            //Eger mezun olubsa butun deyerlerden sonra bu telebe mezun olub deye yazilsin,
            //eger mezun olmayibsa mezun olmadigi ile bagli bir melumat yazilsin
            //Studentin balini artirmaq ucun novbeti imtahana girib gire bilmeyeceyi
            //ile bagli bir melumat geriye qaytaran method yazirsiz.
            //Bali 80 - den yuxari telebeler ikinci imtahana gire biler,
            //asagi olan telebeler ise gire bilmezler

            //Task start


            Student student1 = new Student();
            student1.Name = "Nazrin";
            student1.SurName = "Mammadova";
            student1.Point = 85;
            student1.Group = "P324";
            student1.isGraduated = true;
            student1.Info();
            student1.FullInfo();
            student1.CheckScore();

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");

            Student student2 = new Student();
            student2.Name = "Lale";
            student2.SurName = "Aliyeva";
            student2.Point = 67;
            student2.Group = "P324";
            student2.isGraduated = false;
            student2.Info();
            student2.FullInfo();
            student2.CheckScore();



        }

        public static void toCapitalize(string Mystr)
        {
            string[] strArr = Mystr.Split(' ');
            for (int i = 0; i < strArr.Length; i++)
            {

                string word = strArr[i].ToUpper();

                Console.Write(word[0] + word.Substring(1).ToLower() + ' ');

            }
        }
    }
   
}
