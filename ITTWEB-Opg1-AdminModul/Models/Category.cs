using System;

namespace ITTWEB_Opg1_AdminModul.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String CategoryName { get; set; }

        public virtual ComponentType ComponentType { get; set; }
    }
}