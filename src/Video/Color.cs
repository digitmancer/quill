﻿namespace Quill.Video;

public static class Color
{
  #region Constants
  private readonly static int[] LEGACY_PALETTE = new int[]
  {
    0x000000,
    0x42C821,
    0x78DC5E,
    0xED5554,
    0xFC767D,
    0x4D52D4,
    0xF5EB42,
    0x5455FC,
    0x7879FF,
    0x54C1D4,
    0x54CEE6,
    0x3BB021,
    0xBA5BC9,
    0xCCCCCC,
    0xFFFFFF
  };

  private const byte MULTIPLIER = byte.MaxValue / 3;
  #endregion

  #region Methods
  public static int ToRGBA(byte color)
  {
    var r = (color & 0b_11) * MULTIPLIER;
    color >>= 2;
    var g = (color & 0b_11) * MULTIPLIER;
    color >>= 2;
    var b = (color & 0b_11) * MULTIPLIER;
    return (r << 0) | (g << 8) | (b << 16);
  }
  
  public static int ToLegacyRGBA(byte color) => LEGACY_PALETTE[color];
  #endregion
}
