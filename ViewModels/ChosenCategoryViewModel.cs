using DSU21_2.Models;

namespace DSU21_2.ViewModels
{
    public class ChosenCategoryViewModel    
    {
        public Tag ChosenTag { get; set; }

        public ChosenCategoryViewModel(Tag tag)
        { 
            ChosenTag = tag;
        }

    }
}
