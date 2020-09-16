using System;
using System.Runtime.InteropServices;

namespace RPiDiag
{
    class Neon
    {
        public unsafe static void Enable(IntPtr hwnd)
        {
            Policy policy = new Policy(Accent.ENABLE_BLURBEHIND, 0, 0, 0); ;
            Context context = new Context(Attribute.ACCENT_POLICY, &policy, sizeof(Policy));
            SetWindowCompositionAttribute(hwnd, ref context);
        }
        public unsafe static void Disable(IntPtr hwnd)
        {
            Policy policy = new Policy(Accent.DISABLED, 0, 0, 0); ;
            Context context = new Context(Attribute.ACCENT_POLICY, &policy, sizeof(Policy));
            SetWindowCompositionAttribute(hwnd, ref context);
        }

        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref Context context);

        [StructLayout(LayoutKind.Sequential)]
        internal unsafe struct Context
        {
            public Attribute attributes;
            public void* policyData;
            public int policySize;

            public Context(Attribute Attributes, void* PolicyData, int PolicySize)
            {
                attributes = Attributes;
                policyData = PolicyData;
                policySize = PolicySize;
            }
        }

        internal enum Attribute
        {
            UNUSED = 0,
            NCRENDERING_ENABLED = 1,
            NCRENDERING_POLICY = 2,
            TRANSITIONS_FORCEDISABLED = 3,
            ALLOW_NCPAINT = 4,
            CAPTION_BUTTON_BOUNDS = 5,
            NONCLIENT_RTL_LAYOUT = 6,
            FORCE_ICONIC_REPRESENTATION = 7,
            EXTENDED_FRAME_BOUNDS = 8,
            HAS_ICONIC_BITMAP = 9,
            THEME_ATTRIBUTES = 10,
            NCRENDERING_EXILED = 11,
            NCADORNMENTINFO = 12,
            EXCLUDED_FROM_LIVEPREVIEW = 13,
            VIDEO_OVERLAY_ACTIVE = 14,
            FORCE_ACTIVEWINDOW_APPEARANCE = 15,
            DISALLOW_PEEK = 16,
            CLOAK = 17,
            CLOAKED = 18,
            ACCENT_POLICY = 19,
            FREEZE_REPRESENTATION = 20,
            EVER_UNCLOAKED = 21,
            VISUAL_OWNER = 22,
            HOLOGRAPHIC = 23,
            EXCLUDED_FROM_DDA = 24,
            PASSIVEUPDATEMODE = 25,
            USEDARKMODECOLORS = 26,
            LAST = 27
        }
        internal enum Accent
        {
            DISABLED = 0,
            ENABLE_GRADIENT = 1,
            ENABLE_TRANSPARENTGRADIENT = 2,
            ENABLE_BLURBEHIND = 3,
            ACRYLICBLURBEHIND = 4, // RS4 1803
            HOSTBACKDROP = 5, // RS5 1809
            INVALID = 6
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct Policy
        {
            public Accent accentState;
            public int accentFlags;
            public int gradientColor;
            public int animationId;
            
            public Policy(Accent AccentState, int AccentFlags, int GradientColor, int AnimationId)
            {
                accentState = AccentState;
                accentFlags = AccentFlags;
                gradientColor = GradientColor;
                animationId = AnimationId;
            }
        }
    }
}
