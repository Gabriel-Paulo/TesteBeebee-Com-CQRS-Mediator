namespace Web
{
    public class NotFoundException : Exception
    {
        private int id;

        public NotFoundException(string message) : base(message)
        {
        }

        public NotFoundException(string message, int id) : this(message)
        {
            this.id = id;
        }
    }
}
