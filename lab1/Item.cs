namespace Knapsack
{
    internal class Item
    {
        public int Id { get; set; }//identyfikator przedmiotu
        public int Value { get; set; }//wartość przedmiotu
        public int Weight { get; set; }//waga przedmiotu
        public double Ratio => (double)Value / Weight;//stosunek wartosci do wagi
    }
}