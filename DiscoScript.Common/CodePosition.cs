namespace DiscoScript.Common
{
    public readonly struct CodePosition
    {
        public int Line { get; }
        public int Column { get; }

        public CodePosition(int line, int column)
        {
            Line = line;
            Column = column;
        }
    }
}