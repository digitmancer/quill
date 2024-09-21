namespace Sonic.Extensions
{
  public static class DataExtensions
  {
    public static ushort Increment(this ushort word) => (ushort)(word + 1);

    public static byte Increment(this byte value) => (byte)(value + 1);
    
    public static byte HighByte(this ushort word) => (byte)(word >> 8);

    public static byte LowByte(this ushort word) => (byte)word;

    public static string ToHex(this byte value) => value.ToString("X2");

    public static string ToHex(this ushort word) => $"{word.HighByte().ToHex()}-{word.LowByte().ToHex()}"; 

    public static void ExtractBytes(this ushort word, ref byte high, ref byte low)
    {
      high = word.HighByte();
      low = word.LowByte();
    }
  }
}