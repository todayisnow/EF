using EF.DataModel;
using System;
using System.Data.Entity;
using System.Linq;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                //context.Ninjas.Add(new Classes.Ninja
                //{
                //    ClanId = 1,
                //    DateOfBirth = DateTime.Now,
                //    Name = "esam",
                //    ServedInOniwaban = false
                //});
                //context.SaveChanges();

                //var n = context.Ninjas.First();
                //n.Name = "LoLy";
                //context.SaveChanges();

                 var data = context.Ninjas.Find(5);
                data.Name = "mai";
                data.EquipmentOwned = new System.Collections.Generic.List<Classes.NinjaEquipment>();
                data.EquipmentOwned.Add(new Classes.NinjaEquipment
                {
                    Name = "sadf",
                    Type = Classes.EquipmentType.Outwear
                });
                context.SaveChanges();

                //var d = context.Ninjas.SqlQuery("select * from Ninjas").ToList();




            }
            Console.ReadKey();
        }
    }
}
