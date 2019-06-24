using RavSoft.GoogleTranslator;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput.Native;
using WindowsInput;

namespace AutoTranslate
{
    class Program
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static bool active = false;
        private static string toTranslate = "";
        private static Translator t = new Translator();
        private static InputSimulator sim = new InputSimulator();
        private static NotifyIcon trayIcon = new NotifyIcon();
        public static string hotkey = "F5";

        [STAThread]
        public static void Main()
        {
            _hookID = SetHook(_proc);
            
            trayIcon.Text = "AutoTranslate By Caleb Sordelet";
            trayIcon.Icon = Properties.Resources.icon;
            ContextMenu trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("About", about_Click);
            trayMenu.MenuItems.Add("Settings", settings_Click);
            trayMenu.MenuItems.Add("Quit", quit_Click);
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }

        private static void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(1);
        }

        private static void settings_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
        }

        private static void about_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (((Keys)vkCode).ToString() == hotkey && active == false)
                {
                    active = true;
                    trayIcon.Icon = Properties.Resources.listeningIcon;
                    toTranslate = "";
                }
                else if (((Keys)vkCode).ToString() == hotkey && active == true)
                {
                    active = false;
                    trayIcon.Icon = Properties.Resources.icon;
                    if (toTranslate != "")
                    {
                        string translation = t.Translate(toTranslate, "English", "Japanese");
                        for (var i = 0; i < toTranslate.Length; i++)
                        {
                            sim.Keyboard.KeyPress(VirtualKeyCode.BACK);
                        }
                        sim.Keyboard.TextEntry(translation);
                    }
                    toTranslate = "";
                }
                else if (active == true)
                {
                    if (((Keys)vkCode).ToString() == "Back" && toTranslate.Length >= 1)
                    {
                        toTranslate = toTranslate.Substring(0, toTranslate.Length - 1);
                    }
                    else
                    {
                        toTranslate += ((Keys)vkCode).ToString().Replace("Space", " ").Replace("Back", "");
                    }
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
