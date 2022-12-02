namespace Quill.Extensions
{
  public static class ByteExtensions
  {
    public static ushort Concatenate(this byte msb, byte lsb) => (ushort)((msb << 8) + lsb);
    
    public static byte Increment(this byte value) => (byte)(value + 1);

    public static bool GetBit(this byte value, int index) => ((value >> index) & 1) != 0;

    public static bool GetLSB(this byte value) => value.GetBit(0);

    public static bool GetMSB(this byte value) => value.GetBit(7);

    public static byte GetLowNibble(this byte value) => (byte)(value & 0b0000_1111);

    public static byte GetHighNibble(this byte value) => (byte)(value >> 4);
    
    public static string ToHex(this byte value) => value.ToString("X2");
  }
}