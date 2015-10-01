using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Pupil pupil1 = new Pupil("Aurelie", 6, 1);

            Activity coloriage = new Activity("Coloriage", true);
            pupil1.AddActivity(coloriage);
            pupil1.AddEvaluation("Coloriage");
            pupil1.AddEvaluation(evaluation: 'T', title: " Coloriage");

            //List<Pupil> lstPupil = new List<Pupil>()
            //{
            //     new Pupil("Antoine", 7, 1),
            //     new Pupil("Marc",9, 4),
            //     new Pupil("Marine",8, 3),
            //     new Pupil("Henri", 7, 1),
            //     new Pupil("Amelie", 10, 5),
            //     new Pupil("Anna", 6, 1),
            //     new Pupil("Lena", 7, 2),
            //     new Pupil("George", 6, 1),
            //     new Pupil("Albert", 6, 1),
            //     new Pupil("kate", 8, 3),
            //     new Pupil("Charles", 7, 3),
            //     new Pupil("Henri", 6, 1),
            //     new Pupil("Marcelle",10, 4),
            //};

            //var pupilGrade1Plus6 = from Pupil in lstPupil
            //                       where Pupil.Age > 6 && Pupil.Grade == 1
            //                       select Pupil;

            //Expression lambda
            //var pupilGrade1Plus6 = lstPupil.Where(Pupil => Pupil.Age > 6 && Pupil.Grade == 1);

            //if (pupilGrade1Plus6 != null )
            //{
            //    foreach ( var Pupil in pupilGrade1Plus6 )
            //    {
            //        System.Console.Write(Pupil);
            //    }
            //}
            
                 // COVARIANCE
            //List<Pupil> listPupils = new List<Pupil>()
            //{
            //    new Pupil("Marc",19,2),
            //    new Pupil("Albert",20,2),
            //    new Pupil("Marie",21,3),
            //    new Pupil("Luca",18,1),
            //    new Pupil("jean",19,1),
            //    new Pupil("Charles",21,3),
            //};

            //List<Person> listPersons = new List<Person>()
            //{
            //    new Person("Marc",19),
            //    new Person("Albert",20),
            //    new Person("Marie",21),
            //    new Person("Luca",18),
            //    new Person("jean",19),
            //    new Person("Charles",21),
            //};

            //var listFusion = listPersons.Union(listPupils);
            //if (listFusion != null)
            //{
            //    foreach (var Person in listFusion )
            //    {
            //        System.Console.Write(Person);
            //    }
            //}

            List<Pupil> listPupilsDuplicated = new List<Pupil>()
            {
                new Pupil("Marc",19,2),
                new Pupil("Marc",19,1),
                new Pupil("Albert",20,3),
                new Pupil("Albert",20,2),
                new Pupil("Marie",21,1),
                new Pupil("Marie",21,3),
                new Pupil("Luca",18,2),
                new Pupil("Luca",18,1),
                new Pupil("jean",19,3),
                new Pupil("jean",19,1),
            };
            IEnumerable<Pupil> listPupilsNoDuplicated = listPupilsDuplicated.Distinct<Pupil>(
                new PersonComparer());

            System.Console.Write(listPupilsNoDuplicated.Count());

           // Pupil pupil1 = new Pupil("Jean", 8, 'T');
           // pupil1.AddActivity(activity3);
            //Activity activity2 = new Activity("Danse", false);
            //Activity activity3 = new Activity("Sport", true);
            //System.Console.Write(pupil2);

            //System.Console.Write(pupil1);

            
            System.Console.Read();
        }
    }
}
