namespace ExerciseV.Refactored.Models
{
    public abstract class Pizza
    {
        private string _sauce;
        private readonly string _flavor;
        private readonly bool _isSweetPizza;

        public Pizza(string flavor, bool isSweetPizza)
        {
            _flavor = flavor;
            _isSweetPizza = isSweetPizza;
        }

        public string Sauce ()
        {
            _sauce = _isSweetPizza ? "molho doce" : "molho de tomate";
            return _sauce;
        }              
        public string Flavor
        {
            get { return _flavor; }
        }       
    }
}
