using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ItemListViewModel
    {
        public ItemListViewModel()
        {
            List<string> listItems = new List<string>
            {
                "item1",
                "item2",
                "item3",
                "item4",
                "item5",
                "item6",
                "item7",
                "item8",
                "item9",
                "item10",
                "item11",
                "item12",
                "item13",
                "item14",
                "item15",
                "item16",

            };
        }

        public List<string> listItems { get; set; }
    }
}
