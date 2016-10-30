using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace OrganazerLibrary
{
    public class DbContract : IContract
    {
        public List<Taska> GetAllTaskas()
        {
            List<Taska> allTaskas;
            using (var organazer = new OrganazerEntities())
            {
                allTaskas = organazer.TaskaDb.Select(x => new Taska()
                {
                    Id = x.id,
                    Subject = x.idSubject,
                    AttachmensFiles = x.attachmensFiles,
                    DataFinish = x.dataFinish,
                    Status = (StatusTaska)x.status
                })?.ToList<Taska>();
            }
            return allTaskas;
        }
        public List<Taska> GetTaskasForDay(DayOfWeek dayOfWeek)
        {
            var taskasForDay = new List<Taska>();
            using (var organazer = new OrganazerEntities())
            {
                var subjectInDay = organazer.ScheduleDb.Where(x => x.dayOfWeek == (int)dayOfWeek).ToList();
                foreach (var subject in subjectInDay)
                {
                    taskasForDay.AddRange(GetTaskasForSubject(subject.idSubject));
                }
            }
            return taskasForDay;
        }
        public List<Taska> GetTaskasForSubject(int idSubject)
        {
            List<Taska> subjectTaskas;
            using (var organazer = new OrganazerEntities())
            {
                subjectTaskas = organazer.TaskaDb.Where(x => x.idSubject == idSubject).Select(x => new Taska()
                {
                    Id = x.id,
                    Subject = x.idSubject,
                    AttachmensFiles = x.attachmensFiles,
                    DataFinish = x.dataFinish,
                    Status = (StatusTaska)x.status
                })?.ToList<Taska>();
            }
            return subjectTaskas;
        }
        public List<Subject> GetAllSubjects()
        {
            List<Subject> allSubjects;
            using (var organazer = new OrganazerEntities())
            {
                allSubjects = organazer.SubjectDb.Select(x => new Subject()
                {
                    Id = x.id,
                    Name = x.name
                })?.ToList<Subject>();
            }
            return allSubjects;
        }
        public List<Schedule> GetScheduleInDay(DayOfWeek dayOfWeek)
        {
            List<Schedule> scheduleInDay;
            using (var organazer = new OrganazerEntities())
            {
                scheduleInDay = organazer.ScheduleDb.Where(x => x.dayOfWeek == (int)dayOfWeek).Select(x => new Schedule()
                {
                    Subject = x.idSubject,
                    DayOfWeek = (DayOfWeek)x.dayOfWeek
                }).ToList();

            }
            return scheduleInDay;
        }
        public List<Subject> GetSubjectsForId(int idSubject)
        {
            List<Subject> allSubjects;
            using (var organazer = new OrganazerEntities())
            {
                allSubjects = organazer.SubjectDb.Where(x => x.id == idSubject).Select(x => new Subject()
                {
                    Id = x.id,
                    Name = x.name
                })?.ToList<Subject>();
            }
            return allSubjects;
        }
    }
}