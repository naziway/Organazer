using System.Collections.Generic;

namespace OrganazerLibrary
{
    public class DbContract:IContract
    {
        public List<Taska> GetAllTaskas()
        {
            throw new System.NotImplementedException();
        }

        public List<Taska> GetTaskasForDay(DayOfWeek dayOfWeek)
        {
            throw new System.NotImplementedException();
        }

        public List<Taska> GetTaskasForSubject(int idSubject)
        {
            throw new System.NotImplementedException();
        }

        public List<Subject> GetAllSubjects()
        {
            throw new System.NotImplementedException();
        }

        public List<Subject> GetScheduleInDay()
        {
            throw new System.NotImplementedException();
        }
    }
}