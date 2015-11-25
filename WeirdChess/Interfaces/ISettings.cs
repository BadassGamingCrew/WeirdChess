using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeirdChess.Enums;

namespace WeirdChess.Interfaces
{
    public interface ISettings : ISavable
    {
        ISetting<int[]> ScreenResolution { get; }
        ISetting<MusicOptions> Music { get; }
        ISetting<SoundOptions> Sound { get; }
        ISetting<int> MusicVolume { get; }
        ISetting<int> SoundVolume { get; } 
    }
}
