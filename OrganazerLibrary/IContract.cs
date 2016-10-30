using System.Collections.Generic;

namespace OrganazerLibrary
{
    public interface IContract
    {
        List<Taska> GetAllTaskas();
        List<Taska> GetTaskasForDay(DayOfWeek dayOfWeek);
        List<Taska> GetTaskasForSubject(int idSubject);
        List<Subject> GetAllSubjects();
        List<Schedule> GetScheduleInDay(DayOfWeek dayOfWeek);
        List<Subject> GetSubjectsForId(int idSubject);
    }
}