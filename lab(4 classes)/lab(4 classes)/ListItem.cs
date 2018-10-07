using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_classes_
{

    class ListItem
    {
        static public int size = 100;
        Item[] list;
        int listSize;
        public ListItem()
        {
            list = new Item[size];
            listSize = 0;
        }

        public Item this[Item it]
        {
            get
            {
                for (int i = 0; i < listSize; i++)
                    if (list[i].getName() == it.getName())
                        return list[i];
                return null;
            }
                
        }

        public void putList(params Item[] it)
        {
            int count = it.Length;
            for (int i = 0; i < count; i++)
                list[listSize++] = it[i];
        }

    }
}
