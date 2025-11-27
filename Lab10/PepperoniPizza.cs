namespace Lab10
{
    public class PepperoniPizza : Pizza
    {
        public override string[] Ingredients()
        {
            return new string[]
            {
                "Pepperoni",
                "Cheese",
                "Tomato sauce",
                "Dough",
                "Spices"
            };
        }
    }
}