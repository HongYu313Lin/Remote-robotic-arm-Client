using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPIPClient
{
    public class joystation
    {
        static int JOYSTICKID1 = 0;
        static int JOYSTICKID2 = 1;
        static int JOY_POVCENTERED = -1;
        static int JOY_POVFORWARD = 0;
        static int JOY_POVRIGHT = 9000;
        static int JOY_POVLEFT = 27000;
        static int JOY_RETURNX = 0x0001;
        static int JOY_RETURNY = 0x0002;
        static int JOY_RETURNZ = 0x0004;
        static int JOY_RETURNR = 0x0008;
        static int JOY_RETURNU = 0x0010;
        static int JOY_RETURNV = 0x0020;
        static int JOY_RETURNPOV = 0x0040;
        static int JOY_RETURNBUTTONS = 0x0080;
        static int JOY_RETURNRAWDATA = 0x0100;
        static int JOY_RETURNPOVCTS = 0x0200;
        static int JOY_RETURNCENTERED = 0x0400;
        static int JOY_USEDEADZONE = 0x0800;
        static int JOY_RETURNALL = (JOY_RETURNX + JOY_RETURNY + JOY_RETURNZ + JOY_RETURNR + JOY_RETURNU + JOY_RETURNV + JOY_RETURNPOV + JOY_RETURNBUTTONS);
        bool app_running = true;
        public string str = "";

        public bool 三角形 = false;
        public bool 正方形 = false;
        public bool 叉 = false;
        public bool 圈 = false;
        public bool 上 = false;
        public bool 下 = false;
        public bool 左 = false;
        public bool 右 = false;
        public bool SHARE = false;
        public bool OPTIONS = false;
        public bool PS = false;
        public bool SPACE = false;
        public bool R1 = false;
        public bool R2 = false;
        public bool L1 = false;
        public bool L2 = false;
        public bool L3 = false;
        public bool R3 = false;

        public double JoyStick_LX = 0;
        public double JoyStick_LY = 0;

        public double JoyStick_RX = 0;
        public double JoyStick_RY = 0;
        public joystation()
        {
            InitJoy();
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct JOYCAPS
        {
            public ushort wMid;
            public ushort wPid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szPname;
            public int wXmin;
            public int wXmax;
            public int wYmin;
            public int wYmax;
            public int wZmin;
            public int wZmax;
            public int wNumButtons;
            public int wPeriodMin;
            public int wPeriodMax;
            public int wRmin;
            public int wRmax;
            public int wUmin;
            public int wUmax;
            public int wVmin;
            public int wVmax;
            public int wCaps;
            public int wMaxAxes;
            public int wNumAxes;
            public int wMaxButtons;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szRegKey;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szOEMVxD;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct JOYINFOEX
        {
            public Int32 dwSize; // Size, in bytes, of this structure.
            public Int32 dwFlags; // Flags indicating the valid information returned in this structure.
            public Int32 dwXpos; // Current X-coordinate.
            public Int32 dwYpos; // Current Y-coordinate.
            public Int32 dwZpos; // Current Z-coordinate.
            public Int32 dwRpos; // Current position of the rudder or fourth joystick axis.
            public Int32 dwUpos; // Current fifth axis position.
            public Int32 dwVpos; // Current sixth axis position.
            public Int32 dwButtons; // Current state of the 32 joystick buttons (bits)
            public Int32 dwButtonNumber; // Current button number that is pressed.
            public Int32 dwPOV; // Current position of the point-of-view control (0..35,900, deg*100)
            public Int32 dwReserved1; // Reserved; do not use.
            public Int32 dwReserved2; // Reserved; do not use.
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct JOYINFO
        {
            public Int32 wXpos; // Current X-coordinate.
            public Int32 wYpos; // Current Y-coordinate.
            public Int32 wZpos; // Current Z-coordinate.
            public Int32 wButtons; // Current state of joystick buttons.
        }
        [DllImport("winmm.dll")]
        public static extern Int32 joyGetPos(Int32 uJoyID, ref JOYINFO pji);//這一筆資料
        [DllImport("winmm.dll")]
        public static extern Int32 joyGetPosEx(Int32 uJoyID, ref JOYINFOEX pji);//上一筆資料
        [DllImport("winmm.dll")]
        public static extern int joyGetDevCaps(int uJoyID, ref JOYCAPS pjc, int cbjc);

        [DllImport("winmm.dll")]
        public static extern uint joyGetNumDevs();
        // MMRESULT mmresult;
        public struct DeviceJoyInfo
        {
            public bool JoyEx;
            public int ButtonCount;
            public int ID;
            public int Button_old;
            public int Way_X_old;
            public int Way_Y_old;
            public int Way_X2_old;
            public int Way_Y2_old;
        }

        public struct joystickEvent
        {
            public int event_type; //0:方向鍵觸發 1:一般按鈕觸發
            public int joystick_id;//發生於哪個遊戲手把

            public int button_id;//如果是一般按鈕觸發,發生在哪顆按鈕
            public int button_event;//0:鬆開 1:壓下

            public int way_type; //0:x方向鍵盤 1:y方向鍵盤
            public int way_value;

        }

        List<DeviceJoyInfo> joyinfo_list = new List<DeviceJoyInfo>();
        JOYCAPS joycap = new JOYCAPS();
        JOYINFO js = new JOYINFO();
        JOYINFOEX jsx = new JOYINFOEX();
        int JOYCAPS_size;
        int PeriodMin = 0;
        void InitJoy()
        {
            Stopwatch st = new Stopwatch();
            st.Restart();
            JOYCAPS_size = Marshal.SizeOf(typeof(JOYCAPS));

            uint num = joyGetNumDevs();

            for (int i = 0; i < 256; i++)
            {
                if (joyGetDevCaps(i, ref joycap, JOYCAPS_size) == 0)
                {
                    DeviceJoyInfo info = new DeviceJoyInfo();

                    //set id
                    info.ID = i;
                    int errcode = 0;
                    //check joyex
                    jsx.dwSize = Marshal.SizeOf(jsx);
                    jsx.dwFlags = JOY_RETURNALL;
                    if ((errcode = joyGetPosEx(i, ref jsx)) == 0)
                    {
                        info.JoyEx = true;
                        info.Way_X_old = jsx.dwXpos;
                        info.Way_Y_old = jsx.dwYpos;
                        info.Way_X2_old = jsx.dwZpos;
                        info.Way_Y2_old = jsx.dwRpos;
                    }
                    else if (joyGetPos(i, ref js) == 0)
                    {
                        info.JoyEx = false;
                        info.Way_X_old = js.wXpos;
                        info.Way_Y_old = js.wYpos;
                    }
                    //
                    //
                    else continue; //裝置功能失效

                    //set button count
                    info.ButtonCount = joycap.wNumButtons;

                    info.Button_old = 0;

                    if (joycap.wPeriodMin > PeriodMin)
                        PeriodMin = joycap.wPeriodMin;

                    joyinfo_list.Add(info);
                }
            }
            //取出所有目前連線遊戲手把中最慢的PeriodMin然後+5ms
            PeriodMin += 5;
            new Thread(polling_listener).Start();
            st.Stop();
            Console.WriteLine("init joypad infor : " + st.ElapsedMilliseconds + " ms");
        }
        void joy_event_captur()
        {
            for (int i_button = 0; i_button < joyinfo_list.Count(); i_button++)
            {
                DeviceJoyInfo button_inf = joyinfo_list[i_button];
                int button_id = button_inf.ID;
                int button_count = button_inf.ButtonCount;

                int button_now, X_now, Y_now, X2_now, Y2_now;
                if (button_inf.JoyEx == false)
                {
                    joyGetPos(button_id, ref js);
                    button_now = js.wButtons;
                    X_now = js.wXpos;
                    Y_now = js.wYpos;
                    X2_now = 0;
                    Y2_now = 0;
                }
                else
                {
                    joyGetPosEx(button_id, ref jsx);

                    上 = (jsx.dwPOV) == 0 ? true : false;
                    下 = (jsx.dwPOV) == 18000 ? true : false;
                    左 = (jsx.dwPOV) == 27000 ? true : false;
                    右 = (jsx.dwPOV) == 9000 ? true : false;


                    三角形 = ((jsx.dwButtons & 8) == 8) ? true : false;
                    正方形 = ((jsx.dwButtons & 1 )== 1) ? true : false;
                    叉 = ((jsx.dwButtons & 2) == 2) ? true : false;
                    圈 = ((jsx.dwButtons & 4) == 4) ? true : false;

                    SHARE = ((jsx.dwButtons & 256) == 256) ? true : false;
                    OPTIONS = ((jsx.dwButtons & 512) == 512) ? true : false;
                    PS = ((jsx.dwButtons & 4096) == 4096) ? true : false;
                    SPACE = ((jsx.dwButtons & 8192) == 8192) ? true : false;
                    R1 = ((jsx.dwButtons & 32) == 32) ? true : false;
                    R2 = ((jsx.dwButtons & 128) == 128) ? true : false;
                    L1 = ((jsx.dwButtons & 16) == 16) ? true : false;
                    L2 = ((jsx.dwButtons & 64) == 64) ? true : false;
                    L3 = ((jsx.dwButtons & 1024) == 1024) ? true : false;
                    R3 = ((jsx.dwButtons & 2048) == 2048) ? true : false;

                    JoyStick_LX = (double)(jsx.dwXpos - 32768) / 32768d;
                    JoyStick_LY = -(double)(jsx.dwYpos - 32768) / 32768d;

                    JoyStick_RX = (double)(jsx.dwZpos - 32768) / 32768d;
                    JoyStick_RY = -(double)(jsx.dwRpos - 32768) / 32768d;





                    StringBuilder sb = new StringBuilder("");
                    sb.Append("dwButtonNumber  "); sb.Append(jsx.dwButtonNumber); sb.Append("\r\n");
                    sb.Append("dwButtons  "); sb.Append(jsx.dwButtons); sb.Append("\r\n");
                    sb.Append("dwFlags  "); sb.Append(jsx.dwFlags); sb.Append("\r\n");
                    sb.Append("dwPOV  "); sb.Append(jsx.dwPOV); sb.Append("\r\n");
                    sb.Append("dwReserved1  "); sb.Append(jsx.dwReserved1); sb.Append("\r\n");
                    sb.Append("dwReserved2  "); sb.Append(jsx.dwReserved2); sb.Append("\r\n");
                    sb.Append("dwRpos  "); sb.Append(jsx.dwRpos); sb.Append("\r\n");
                    sb.Append("dwSize  "); sb.Append(jsx.dwSize); sb.Append("\r\n");
                    sb.Append("dwUpos  "); sb.Append(jsx.dwUpos); sb.Append("\r\n");
                    sb.Append("dwVpos  "); sb.Append(jsx.dwVpos); sb.Append("\r\n");
                    sb.Append("dwXpos  "); sb.Append(jsx.dwXpos); sb.Append("\r\n");
                    sb.Append("dwYpos  "); sb.Append(jsx.dwYpos); sb.Append("\r\n");
                    sb.Append("dwZpos  "); sb.Append(jsx.dwZpos); sb.Append("\r\n");
                    sb.Append("JoyStick_LX  "); sb.Append(JoyStick_LX.ToString("0.00")); sb.Append("\r\n");
                    sb.Append("JoyStick_LY  "); sb.Append(JoyStick_LY.ToString("0.00")); sb.Append("\r\n");
                    sb.Append("JoyStick_RX  "); sb.Append(JoyStick_RX.ToString("0.00")); sb.Append("\r\n");
                    sb.Append("JoyStick_RY  "); sb.Append(JoyStick_RY.ToString("0.00")); sb.Append("\r\n");
                    str = sb.ToString();
                }
            }
        }

        
        void polling_listener()
        {
            while (app_running)
            {
                Thread.Sleep(PeriodMin);
                joy_event_captur();
            }
        }
    }
}
