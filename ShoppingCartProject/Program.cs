namespace ShoppingCartProject
{
    public class ShoppingCartRunner
    {

        static void Main(string[] args)
        {
            Item i1 = new Item(5);
            Item i2=new Item(5);

            Item i3=Item.CreateInstance(10);
            Item i4 = Item.CreateInstance(700);

            i1.id = 101;
            //i1.description = "Laptop";
            i1.Description= "Laptop";
            //i1.Quantity = 8;
            i1.price = 1000;

            i2.id = 102;
            i2.Description = "Watch";
            //i2.Quantity = -3;
            i2.price = 5000;

            Console.WriteLine(i1.Description);

            //Console.WriteLine(i1.GetHashCode());
            //Console.WriteLine(i2.GetHashCode());

            i1.DisplayItemDetail();
            i1.PrintDiscountedPrice();

            i2.DisplayItemDetail();
            i2.PrintDiscountedPrice();


            i3.DisplayItemDetail();
            i3.PrintDiscountedPrice();

            i4.DisplayItemDetail();
            i4.PrintDiscountedPrice();


            Item.PrintDescription(i2);

            Item.PrintDescription(i1);


            Item.PrintDescription(i3);

            Item.PrintDescription(i4); //pass by reference


            Item i5=Item.CreateInstance(800);
            i5.DisplayItemDetail();

            Item.CreateInstance(900).DisplayItemDetail();
        }
    }
}