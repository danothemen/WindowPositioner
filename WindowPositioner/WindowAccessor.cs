﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using WindowPositioner.Models;

namespace WindowPositioner
{
    public static class WindowAccessor
    {

        // C:\Windows\system32\notepad.exe
        // C:\Windows\system32\cmd.exe

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

        [Flags()]
        private enum SetWindowPosFlags : uint
        {
            SynchronousWindowPosition = 0x4000,
            DeferErase = 0x2000,
            DrawFrame = 0x0020,
            FrameChanged = 0x0020,
            HideWindow = 0x0080,
            DoNotActivate = 0x0010,
            DoNotCopyBits = 0x0100,
            IgnoreMove = 0x0002,
            DoNotChangeOwnerZOrder = 0x0200,
            DoNotRedraw = 0x0008,
            DoNotReposition = 0x0200,
            DoNotSendChangingEvent = 0x0400,
            IgnoreResize = 0x0001,
            IgnoreZOrder = 0x0004,
            ShowWindow = 0x0040,
        }

        public static void OpenProgram(Window window)
        {
            Process p = Process.Start(window.ExecutablePath, null);

            while (p.MainWindowHandle == IntPtr.Zero)
            {
                Thread.Sleep(20);
            }

            SetWindowPos(p.MainWindowHandle, IntPtr.Zero, window.WindowBounds.X, window.WindowBounds.Y, window.WindowBounds.Width, window.WindowBounds.Height, 0);            
        }
        

        public static void OpenPrograms(List<Window> windows)
        {
            foreach (Window window in windows)
            {
                Thread thread = new Thread(() => OpenProgram(window));
                thread.Start();
            }
        }
    }
}
