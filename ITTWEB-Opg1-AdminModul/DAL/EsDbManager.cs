using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.DAL
{
    public class EsDbManager
    {
        #region Components

        public IList<Component> GetAllComponents()
        {
            using (var db = new EsDbContext())
            {
                return db.Components.Include(c => c.ComponentType).ToList();
            }
        }

        public Component GetComponent(int? id)
        {
            using (var db = new EsDbContext())
            {
                return db.Components.Find(id);
            }
        }

        public void CreateComponent(Component component)
        {
            using (var db = new EsDbContext())
            {
                db.Components.Add(component);
                db.SaveChanges();
            }
        }

        public void UpdateComponent(Component component)
        {
            using (var db = new EsDbContext())
            {
                db.Entry(component).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteComponent(int id)
        {
            using (var db = new EsDbContext())
            {
                var component = db.Components.Find(id);
                db.Components.Remove(component);
                db.SaveChanges();
            }
        }

        public IEnumerable<ComponentType> GetComponentTypes()
        {
            using (var db = new EsDbContext())
            {
                return db.ComponentTypes.ToList();
            }
        }

        public IEnumerable<LoanInformation> GetLoanInformations()
        {
            using (var db = new EsDbContext())
            {
                return db.LoanInformations.ToList();
            }
        }

        #endregion

        #region Component types

        public IList<ComponentType> GetAllComponentTypes()
        {
            using (var db = new EsDbContext())
            {
                return db.ComponentTypes.Include(c => c.Category).ToList();
            }
        }

        public ComponentType GetComponentType(int? id)
        {
            using (var db = new EsDbContext())
            {
                return db.ComponentTypes.Find(id);
            }
        }

        public void CreateComponentType(ComponentType componentType)
        {
            using (var db = new EsDbContext())
            {
                db.ComponentTypes.Add(componentType);
                db.SaveChanges();
            }
        }

        public void UpdateComponentType(ComponentType componentType)
        {
            using (var db = new EsDbContext())
            {
                db.Entry(componentType).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteComponentType(int id)
        {
            using (var db = new EsDbContext())
            {
                var componentType = db.ComponentTypes.Find(id);
                db.ComponentTypes.Remove(componentType);
                db.SaveChanges();
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            using (var db = new EsDbContext())
            {
                return db.Categories.ToList();
            }
        }

        #endregion

        #region Loan information

        public IList<LoanInformation> GetAllLoanInformation()
        {
            using (var db = new EsDbContext())
            {
                return db.LoanInformations.Include(c => c.Student).ToList();
            }
        }

        public LoanInformation GetLoanInformation(int? id)
        {
            using (var db = new EsDbContext())
            {
                return db.LoanInformations.Find(id);
            }
        }

        public void CreateLoanInformation(LoanInformation loanInformation)
        {
            using (var db = new EsDbContext())
            {
                db.LoanInformations.Add(loanInformation);
                db.SaveChanges();
            }
        }

        public void UpdateLoanInformation(LoanInformation loanInformation)
        {
            using (var db = new EsDbContext())
            {
                db.Entry(loanInformation).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteLoanInformation(int id)
        {
            using (var db = new EsDbContext())
            {
                var loanInformation = db.LoanInformations.Find(id);
                db.LoanInformations.Remove(loanInformation);
                db.SaveChanges();
            }
        }

        public IEnumerable<Student> GetStudents()
        {
            using (var db = new EsDbContext())
            {
                return db.Students.ToList();
            }
        }

        #endregion

        #region Students

        public IList<Student> GetAllStudents()
        {
            using (var db = new EsDbContext())
            {
                return db.Students.ToList();
            }
        }

        public Student GetStudent(int? id)
        {
            using (var db = new EsDbContext())
            {
                return db.Students.Find(id);
            }
        }

        public void CreateStudent(Student student)
        {
            using (var db = new EsDbContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (var db = new EsDbContext())
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            using (var db = new EsDbContext())
            {
                var student = db.Students.Find(id);
                db.Students.Remove(student);
                db.SaveChanges();
            }
        }

        #endregion
    }
}