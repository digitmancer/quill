﻿namespace Quill.Sound;

public sealed class Channel
{
  public byte Volume = 0xF;
  public ushort Tone = 0x0;
  public bool Polarity;

  public Channel()
  {
  }
}
