using System;
namespace Family_tree
{
    public enum Gender
    {
        Male,
        Female
    }

    public class FamilyMember
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public FamilyMember Father { get; set; }
        public FamilyMember Mother { get; set; }
        public FamilyMember MotherRelative { get; set; }
        public FamilyMember FatherRalative { get; set; }
        public Gender Gend { get; set; }
        public virtual void Info(int indent = 0)
        {
            for (int i = 0; i < indent; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine($"Имя: {Name}, родители: {Father?.Name}, {Mother?.Name}, родственники: {MotherRelative?.Name}, {FatherRalative?.Name}");
        }

        public void ShowParent()
        {
            if (Father == null)
                Console.WriteLine("Отец неизвестен");
            else
                Console.WriteLine("Отец:" + Father.Name);
            Console.WriteLine("Мать:" + Mother?.Name);
        }

        public void ShowRelative()
        {
            Console.WriteLine("Родственник матери: " + MotherRelative?.Name);
            Console.WriteLine("Родственник отца: " + FatherRalative?.Name);
        }

        public void ShowGrandParent()
        {

            Console.WriteLine("По отцовской линии:");
            Console.WriteLine("Дедушка:" + Father?.Father?.Name);
            Console.WriteLine("Бабушка:" + Father?.Mother?.Name);

            Console.WriteLine("По материнской линии:");
            Console.WriteLine("Дедушка:" + Mother?.Father?.Name);
            Console.WriteLine("Бабушка:" + Mother?.Mother?.Name);
        }
    }
    public class AdultFamilyMember : FamilyMember
    {
        public FamilyMember[] Children { get; set; }
        public override void Info(int indent = 0)
        {
            base.Info(indent);
            foreach (var child in Children)
            {
                child.Info(indent * 2);
                //Console.WriteLine(child.Name);

            }
        }
    }
}

