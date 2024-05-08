namespace AS2324_5G_INF_HavrylovDanyil_WebAPI.Models
{
    public class Numbers
    {
        public int Value { get; set; }

        public bool Odd => (Value % 2 == 0);
        public bool Positive => (Value >= 0);

    }
}
