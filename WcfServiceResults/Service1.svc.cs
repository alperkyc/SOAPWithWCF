using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceResults.Models;

namespace WcfServiceResults
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SinavSonuclarDBEntities entity = new SinavSonuclarDBEntities();

        public List<Ogrenciler> getStudents()
        {
            var students = (from o in entity.Ogrenciler select o).ToList();  //LINQ
            //List<Ogrenciler> students = entity.Ogrenciler.ToList(); //Entity Framework with LINQ
            return students.Select(x => new Ogrenciler { ogrenciId = x.ogrenciId, ogrenciAd = x.ogrenciAd, ogrenciTCKN = x.ogrenciTCKN }).ToList();
        }

        public List<Turler> getTypes()
        {
            var types = (from o in entity.Turler select o).ToList();
            //LINQ
            //List<Turler> types = entity.Turler.ToList();
            return types.Select(x => new Turler { turId = x.turId, turAd = x.turAd }).ToList();
        }

        public List<Yillar> getYears()
        {
            //var years = (from o in entity.Yillar select o).ToList();  //LINQ
            List<Yillar> years = entity.Yillar.ToList(); //years'ı direk return yapınca response hatası alıyorum.
            //List<Yillar> temp1 = new List<Yillar>();
           
            //foreach (var item in years)
            //{
            //    Yillar yillar = new Yillar();
            //    yillar.yilId = item.yilId;
            //    yillar.yilAd = item.yilAd;
            //    temp1.Add(yillar);
            //}
            return years.Select(x=>new Yillar { yilId=x.yilId,yilAd=x.yilAd}).ToList();
        }

        public int? getResult(int studentId,int typeId,int yearId)
        {
            var result = (from s in entity.Sonuclar where s.ogrenciId == studentId && s.turId == typeId && s.yilId == yearId select s).FirstOrDefault();
            //Sonuclar result = entity.Sonuclar.Where(x => x.turId.Equals(typeId) && x.ogrenciId.Equals(studentId) && x.yilId.Equals(year)).FirstOrDefault();

            if(result == null)
            {
                return 0;

            }
            return result.sonuc;
        }

        public List<Test> getTestList()
        {
            List<Test> test = new List<Test>();
            Test t1 = new Test();
            t1.Id = 1;
            t1.Name = "Alper";
            test.Add(t1);

            return test;
            
        }
    }
}
