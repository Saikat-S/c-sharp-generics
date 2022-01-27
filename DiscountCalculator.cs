namespace c_sharp_generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product){
            return product.Price;
        }
    }


}