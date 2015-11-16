using System;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul
{
    public class DbUpdater
    {
        public void Update(EsDbContext context)
        {
            var category1 = new Category
            {
                CategoryName = "Cat Category"
            };
            context.Categories.Add(category1);

            var comType1 = new ComponentType
            {
                ComponentName = "namey namey",
                CategoryId = category1.Id
            };
            context.ComponentTypes.Add(comType1);

            var com1 = new Component
            {
                ComponentNumber = 1337,
                ComponentTypeId = comType1.Id,
                SerieNr = "1337",
                UserComment = "this product sux",
                AdminComment = "admin comment",
            };
            context.Components.Add(com1);

            var student1 = new Student
            {
                Email = "Nope@gmail.com",
                MobilNo = "88888888",
                StudentName = "Per",
                StudentId = "201012345",
            };
            context.Students.Add(student1);

            var loan1 = new LoanInformation
            {
                IsReservation = false,
                LoanDate = DateTime.Now,
                StudentId = student1.Id,
                ReservationDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddMonths(1)
            };
            context.LoanInformations.Add(loan1);

            context.SaveChanges();
        }
    }
}