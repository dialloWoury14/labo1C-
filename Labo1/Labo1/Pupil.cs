using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    public class Pupil : Person
    {

        public int Grade{get; set;}

        public List<Activity> LstActivities{get;set;}

        public char[] TabEval
        {
            get;
            set;
        }
        //on souhaire regrouper activité et évaluation   + recherche plus rapide
        public Dictionary<String, char> DictionnaryActivities { get; set; }

        public Pupil(String name, int age, int grade) : base(name,age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
        }
        public Pupil(String name, int age) : this(name, age, 1) { }

        public void AddActivity(Activity activity)
        {
            LstActivities.Add(activity);
        }
        public override string ToString()
        {
            string ch = base.ToString() + ((LstActivities.Count() != 0) ? " a choisi les activités suivantes : \n"
                : " n'a pas encore choisi d'activité\n\n");
            int i;
            for (i = 0; i < LstActivities.Count(); i++)
            {
                ch += LstActivities[i].ToString();
            }
            return ch;
        }
        public void AddEvaluation( String title = null, char evaluation = 'S' )
        {
            int i = 0;
            if( title != null )
            {
                foreach(Activity activity in LstActivities )
                {
                    if (activity.Title.Equals(title)) break;
                    i++;
                }
                TabEval[i] = evaluation;
            }
        }
    }
}
