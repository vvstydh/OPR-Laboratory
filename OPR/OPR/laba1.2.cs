public class BitString
{
    public ulong Low { get; set; }
    public ulong High { get; set; }

    public Tuple<ulong, ulong> And(BitString b)
    {
        return Tuple.Create(Low & b.Low, High & b.High);
    }
    public Tuple<ulong, ulong> Or(BitString b)
    {
        return Tuple.Create(Low | b.Low, High | b.High);
    }
    public Tuple<ulong, ulong> Xor(BitString b)
    {
        return Tuple.Create(Low ^ b.Low, High ^ b.High);
    }
    public Tuple<string, string> Not()
    {
        return Tuple.Create(Convert.ToString(~(long)Low, toBase: 2), Convert.ToString(~(long)High, toBase: 2));
    }
    public Tuple<string, string> shiftleft(int l)
    {
        return Tuple.Create(Convert.ToString((long)Low << l, toBase: 2), Convert.ToString((long)High << l, toBase: 2));
    }
    public Tuple<string, string> shiftright(int l)
    {
        return Tuple.Create(Convert.ToString((long)Low >> l, toBase: 2), Convert.ToString((long)High >> l, toBase: 2));
    }
}