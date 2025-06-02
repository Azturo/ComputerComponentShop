using Blazored.LocalStorage;

namespace ComputerComponentShop.Models.Services
{
    public class ListManager<T> : IListManager<T>
    {
        private readonly List<T> aList;

        /// <summary>
        /// Returns the number of items in the collection aList
        /// </summary>
        public int Count
        {
            get { return aList.Count; }
        }

        public ListManager()
        {
            aList = new List<T>();
         
        }


        /// <summary>
        /// Adds an object to the collection aList
        /// </summary>
        /// <param name="aType"></param>
        /// <returns>True if successful, else false</returns>
        public bool Add(T aItem)
        {
            if (aList != null)
            {

                aList.Add(aItem);

                return true;
            }
            return false;
        }


        /// <summary>
        /// Cleares the objects of the aList collection
        /// </summary>
        public void DeleteAll()
        {
            if (aList != null)
            {
                aList.Clear();
            }
        }


        /// <summary>
        /// Generates a string array for each element in the collection aList with the objects ToString method
        /// </summary>
        /// <returns>The Tostring method of an object per element in the list</returns>
        public string[] ToStringArray()
        {
            if (aList == null || Count == 0)
            {
                return new string[0];
            }

            string[] aStringArray = new string[Count];

            for (int i = 0; i < Count; i++)
            {
                aStringArray[i] = aList[i].ToString();
            }
            return aStringArray;
        }


        /// <summary>
        /// Retrieves the whole list
        /// </summary>
        /// <returns></returns>
        public List<T> ToList()
        {
            return new List<T>(aList);
        }

        /// <summary>
        /// Removes an item from the list.
        /// </summary>
        public void Remove(T aItem)
        {
            aList.Remove(aItem);
        }

        /// <summary>
        /// Sorter that uses IComparer and compares two objects
        /// </summary>
        /// <param name="sComparer"></param>
        public void Sort(IComparer<T> sComparer)
        {
            aList.Sort(sComparer);
        }

    }
}

