namespace _06._SequenceNM
{
    public class Cell
    {
        public Cell(int value, Cell previous = null)
        {
            this.Value = value;
            this.Previous = previous;
        }

        public int Value { get; set; }

        public Cell Previous { get; set; }
    }
}