using System;
using ITTWEB_Opg1_AdminModul.Models;

namespace ITTWEB_Opg1_AdminModul.DAL
{
    public class DbUpdater
    {
        public void Update(EsDbContext context)
        {
            var category1 = new Category
            {
                CategoryName = "Cameras"
            };
            context.Categories.Add(category1);

            var comType1 = new ComponentType
            {
                ComponentName = "Camera",
                CategoryId = category1.Id
            };
            context.ComponentTypes.Add(comType1);

            var com1 = new Component
            {
                ComponentNumber = 14,
                ComponentTypeId = comType1.Id,
                SerieNr = "983234-EB",
                UserComment = "Great camera!",
                AdminComment = "Need to buy more of these",
            };
            context.Components.Add(com1);

            var student1 = new Student
            {
                Email = "peter@leasy.com",
                MobilNo = "88888888",
                StudentName = "Leasy",
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