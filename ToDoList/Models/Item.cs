using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Item
    {
        public Item()
        {
            this.JoinEntities = new HashSet<CategoryItem>();
        }

        public int ItemId { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public string DueDate {get; set; }


        public virtual ICollection<CategoryItem> JoinEntities { get;}


    }
}


//  List<int> DueDate = new List<int>()
// {
//     3/22/2022, 7, 2, 61, 14
// };
// List<int> sortedDueDate = DueDate.OrderBy(DueDate => DueDate).ToList();
// foreach (int number in sortedDueDate)
//     Console.WriteLine(DueDate); 