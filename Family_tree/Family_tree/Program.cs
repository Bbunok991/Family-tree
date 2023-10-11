using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family_tree;

namespace Family_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdultFamilyMember Inok = new AdultFamilyMember() { Name = "Инокентий" };

            AdultFamilyMember Marg = new AdultFamilyMember() { Name = "Маргарита" };

            AdultFamilyMember Danila = new AdultFamilyMember() { Name = "Данила" };

            AdultFamilyMember Liza = new AdultFamilyMember() { Name = "Лиза" };

            AdultFamilyMember Roman = new AdultFamilyMember() { Name = "Роман" };

            AdultFamilyMember Katya = new AdultFamilyMember() { Name = "Катя" };

            FamilyMember Ivan = new FamilyMember()
            {
                Name = "Иван",
                Father = Inok,
                Mother = Marg,
                FatherRalative = Danila,
                MotherRelative = Liza
            };

            Inok.Children = new FamilyMember[] { Ivan, new FamilyMember() { Name = "Вера" }, new FamilyMember() { Name = "Надежда" }, new FamilyMember() { Name = "Артем" }, new FamilyMember() { Name = "Эллин" } };
            Marg.Children = new FamilyMember[] { Ivan, new FamilyMember() { Name = "Роман" }, new FamilyMember() { Name = "Катя" }, new FamilyMember() { Name = "Руслан" }, new FamilyMember() { Name = "Настя" } };



            FamilyMember Mary = new FamilyMember()
            {
                Name = "Мария",
                Father = new FamilyMember() { Name = "Инокентий2" },
                Mother = new FamilyMember() { Name = "Маргарита" },
                FatherRalative = Roman,
                MotherRelative = Katya
            };
            FamilyMember Son = new FamilyMember() { Name = "Петя", Father = Ivan, Mother = Mary };


            Inok.Info(2);
            Marg.Info(2);


            //Домашняя работа
            //Доработайте приложение генеалогического дерева таким образом чтобы программа выводила на экран близких родственников(жену / мужа).


            Console.ReadLine();

        }
    }
}