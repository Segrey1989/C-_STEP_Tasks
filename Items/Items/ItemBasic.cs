using System;
namespace Items
{
    public abstract class ItemBasic
    {
        string Name {get; set; }
        string description;
        double cost;

        public string Description{
            get { return description; }
            set { description = value; }
        }

        public ItemBasic(string _name, double _cost){
            Name = _name;
            cost = _cost;
        }

        public double getCost() { return cost; }
        public string getName() { return Name; }

        public virtual void showItem(){
            Console.WriteLine("Name: {0}\nDescription: {1}\nPrice: {2}",
                             Name, description, cost);
        }


        //public override bool Equals(object obj){
        //    if (obj == null)
        //        return false;
        //    ItemBasic it = obj as ItemBasic;
        //    if (it as ItemBasic == null)
        //        return false;
        //    return it.name == this.name && (int)it.cost == (int)this.cost;
        //}

        //public override int GetHashCode(){
        //    int nameCode;
        //    if(name == "")
        //}

        //public static bool operator==(ItemBasic it1, ItemBasic it2){
        //    return it1.name == it2.name ? true : false;
                
        //}

        //public static bool operator !=(ItemBasic it1, ItemBasic it2)
        //{
        //    return it1.name == it2.name ? false : true;

        //}

       
    }
}
