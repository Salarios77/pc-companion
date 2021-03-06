﻿namespace Networking
{
    public enum ProgramType
    {
        UNSUPPORTED,
        MICROSOFT_WORD,
        MICROSOFT_EXCEL,
        MICROSOFT_POWERPOINT,
        MICROSOFT_OUTLOOK,
        SPOTIFY,
        PHOTOSHOP,
        ADOBE_ACROBAT,
        SKYPE,
        CONTROL_PANEL,
        FILE_EXPLORER,
        NOTEPAD,
        MICROSOFT_PAINT,
        MICROSOFT_PAINT3D,
        MICROSOFT_PHOTOS,
        CORTANA,
        CHROME,
        FIREFOX,
        MICROSOFT_EDGE
    }

    public enum WindowsCommand
    {
        CLOSE,
        OPEN,
        VOLUME,
        BRIGHTNESS,
        BRIGHTNESS_UP,
        BRIGHTNESS_DOWN,
        VOLUME_UP,
        VOLUME_DOWN,
        MUTE
    }


    public enum CommandTarget
    {
        PROGRAM,
        SYSTEM,
        WINDOWS
    }

    public enum SystemCommand
    {
        SEND_TITLE,
        SEND_ICON,
        SEND_HANDLE,
        SEND_SCREENSHOT,
        SEND_TYPE
    }


}
