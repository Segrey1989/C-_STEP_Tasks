using System;

namespace Items
{
    class Program
    {
        static void Main(string[] args)
        {
            Bucket bucket = new Bucket();
            FoodItem cheese = new FoodItem("Cheese", 8.90, "10.10.2018");
            //cheese.Weight = 0.76;
            ItemBasic bread = new FoodItem("Bread", 8.90, "10.10.2018");
            ItemBasic milk = new FoodItem("Milk", 1.50, "10.10.2018");
            milk.Description = "Самое свежее молоко от самых замечательных коров!";
            ItemBasic powder= new Chemicals("Loundry powder", 7.50, "10.10.2020");
            ItemBasic phone = new Tech("iPhone 10X", 390.52);
            ItemBasic book = new Books("Собакi Эуропы", 90, "А.Бахарэвiч");
            bucket.putItem(cheese);
            bucket.putItem(bread);
            bucket.putItem(phone);
            bucket.putItem(milk);
            bucket.putItem(powder);
            bucket.putItem(book);
            bucket.removeItem(bread);

            milk.showItem();
            phone.showItem();

            bucket.show();

           


            Console.WriteLine("Общая сумма покупок: {0:0.00}\n" +
                              "Количество товаров в корзине: {1}"
                              ,bucket.getSumma(), bucket.getItemsNum());
        }
    }
}
