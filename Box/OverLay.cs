using System;
using System.Windows.Forms;
using SharpDX.Direct2D1;
using Factory = SharpDX.Direct2D1.Factory;
using FontFactory = SharpDX.DirectWrite.Factory;
using Format = SharpDX.DXGI.Format;
using SharpDX;
using SharpDX.DirectWrite;
using System.Threading;
using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;
using Rust_Interceptor.Data;
using UnityEngine;
using Box.Properties;
using System.Linq;
using Rust_Interceptor;

namespace Box {
    public partial class Overlay: Form {
        private WindowRenderTarget device;
        private HwndRenderTargetProperties renderProperties;
        private Factory factory;

        //text fonts
        private TextFormat font, fontSmall;
        private FontFactory fontFactory;
        private const string fontFamily = "Arial";//you can edit this of course
        private const float fontSize = 10.0f;
        private const float fontSizeSmall = 10.0f;

        private Thread sDX = null;
        //DllImports
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint flags);

        [DllImport("dwmapi.dll")]
        private static extern void DwmExtendFrameIntoClientArea(IntPtr hWnd, ref int[] pMargins);
        //Styles
        public const UInt32 SWP_NOSIZE = 0x0001;
        public const UInt32 SWP_NOMOVE = 0x0002;
        //public const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        public const UInt32 TOPMOST_FLAGS = 0x0000;
        private static IntPtr HWND_TOPMOST = new IntPtr(-1);

        private RawColor4 transparent = new RawColor4(0, 0, 0, 0);
        private RawColor4 white = new RawColor4(1, 1, 1, 1);
        private RawColor4 green = new RawColor4(0, 1, 0, 1);
        private RawColor4 gray = new RawColor4(0, 0, 0, 0.6f);

        private SolidColorBrush whiteBrush;
        private SolidColorBrush grayBrush;
        private SolidColorBrush greenBrush;

        private const int screenWidth = 1920;
        private const int screenHeight = 1080;
        private const float P = (float) Math.PI / 180;
        float focalLength = 540f / (float)Math.Tan(85f * P / 2f);
        public Overlay() {
            //Configuration.EnableObjectTracking = true;
            int initialStyle = GetWindowLong(Handle, -20);
            SetWindowLong(Handle, -20, initialStyle | 0x80000 | 0x20);
            SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            OnResize(null);

            InitializeComponent();
        }

        private void LoadForm(object sender, EventArgs e) {

            DoubleBuffered = true;
            Width = screenWidth;
            Height = screenHeight;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |// this reduce the flicker
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer |
                ControlStyles.UserPaint |
                ControlStyles.Opaque |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
            TopMost = true;
            Visible = true;

            factory = new Factory();
            fontFactory = new FontFactory();
            renderProperties = new HwndRenderTargetProperties() {
                Hwnd = Handle,
                PixelSize = new Size2(screenWidth, screenHeight),
                PresentOptions = PresentOptions.None
            };

            //SetLayeredWindowAttributes(this.Handle, 0, 255, Managed.LWA_ALPHA);// caution directx error

            //Init DirectX
            device = new WindowRenderTarget(factory, new RenderTargetProperties(new PixelFormat(Format.B8G8R8A8_UNorm, AlphaMode.Premultiplied)), renderProperties);

            whiteBrush = new SolidColorBrush(device, white);
            grayBrush = new SolidColorBrush(device, gray);
            greenBrush = new SolidColorBrush(device, green);

            // Init font's
            font = new TextFormat(fontFactory, fontFamily, fontSize);
            fontSmall = new TextFormat(fontFactory, fontFamily, fontSizeSmall);
            //line = new device.DrawLine;

            sDX = new Thread(new ParameterizedThreadStart(SDXThread)) {
                Priority = System.Threading.ThreadPriority.Highest,
                IsBackground = true
            };
            sDX.Start();
        }
        protected override void OnPaint(PaintEventArgs e) {
            int[] marg = new int[] { 0, 0, Width, Height };
            DwmExtendFrameIntoClientArea(Handle, ref marg);
        }

        private void SDXThread(object sender) {
            RawVector2 Radarcenter = new RawVector2(300, 300);
            RawVector2 ScreenCenter = new RawVector2(960, 540);
            RawVector2 BotScreenCenter = new RawVector2(960, 1080);
            Ellipse XEllipse = new Ellipse(Radarcenter, 250, 250);
            Ellipse PEllipse = new Ellipse(Radarcenter, 3, 3);
            int ty = 5;
            device.TextAntialiasMode = SharpDX.Direct2D1.TextAntialiasMode.Aliased; // you can set another text

            Vector3 localP = new Vector3();
            
            while (true) {

                device.BeginDraw();
                device.Clear(transparent);

                try {

                    if (Settings.Default.Crosshair_Check == true) {
                        var brush = GetColor(Settings.Default.Crosshair_Color);
                        var thick = Settings.Default.Crosshair_Thick;
                        var size = Settings.Default.Crosshair_Size;
                        switch (Settings.Default.Crosshair_Type) {
                            case 4:
                            RawVector2 line1 = new RawVector2(960, 540 - Settings.Default.Crosshair_Size);
                            RawVector2 line2 = new RawVector2(960, 540 + Settings.Default.Crosshair_Size);
                            RawVector2 line3 = new RawVector2(960 - Settings.Default.Crosshair_Size, 540);
                            RawVector2 line4 = new RawVector2(960 + Settings.Default.Crosshair_Size, 540);
                            device.DrawLine(line1, line2, brush, thick);
                            device.DrawLine(line3, line4, brush, thick);
                            break;
                            case 0:
                            device.DrawEllipse(new Ellipse(ScreenCenter, size, size), brush, thick);
                            break;
                            case 1:
                            device.FillEllipse(new Ellipse(ScreenCenter, size, size), brush);
                            break;
                            case 2:
                            device.DrawRectangle(new RawRectangleF(ScreenCenter.X - size, ScreenCenter.Y - size, ScreenCenter.X + size, ScreenCenter.Y + size), brush, thick);
                            break;
                            case 3:
                            device.FillRectangle(new RawRectangleF(ScreenCenter.X - size, ScreenCenter.Y - size, ScreenCenter.X + size, ScreenCenter.Y + size), brush);
                            break;
                        }
                        brush.Dispose();
                    }

                    var Players = Entity.GetPlayers();

                    if (Players.Count > 0) {

                        Vector3 localR = Players[0].Rotation;

                        if (Settings.Default.Radar_Check) {
                            device.FillEllipse(XEllipse, grayBrush);
                            device.DrawLine(Radarcenter, GetPointOnCircle(localR.y - 90), greenBrush, 2);
                            device.DrawEllipse(XEllipse, whiteBrush, 2);
                            device.FillEllipse(PEllipse, whiteBrush);
                        }

                        localP = Players[0].Position;
                        var d1 = Settings.Default.FOV;
                        var d2 = Settings.Default.Temp;

                        if (Settings.Default.Player_Check) {
                            foreach (var e in Players.Skip(1)) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }

                                RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));

                                var health = Math.Floor(e.CombatHealth);

                                if (Settings.Default.Radar_Check && InsideCircle(Center)) {

                                    if (e.IsPlayerSleeping) {
                                        if (Settings.Default.Player_Sleeping_Radar_Check == true) {
                                            using (SolidColorBrush brush = GetColor(Settings.Default.Player_Sleeping_Radar_Color)) {
                                                device.FillEllipse(new Ellipse(Center, 2, 2), brush);
                                                using (TextLayout tl = new TextLayout(fontFactory, "[" + health + "]" + "[" + Math.Floor(distance) + "m]" + e.PlayerName, font, 1000, 1000)) {
                                                    device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), tl, brush);
                                                }
                                            }
                                        }
                                    } else if (Settings.Default.Player_Awake_Radar_Check == true) {
                                        var brush = GetColor(Settings.Default.Player_Awake_Radar_Color);
                                        if (Settings.Default.Player_Crouching_Radar_Check && e.IsPlayerCrouching) {
                                            brush = GetColor(Settings.Default.Player_Crouching_Radar_Color);
                                        }
                                        if (Settings.Default.Player_Aiming_Radar_Check && e.IsPlayerAiming) {
                                            brush = GetColor(Settings.Default.Player_Aiming_Radar_Color);
                                        }
                                        if (Settings.Default.Player_Sprinting_Radar_Check && e.IsPlayerSprinting) {
                                            brush = GetColor(Settings.Default.Player_Sprinting_Radar_Color);
                                        }
                                        device.FillEllipse(new Ellipse(Center, 3, 3), brush);
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + health + "]" + "[" + Math.Floor(distance) + "m]" + e.PlayerName, font, 1000, 1000), whiteBrush);
                                        if (Settings.Default.Player_Held_Item_Enable && e.HasHeldItem) {
                                            device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y + ty), new TextLayout(fontFactory, e.HeldItem, font, 1000, 1000), whiteBrush);
                                        }
                                        var t = ty + 10;
                                        if (Settings.Default.Player_Inventory_Belt) {
                                            foreach(var i in e.InvBelt) {
                                                device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y + t), new TextLayout(fontFactory, StringPool.GetItem(i.itemid), font, 1000, 1000), whiteBrush);
                                                t += 10;
                                            }
                                        }
                                        if (Settings.Default.Player_Inventory_Wear) {
                                            foreach (var i in e.InvWear) {
                                                device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y + t), new TextLayout(fontFactory, StringPool.GetItem(i.itemid), font, 1000, 1000), whiteBrush);
                                                t += 10;
                                            }
                                        }
                                    }
                                        
                                }
                                var pos = e.Position;
                                if (e.IsPlayerSleeping) {
                                    pos.y -= 1.3f;
                                } else {
                                    pos.y -= 0.75f;
                                }
                                RawVector2 point;
                                if (WorldToScreen(localP, localR, pos, out point)) {
                                    if (Settings.Default.Tracer_Check) {
                                        var brush = GetColor(Settings.Default.Player_Sleeping_Tracer_Color);
                                        if (Settings.Default.Player_Sleeping_Tracer_Check && e.IsPlayerSleeping) {
                                            device.DrawLine(BotScreenCenter, point, brush, 2);
                                        } else if (Settings.Default.Player_Awake_Tracer_Check && !e.IsPlayerSleeping) {
                                            brush = GetColor(Settings.Default.Player_Awake_Tracer_Color);
                                            if (Settings.Default.Player_Crouching_Tracer_Check && e.IsPlayerCrouching) {
                                                brush = GetColor(Settings.Default.Player_Crouching_Tracer_Color);
                                            }
                                            if (Settings.Default.Player_Sprinting_Tracer_Check && e.IsPlayerSprinting) {
                                                brush = GetColor(Settings.Default.Player_Sprinting_Tracer_Color);
                                            }
                                            if (Settings.Default.Player_Aiming_Tracer_Check && e.IsPlayerAiming) {
                                                brush = GetColor(Settings.Default.Player_Aiming_Tracer_Color);
                                            }
                                            device.DrawLine(BotScreenCenter, point, brush, 2);
                                        }
                                        brush.Dispose();
                                    }
                                    if (Settings.Default.Box_Check) {
                                        SolidColorBrush brush = GetColor(Settings.Default.Player_Sleeping_Box_Color);
                                        var t = point.Y - 500 / distance;
                                        var tx = point.X + 200 / distance + 5;
                                        if (Settings.Default.Player_Sleeping_Box_Check && e.IsPlayerSleeping) {
                                            device.DrawRectangle(new RawRectangleF((int)(point.X - 100/distance), (int)(point.Y - 100/distance), (int)(point.X + 100 / distance), (int)(point.Y + 100 / distance)), brush);
                                            device.DrawTextLayout(new RawVector2(point.X + 10, point.Y - 5), new TextLayout(fontFactory, "[" + health + "]" + "[" + Math.Floor(distance) + "m]" + e.PlayerName, font, 1000, 1000), brush);
                                        } else if (Settings.Default.Player_Awake_Box_Check) {
                                            brush = GetColor(Settings.Default.Player_Awake_Box_Color);
                                            if (Settings.Default.Player_Crouching_Box_Check && e.IsPlayerCrouching) {
                                                brush = GetColor(Settings.Default.Player_Crouching_Box_Color);
                                            }
                                            if (Settings.Default.Player_Sprinting_Box_Check && e.IsPlayerSprinting) {
                                                brush = GetColor(Settings.Default.Player_Sprinting_Box_Color);
                                            }
                                            if (Settings.Default.Player_Awake_Box_Check && e.IsPlayerAiming) {
                                                brush = GetColor(Settings.Default.Player_Awake_Box_Color);
                                            }
                                            device.DrawRectangle(new RawRectangleF((int)(point.X - 200 / distance), (int)(point.Y - 500 / distance), (int)(point.X + 200 / distance), (int)(point.Y + 500 / distance)), brush);
                                            device.DrawTextLayout(new RawVector2(tx, t), new TextLayout(fontFactory, "[" + health + "]" + "[" + Math.Floor(distance) + "m]" + e.PlayerName, font, 1000, 1000), whiteBrush);
                                            
                                            if (Settings.Default.Player_Inventory_Belt) {
                                                foreach (var i in e.InvBelt) {
                                                    if (i != null) {
                                                        device.DrawTextLayout(new RawVector2(tx, t), new TextLayout(fontFactory, StringPool.GetItem(i.itemid), font, 1000, 1000), whiteBrush);
                                                        t += 10;
                                                    }
                                                }
                                            }
                                            if (Settings.Default.Player_Inventory_Wear) {
                                                foreach (var i in e.InvWear) {
                                                    using (TextLayout layout = new TextLayout(fontFactory, StringPool.GetItem(i.itemid), font, 1000, 1000)) {
                                                        device.DrawTextLayout(new RawVector2(tx, t), layout, whiteBrush);
                                                        t += 10;
                                                    }
                                                }
                                            }
                                        }
                                        if (Settings.Default.Player_Held_Item_Enable && e.HasHeldItem && e.HeldItem != null) {
                                            device.DrawTextLayout(new RawVector2(tx, t), new TextLayout(fontFactory, e.HeldItem, font, 1000, 1000), whiteBrush);
                                        }
                                        brush.Dispose();
                                    }
                                }
                            }

                            foreach (var e in Entity.GetLootCorpses()) {
                                var distance = GetDistance(localP, e.Position);

                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }

                                if (Settings.Default.Player_Loot_Corpse_Radar_Check && Settings.Default.Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));

                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Player_Loot_Corpse_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[Loot]" + "[" + Math.Floor(distance) + "m]" + e.CorpseName, font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Player_Loot_Corpse_Tracer_Check && Settings.Default.Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Player_Loot_Corpse_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Player_Loot_Corpse_Box_Check && Settings.Default.Box_Check) {
                                        device.DrawTextLayout(new RawVector2(point.X + 10, point.Y - 10), new TextLayout(fontFactory, "[Loot]" + "[" + Math.Floor(distance) + "m]" + e.CorpseName, font, 1000, 1000), whiteBrush);
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), GetColor(Settings.Default.Player_Loot_Corpse_Box_Color));
                                    }
                                }
                            }
                        }
                        /*-------------------------------------Animals-------------------------------------------- - */
                        if (Settings.Default.Animals) {

                            foreach (var e in Entity.GetAnimals()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }

                                if (Settings.Default.Radar_Check) {
                                    SolidColorBrush brush = null;

                                    switch (e.Name) {
                                        case "Boar": if (Settings.Default.Animals_Boar_Radar_Check) brush = GetColor(Settings.Default.Animals_Boar_Radar_Color); break;
                                        case "Bear": if (Settings.Default.Animals_Bear_Radar_Check) brush = GetColor(Settings.Default.Animals_Bear_Radar_Color); break;
                                        case "Horse": if (Settings.Default.Animals_Horse_Radar_Check) brush = GetColor(Settings.Default.Animals_Horse_Radar_Color); break;
                                        case "Chicken": if (Settings.Default.Animals_Chicken_Radar_Check) brush = GetColor(Settings.Default.Animals_Chicken_Radar_Color); break;
                                        case "Stag": if (Settings.Default.Animals_Deer_Radar_Check) brush = GetColor(Settings.Default.Animals_Deer_Radar_Color); break;
                                        case "Wolf": if (Settings.Default.Animals_Wolf_Radar_Check) brush = GetColor(Settings.Default.Animals_Wolf_Radar_Color); break;
                                    }
                                    if (brush != null) {
                                        RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                        if (InsideCircle(Center)) {
                                            device.FillEllipse(new Ellipse(Center, 2, 2), brush);
                                            device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(e.CombatHealth) + "]" + "[" + Math.Floor(distance) + "m]" + e.Name, font, 1000, 1000), whiteBrush);
                                        }
                                        brush.Dispose();
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check) {
                                        SolidColorBrush brush = null;
                                        switch (e.Name) {
                                            case "Boar": if (Settings.Default.Animals_Boar_Tracer_Check) brush = GetColor(Settings.Default.Animals_Boar_Tracer_Color); break;
                                            case "Bear": if (Settings.Default.Animals_Bear_Tracer_Check) brush = GetColor(Settings.Default.Animals_Bear_Tracer_Color); break;
                                            case "Horse": if (Settings.Default.Animals_Horse_Tracer_Check) brush = GetColor(Settings.Default.Animals_Horse_Tracer_Color); break;
                                            case "Chicken": if (Settings.Default.Animals_Chicken_Tracer_Check) brush = GetColor(Settings.Default.Animals_Chicken_Tracer_Color); break;
                                            case "Stag": if (Settings.Default.Animals_Deer_Tracer_Check) brush = GetColor(Settings.Default.Animals_Deer_Tracer_Color); break;
                                            case "Wolf": if (Settings.Default.Animals_Wolf_Tracer_Check) brush = GetColor(Settings.Default.Animals_Wolf_Tracer_Color); break;
                                        }
                                        if (brush != null) {
                                            device.DrawLine(BotScreenCenter, point, brush, 2);
                                            brush.Dispose();
                                        }
                                    }
                                    if (Settings.Default.Box_Check) {
                                        SolidColorBrush brush = null;;
                                        switch (e.Name) {
                                            case "Boar": if (Settings.Default.Animals_Boar_Box_Check) brush = GetColor(Settings.Default.Animals_Boar_Box_Color); break;
                                            case "Bear": if (Settings.Default.Animals_Bear_Box_Check) brush = GetColor(Settings.Default.Animals_Bear_Box_Color); break;
                                            case "Horse": if (Settings.Default.Animals_Horse_Box_Check) brush = GetColor(Settings.Default.Animals_Horse_Box_Color); break;
                                            case "Chicken": if (Settings.Default.Animals_Chicken_Box_Check) brush = GetColor(Settings.Default.Animals_Chicken_Box_Color); break;
                                            case "Stag": if (Settings.Default.Animals_Deer_Box_Check) brush = GetColor(Settings.Default.Animals_Deer_Box_Color); break;
                                            case "Wolf": if (Settings.Default.Animals_Wolf_Box_Check) brush = GetColor(Settings.Default.Animals_Wolf_Box_Color); break;
                                        }
                                        if (brush != null) {
                                            device.DrawTextLayout(new RawVector2(point.X + 10, point.Y - 10), new TextLayout(fontFactory, "[" + Math.Floor(e.CombatHealth) + "]" + "[" + Math.Floor(distance) + "m]" + e.Name, font, 1000, 1000), whiteBrush);
                                            device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), brush);
                                            brush.Dispose();
                                        }
                                    }
                                }
                            }
                        }

                        /* ------------------------------------- Resources --------------------------------------------- */
                        if (Settings.Default.Resources_Check) {
                            foreach (var e in Entity.GetResources()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }

                                if (Settings.Default.Radar_Check) {
                                    SolidColorBrush brush = null;
                                    switch (e.Name) {
                                        case "Metal Node": if (Settings.Default.Resource_Metal_Node_Radar_Check) brush = GetColor(Settings.Default.Resource_Metal_Node_Radar_Color); break;
                                        case "Sulfur Node": if (Settings.Default.Resource_Sulfur_Node_Radar_Check) brush = GetColor(Settings.Default.Resource_Sulfur_Node_Radar_Color); break;
                                        case "Stone Node": if (Settings.Default.Resource_Stone_Node_Radar_Check) brush = GetColor(Settings.Default.Resource_Stone_Node_Radar_Color); break;
                                    }
                                    if (brush != null) {
                                        RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                        if (InsideCircle(Center)) {
                                            device.FillEllipse(new Ellipse(Center, 2, 2), brush);
                                            device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + (3 - e.ResourceStage) + "]" + "[" + Math.Floor(distance) + "m]" + e.Name, font, 1000, 1000), whiteBrush);
                                        }
                                        brush.Dispose();
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check) {
                                        SolidColorBrush brush = null;
                                        switch (e.Name) {
                                            case "Metal Node": if (Settings.Default.Resource_Metal_Node_Tracer_Check) brush = GetColor(Settings.Default.Resource_Metal_Node_Tracer_Color); break;
                                            case "Sulfur Node": if (Settings.Default.Resource_Sulfur_Node_Tracer_Check) brush = GetColor(Settings.Default.Resource_Sulfur_Node_Tracer_Color); break;
                                            case "Stone Node": if (Settings.Default.Resource_Stone_Node_Tracer_Check) brush = GetColor(Settings.Default.Resource_Stone_Node_Tracer_Color); break;
                                        }
                                        if (brush != null) {
                                            device.DrawLine(BotScreenCenter, point, brush, 2);
                                            brush.Dispose();
                                        }
                                    }
                                    if (Settings.Default.Box_Check) {
                                        SolidColorBrush brush = null;
                                        switch (e.Name) {
                                            case "Metal Node": if (Settings.Default.Resource_Metal_Node_Box_Check) brush = GetColor(Settings.Default.Resource_Metal_Node_Box_Color); break;
                                            case "Sulfur Node": if (Settings.Default.Resource_Sulfur_Node_Box_Check) brush = GetColor(Settings.Default.Resource_Sulfur_Node_Box_Color); break;
                                            case "Stone Node": if (Settings.Default.Resource_Stone_Node_Box_Check) brush = GetColor(Settings.Default.Resource_Stone_Node_Box_Color); break;
                                        }
                                        if (brush != null) {
                                            device.DrawRectangle(new RawRectangleF((int)(point.X - 400 / distance), (int)(point.Y - 400 / distance), (int)(point.X + 400 / distance), (int)(point.Y + 400 / distance)), brush);
                                            device.DrawTextLayout(new RawVector2(point.X + 10, point.Y - ty), new TextLayout(fontFactory, "[" + (3 - e.ResourceStage) + "]" + "[" + Math.Floor(distance) + "m]" + e.Name, font, 1000, 1000), whiteBrush);
                                            brush.Dispose();
                                        }
                                    }
                                }
                            }

                            foreach (var e in Entity.GetCollectables()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check) {
                                    SolidColorBrush brush = null;
                                    switch (e.Name) {
                                        case "Metal": if (Settings.Default.Resource_Metal_Ore_Radar_Check) brush = GetColor(Settings.Default.Resource_Metal_Ore_Radar_Color); break;
                                        case "Stone": if (Settings.Default.Resource_Rock_Radar_Check) brush = GetColor(Settings.Default.Resource_Rock_Radar_Color); break;
                                        case "Sulfur": if (Settings.Default.Resource_Sulfur_Ore_Radar_Check) brush = GetColor(Settings.Default.Resource_Sulfur_Ore_Radar_Color); break;
                                        case "Wood": if (Settings.Default.Resource_Wood_Radar_Check) brush = GetColor(Settings.Default.Resource_Wood_Radar_Color); break;
                                    }
                                    if (brush != null) {
                                        RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                        if (InsideCircle(Center)) {
                                            device.FillEllipse(new Ellipse(Center, 2, 2), brush);
                                            device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, e.Name, font, 1000, 1000), whiteBrush);
                                        }
                                        brush.Dispose();
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check) {
                                        SolidColorBrush brush = null;
                                        switch (e.Name) {
                                            case "Metal": if (Settings.Default.Resource_Metal_Collectable_Tracer_Check) brush = GetColor(Settings.Default.Resource_Metal_Collectable_Tracer_Color); break;
                                            case "Stone": if (Settings.Default.Resource_Rock_Collectable_Tracer_Check) brush = GetColor(Settings.Default.Resource_Rock_Collectable_Tracer_Color); break;
                                            case "Sulfur": if (Settings.Default.Resource_Sulfur_Collectable_Tracer_Check) brush = GetColor(Settings.Default.Resource_Sulfur_Collectable_Tracer_Color); break;
                                            case "Wood": if (Settings.Default.Resource_Wood_Collectable_Tracer_Check) brush = GetColor(Settings.Default.Resource_Wood_Collectable_Tracer_Color); break;
                                        }
                                        if (brush != null) {
                                            device.DrawLine(BotScreenCenter, point, brush, 2);
                                            brush.Dispose();
                                        }
                                    }
                                    if (Settings.Default.Box_Check) {
                                        SolidColorBrush brush = null;
                                        switch (e.Name) {
                                            case "Metal": if (Settings.Default.Resource_Metal_Collectable_Box_Check) brush = GetColor(Settings.Default.Resource_Metal_Collectable_Box_Color); break;
                                            case "Stone": if (Settings.Default.Resource_Rock_Collectable_Box_Check) brush = GetColor(Settings.Default.Resource_Rock_Collectable_Box_Color); break;
                                            case "Sulfur": if (Settings.Default.Resource_Sulfur_Collectable_Box_Check) brush = GetColor(Settings.Default.Resource_Sulfur_Collectable_Box_Color); break;
                                            case "Wood": if (Settings.Default.Resource_Wood_Collectable_Box_Check) brush = GetColor(Settings.Default.Resource_Wood_Collectable_Box_Color); break;
                                        }
                                        if (brush != null) {
                                            device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), brush);
                                            device.DrawTextLayout(new RawVector2(point.X + 10, point.Y - 5), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "m]" + e.Name, font, 1000, 1000), whiteBrush);
                                            brush.Dispose();
                                        }
                                    }
                                }
                            }
                        }

                        /* ------------------------------------- Barrels --------------------------------------------- */
                        if (Settings.Default.Barrels) {
                            foreach (var e in Entity.GetBarrels()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check) {
                                    SolidColorBrush brush = null;
                                    switch (e.Name) {
                                        case "Loot Barrel": if (Settings.Default.Barrel_Loot_Barrel_Radar_Check) brush = GetColor(Settings.Default.Barrel_Loot_Barrel_Radar_Color); break;
                                        case "Oil Barrel": if (Settings.Default.Barrel_Oil_Barrel_Radar_Check) brush = GetColor(Settings.Default.Barrel_Oil_Barrel_Radar_Color); break;
                                        case "Trash Pile": if (Settings.Default.Barrel_Trash_Pile_Radar_Check) brush = GetColor(Settings.Default.Barrel_Trash_Pile_Radar_Color); break;
                                        case "Crate": if (Settings.Default.Barrel_Crate_Radar_Check) brush = GetColor(Settings.Default.Barrel_Crate_Radar_Color); break;
                                        case "Mine Crate": if (Settings.Default.Barrel_Mine_Crate_Radar_Check) brush = GetColor(Settings.Default.Barrel_Mine_Crate_Radar_Color); break;
                                        case "Food Crate": if (Settings.Default.Barrel_Food_Crate_Radar_Check) brush = GetColor(Settings.Default.Barrel_Food_Crate_Radar_Color); break;
                                        case "Medical Crate": if (Settings.Default.Barrel_Med_Crate_Radar_Check) brush = GetColor(Settings.Default.Barrel_Med_Crate_Radar_Color); break;
                                        case "Tool Crate": if (Settings.Default.Barrel_Tool_Crate_Radar_Check) brush = GetColor(Settings.Default.Barrel_Tool_Crate_Radar_Color); break;
                                        case "Food Box": if (Settings.Default.Barrel_Food_Box_Radar_Check) brush = GetColor(Settings.Default.Barrel_Food_Box_Radar_Color); break;
                                    }
                                    if (brush != null) {
                                        RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                        if (InsideCircle(Center)) {
                                            device.FillEllipse(new Ellipse(Center, 2, 2), brush);
                                            device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "m]" + e.Name, font, 1000, 1000), whiteBrush);
                                        }
                                        brush.Dispose();
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check) {
                                        SolidColorBrush brush = null;
                                        switch (e.Name) {
                                            case "Loot Barrel": if (Settings.Default.Barrel_Loot_Barrel_Tracer_Check) brush = GetColor(Settings.Default.Barrel_Loot_Barrel_Tracer_Color); break;
                                            case "Oil Barrel": if (Settings.Default.Barrel_Oil_Barrel_Tracer_Check) brush = GetColor(Settings.Default.Barrel_Oil_Barrel_Tracer_Color); break;
                                            case "Trash Pile": if (Settings.Default.Barrel_Trash_Pile_Tracer_Check) brush = GetColor(Settings.Default.Barrel_Trash_Pile_Tracer_Color); break;
                                            case "Crate": if (Settings.Default.Barrel_Crate_Tracer_Check) brush = GetColor(Settings.Default.Barrel_Crate_Tracer_Color); break;
                                            case "Mine Crate": if (Settings.Default.Barrel_Mine_Crate_Tracer_Check) brush = GetColor(Settings.Default.Barrel_Mine_Crate_Tracer_Color); break;
                                            case "Food Crate": if (Settings.Default.Barrel_Food_Crate_Tracer_Check) brush = GetColor(Settings.Default.Barrel_Food_Crate_Tracer_Color); break;
                                            case "Medical Crate": if (Settings.Default.Barrel_Med_Crate_Tracer_Check) brush = GetColor(Settings.Default.Barrel_Med_Crate_Tracer_Color); break;
                                            case "Tool Crate": if (Settings.Default.Barrel_Tool_Crate_Tracer_Check) brush = GetColor(Settings.Default.Barrel_Tool_Crate_Tracer_Color); break;
                                            case "Food Box": if (Settings.Default.Barrel_Food_Box_Tracer_Check) brush = GetColor(Settings.Default.Barrel_Food_Box_Tracer_Color); break;
                                        }
                                        if (brush != null) {
                                            device.DrawLine(BotScreenCenter, point, brush, 2);
                                            brush.Dispose();
                                        }
                                    }
                                    if (Settings.Default.Box_Check) {
                                        SolidColorBrush brush = null;
                                        switch (e.Name) {
                                            case "Loot Barrel": if (Settings.Default.Barrel_Loot_Barrel_Box_Check) brush = GetColor(Settings.Default.Barrel_Loot_Barrel_Box_Color); break;
                                            case "Oil Barrel": if (Settings.Default.Barrel_Oil_Barrel_Box_Check) brush = GetColor(Settings.Default.Barrel_Oil_Barrel_Box_Color); break;
                                            case "Trash Pile": if (Settings.Default.Barrel_Trash_Pile_Box_Check) brush = GetColor(Settings.Default.Barrel_Trash_Pile_Box_Color); break;
                                            case "Crate": if (Settings.Default.Barrel_Crate_Box_Check) brush = GetColor(Settings.Default.Barrel_Crate_Box_Color); break;
                                            case "Mine Crate": if (Settings.Default.Barrel_Mine_Crate_Box_Check) brush = GetColor(Settings.Default.Barrel_Mine_Crate_Box_Color); break;
                                            case "Food Crate": if (Settings.Default.Barrel_Food_Crate_Box_Check) brush = GetColor(Settings.Default.Barrel_Food_Crate_Box_Color); break;
                                            case "Medical Crate": if (Settings.Default.Barrel_Med_Crate_Box_Check) brush = GetColor(Settings.Default.Barrel_Med_Crate_Box_Color); break;
                                            case "Tool Crate": if (Settings.Default.Barrel_Tool_Crate_Box_Check) brush = GetColor(Settings.Default.Barrel_Tool_Crate_Box_Color); break;
                                            case "Food Box": if (Settings.Default.Barrel_Food_Box_Box_Check) brush = GetColor(Settings.Default.Barrel_Food_Box_Box_Color); break;
                                        }
                                        if (brush != null) {
                                            device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), brush);
                                            device.DrawTextLayout(new RawVector2(point.X + 10, point.Y - 5), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "m]" + e.Name, font, 1000, 1000), whiteBrush);
                                            brush.Dispose();
                                        }
                                    }
                                }
                            }
                        }

                        /* ------------------------------------- Plants --------------------------------------------- */
                        if (Settings.Default.Plants_Check) {

                            foreach (var e in Entity.GetPlants()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check) {
                                    SolidColorBrush brush = null;
                                    switch (e.Name) {
                                        case "Corn": if (Settings.Default.Plant_Corn_Radar_Check) brush = GetColor(Settings.Default.Plant_Pumpkin_Radar_Color); break;
                                        case "Hemp": if (Settings.Default.Plant_Hemp_Radar_Check) brush = GetColor(Settings.Default.Plant_Hemp_Radar_Color); break;
                                        case "Mushroom": if (Settings.Default.Plant_Mushroom_Radar_Check) brush = GetColor(Settings.Default.Plant_Mushroom_Radar_Color); break;
                                        case "Pumpkin": if (Settings.Default.Plant_Pumpkin_Radar_Check) brush = GetColor(Settings.Default.Plant_Pumpkin_Radar_Color); break;
                                    }
                                    if (brush != null) {
                                        RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                        if (InsideCircle(Center)) {
                                            device.FillEllipse(new Ellipse(Center, 2, 2), brush);
                                            device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, e.Name, font, 1000, 1000), whiteBrush);
                                        }
                                        brush.Dispose();
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check) {
                                        SolidColorBrush brush = null;
                                        switch (e.Name) {
                                            case "Corn": if (Settings.Default.Plant_Corn_Tracer_Check) brush = GetColor(Settings.Default.Plant_Pumpkin_Tracer_Color); break;
                                            case "Hemp": if (Settings.Default.Plant_Hemp_Tracer_Check) brush = GetColor(Settings.Default.Plant_Hemp_Tracer_Color); break;
                                            case "Mushroom": if (Settings.Default.Plant_Mushroom_Tracer_Check) brush = GetColor(Settings.Default.Plant_Mushroom_Tracer_Color); break;
                                            case "Pumpkin": if (Settings.Default.Plant_Pumpkin_Tracer_Check) brush = GetColor(Settings.Default.Plant_Pumpkin_Tracer_Color); break;
                                        }
                                        if (brush != null) {
                                            device.DrawLine(BotScreenCenter, point, brush, 2);
                                            brush.Dispose();
                                        }
                                    }
                                    if (Settings.Default.Box_Check) {
                                        SolidColorBrush brush = null;
                                        switch (e.Name) {
                                            case "Corn": if (Settings.Default.Plant_Corn_Radar_Check) brush = GetColor(Settings.Default.Plant_Pumpkin_Box_Color); break;
                                            case "Hemp": if (Settings.Default.Plant_Hemp_Radar_Check) brush = GetColor(Settings.Default.Plant_Hemp_Box_Color); break;
                                            case "Mushroom": if (Settings.Default.Plant_Mushroom_Radar_Check) brush = GetColor(Settings.Default.Plant_Mushroom_Box_Color); break;
                                            case "Pumpkin": if (Settings.Default.Plant_Pumpkin_Radar_Check) brush = GetColor(Settings.Default.Plant_Pumpkin_Box_Color); break;
                                        }
                                        if (brush != null) {
                                            device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), brush);
                                            device.DrawTextLayout(new RawVector2(point.X + 10, point.Y - 5), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "m]" + e.Name, font, 1000, 1000), whiteBrush);
                                            brush.Dispose();
                                        }
                                    }
                                }
                            }
                        }

                        /* ------------------------------------- Deployables --------------------------------------------- */
                        if (Settings.Default.Deployables) {
                            foreach (var e in Entity.GetToolCups()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_TC_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_TC_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "TC", font, 1000, 1000), whiteBrush);
                                    }
                                }
                                RawVector2 point;
                                var pos = e.Position;
                                pos.y -= 0.5f;
                                if (WorldToScreen(localP, localR, pos, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_TC_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_TC_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_TC_Box_Check) {
                                        var t = point.Y - 600 / distance;
                                        device.DrawTextLayout(new RawVector2(point.X + 400 / distance + 5, t), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "m]" + "TC", font, 1000, 1000), whiteBrush);
                                        t += 10;
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - 400 / distance), (int)(point.Y - 600 / distance), (int)(point.X + 400 / distance), (int)(point.Y + 600 / distance)), GetColor(Settings.Default.Deployable_TC_Box_Color));
                                        foreach (var i in e.TCList) {
                                            device.DrawTextLayout(new RawVector2(point.X + 400 / distance + 5, t), new TextLayout(fontFactory, i.username, font, 1000, 1000), whiteBrush);
                                            t += 10;
                                        }
                                    }
                                }

                            }

                            foreach (var e in Entity.GetSleepingBags()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Sleeping_Bag_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_Sleeping_Bag_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "[Bag]" + e.BagName, font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Sleeping_Bag_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Sleeping_Bag_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Sleeping_Bag_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), GetColor(Settings.Default.Deployable_Sleeping_Bag_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetQuarrys()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Quarry_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_Quarry_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Quarry", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Quarry_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Quarry_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Quarry_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), GetColor(Settings.Default.Deployable_Quarry_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetLandmines()) {
                                var pos = e.Position;
                                var distance = GetDistance(localP, pos);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Landmine_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_Landmine_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Landmine", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                pos.y -= 1;
                                if (WorldToScreen(localP, localR, pos, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Landmine_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Landmine_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Landmine_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - 100 / distance), (int)(point.Y - 100 / distance), (int)(point.X + 100 / distance), (int)(point.Y + 100 / distance)), GetColor(Settings.Default.Deployable_Landmine_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetTurrets()) {
                                var pos = e.Position;
                                var distance = GetDistance(localP, pos);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_AutoTurret_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_AutoTurret_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "[" + Math.Floor(e.CombatHealth) + "]" + "Turret", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                pos.y -= 1f;
                                if (WorldToScreen(localP, localR, pos, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_AutoTurret_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_AutoTurret_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_AutoTurret_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - 200 / distance), (int)(point.Y - 300 / distance), (int)(point.X + 200 / distance), (int)(point.Y + 300 / distance)), GetColor(Settings.Default.Deployable_AutoTurret_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetBearTraps()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Bear_Trap_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_Bear_Trap_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Bear Trap", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Bear_Trap_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Bear_Trap_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Bear_Trap_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), GetColor(Settings.Default.Deployable_Bear_Trap_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetFurnaces()) {
                                var pos = e.Position;
                                var distance = GetDistance(localP, pos);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Furnace_Radar_heck) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_Furnace_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Furnace", font, 1000, 1000), whiteBrush);
                                    }
                                }
                                RawVector2 point;
                                pos.y -= 0.75f;
                                if (WorldToScreen(localP, localR, pos, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Furnace_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Furnace_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Furnace_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - 300 / distance), (int)(point.Y - 500 / distance), (int)(point.X + 300 / distance), (int)(point.Y + 500 / distance)), GetColor(Settings.Default.Deployable_Furnace_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetLargeFurnaces()) {
                                var pos = e.Position;

                                var distance = GetDistance(localP, pos);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Large_Furnace_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_Large_Furnace_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Large Furnace", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                pos.y -= 1;
                                if (WorldToScreen(localP, localR, pos, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Large_Furnace_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Large_Furnace_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Large_Furnace_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - 300 / distance), (int)(point.Y - 600 / distance), (int)(point.X + 300 / distance), (int)(point.Y + 600 / distance)), GetColor(Settings.Default.Deployable_Large_Furnace_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetOils()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Oil_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_Oil_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Oil Refinery", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Oil_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Oil_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Oil_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), GetColor(Settings.Default.Deployable_Oil_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetStashes()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Stash_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_Stash_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Stash", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Stash_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Stash_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Stash_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), GetColor(Settings.Default.Deployable_Stash_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetChests()) {
                                var pos = e.Position;
                                var distance = GetDistance(localP, pos);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Box_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_Box_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Small Chest", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                
                                pos.y -= 1;
                                if (WorldToScreen(localP, localR, pos, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Box_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Box_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Box_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - 200 / distance), (int)(point.Y - 200 / distance), (int)(point.X + 200 / distance), (int)(point.Y + 200 / distance)), GetColor(Settings.Default.Deployable_Box_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetLargeChests()) {
                                var pos = e.Position;
                                var distance = GetDistance(localP, pos);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Large_Box_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 3, 3), GetColor(Settings.Default.Deployable_Large_Box_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Large Chest", font, 1000, 1000), whiteBrush);
                                    }
                                }
                                RawVector2 point;
                                pos.y -= 1f;
                                if (WorldToScreen(localP, localR, pos, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Large_Box_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Large_Box_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Large_Box_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - 300 / distance), (int)(point.Y - 300 / distance), (int)(point.X + 300 / distance), (int)(point.Y + 300 / distance)), GetColor(Settings.Default.Deployable_Large_Box_Box_Color));
                                    }
                                }
                            }

                            foreach (var e in Entity.GetFridges()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }
                                if (Settings.Default.Radar_Check && Settings.Default.Deployable_Fridge_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Deployable_Fridge_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Fridge", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                var pos = e.Position;
                                pos.y -= Settings.Default.Temp1;
                                if (WorldToScreen(localP, localR, pos, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Deployable_Fridge_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Deployable_Fridge_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Deployable_Fridge_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - 300 / distance), (int)(point.Y - 600 / distance), (int)(point.X + 300 / distance), (int)(point.Y + 600 / distance)), GetColor(Settings.Default.Deployable_Fridge_Box_Color));
                                    }
                                }
                            }
                        }

                        /* ------------------------------------- MISC --------------------------------------------- */
                        if (Settings.Default.Misc_Check) {

                            foreach (var e in Entity.GetSupplyDrops()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Settings.Default.Radar_Check && Settings.Default.Misc_Supply_Drop_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 3, 3), GetColor(Settings.Default.Misc_Supply_Drop_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Supply Drop", font, 1000, 1000), whiteBrush);
                                    }
                                }
                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Misc_Supply_Drop_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Misc_Supply_Drop_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Misc_Supply_Drop_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - 700 / distance), (int)(point.Y - 1000 / distance), (int)(point.X + 700 / distance), (int)(point.Y + 1000 / distance)), GetColor(Settings.Default.Misc_Supply_Drop_Box_Color));
                                        device.DrawTextLayout(new RawVector2(point.X + 10, point.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(distance) + "]" + "Supply Drop", font, 1000, 1000), whiteBrush);
                                    }
                                }
                            }

                            foreach (var e in Entity.GetHelicopters()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Settings.Default.Radar_Check && Settings.Default.Misc_Helicopter_Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));
                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Misc_Helicopter_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(e.HelicopterHealths[0]) + "]" + "[" + e.HelicopterHealths[1] + "]" + "]" + "[" + Math.Floor(distance) + "]" + "Helicopter", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Tracer_Check && Settings.Default.Misc_Helicopter_Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Misc_Helicopter_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Box_Check && Settings.Default.Misc_Helicopter_Box_Check) {
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), GetColor(Settings.Default.Misc_Helicopter_Box_Color));
                                        device.DrawTextLayout(new RawVector2(point.X + 10, point.Y - ty), new TextLayout(fontFactory, "[" + Math.Floor(e.HelicopterHealths[0]) + "]" + "[" + e.HelicopterHealths[1] + "]" + "[" + Math.Floor(distance) + "]" + "Helicopter", font, 1000, 1000), whiteBrush);
                                    }
                                }
                            }

                            foreach (var e in Entity.GetCorpses()) {
                                var distance = GetDistance(localP, e.Position);
                                if (Math.Floor(distance) > Settings.Default.MaxDistance) {
                                    continue;
                                }

                                if (Settings.Default.Misc_Corpse_Radar_Check && Settings.Default.Radar_Check) {
                                    RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.Position.x, e.Position.z));

                                    if (InsideCircle(Center)) {
                                        device.FillEllipse(new Ellipse(Center, 2, 2), GetColor(Settings.Default.Misc_Corpse_Radar_Color));
                                        device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, "[Corpse]" + "[" + Math.Floor(distance) + "m]", font, 1000, 1000), whiteBrush);
                                    }
                                }

                                RawVector2 point;
                                if (WorldToScreen(localP, localR, e.Position, out point)) {
                                    if (Settings.Default.Misc_Corpse_Tracer_Check && Settings.Default.Tracer_Check) {
                                        device.DrawLine(BotScreenCenter, point, GetColor(Settings.Default.Misc_Corpse_Tracer_Color), 2);
                                    }
                                    if (Settings.Default.Misc_Corpse_Box_Check && Settings.Default.Box_Check) {
                                        device.DrawTextLayout(new RawVector2(point.X + 10, point.Y - 10), new TextLayout(fontFactory, "[Corpse]" + "[" + Math.Floor(distance) + "m]", font, 1000, 1000), whiteBrush);
                                        device.DrawRectangle(new RawRectangleF((int)(point.X - d1 / distance), (int)(point.Y - d2 / distance), (int)(point.X + d1 / distance), (int)(point.Y + d2 / distance)), GetColor(Settings.Default.Misc_Corpse_Box_Color));
                                    }
                                }
                            }
                        }

                        if (GUI.Waypoints.Count > 0) {

                            foreach (var e in GUI.Waypoints) {

                                RawVector2 Center = GetCenter(new Vector2(localP.x, localP.z), new Vector2(e.X, e.Z));

                                if (InsideCircle(Center)) {
                                    var brush = GetColor(e.Colur);
                                    device.FillEllipse(new Ellipse(Center, 3, 3), brush);
                                    device.DrawTextLayout(new RawVector2(Center.X + 10, Center.Y - ty), new TextLayout(fontFactory, e.Name, font, 1000, 1000), brush);
                                }
                            }
                        }
                    }
                    device.EndDraw();
                } catch (Exception e) {
                    Console.WriteLine(e);
                }
            }
        }

        private float GetDistance(Vector3 a, Vector3 b) {
            return (float) Math.Sqrt(Math.Pow(b.x-a.x, 2)+ Math.Pow(b.y - a.y, 2) + Math.Pow(b.z - a.z, 2));
        }

        private SolidColorBrush GetColor(System.Drawing.Color c) {
            return new SolidColorBrush(device, new RawColor4(c.R / 255f, c.G / 255f, c.B / 255f, 1));
        }

        private RawVector2 GetPointOnCircle(double angle) {
            return new RawVector2((float)(300 + 250 * Math.Cos(angle * P)), (float)(300 + 250 * Math.Sin(angle * P)));
        }

        private bool InsideCircle(RawVector2 loc) {
            return Math.Pow((300 - loc.X), 2) + Math.Pow((300 - loc.Y), 2) < 62500;
        }

        private RawVector2 GetCenter(Vector2 l, Vector2 x) {

            float xx;
            float zz;

            if (l.x > x.x) {
                var dis = l.x - x.x;
                xx = 300 - dis;
            } else {
                var dis = x.x - l.x;
                xx = 300 + dis;
            }

            if (l.y > x.y) {
                var dis = l.y - x.y;
                zz = 300 + dis;
            } else {
                var dis = x.y - l.y;
                zz = 300 - dis;
            }

            return new RawVector2(xx, zz);

        }

        public Vector2 MovePointTowards(Vector2 a, Vector2 b, float distance) {
            var vector = a - b;
            var length = vector.magnitude;
            var unitVector = new Vector2(vector.x / length, vector.y / length);
            return new Vector2(b.x + unitVector.x * distance, b.y + unitVector.y * distance);
        }

        public Vector2 MovePointAway(Vector2 a, Vector2 b, float distance) {
            var vector = a - b;
            var length = vector.magnitude;
            var unitVector = new Vector2(vector.x / length, vector.y / length);
            return new Vector2(b.x - unitVector.x * distance, b.y - unitVector.y * distance);
        }

        public bool WorldToScreen(Vector3 from, Vector3 rot, Vector3 target, out RawVector2 vector) {
            vector = new RawVector2();
            float[,] matrix = new float[3, 3];

            var fromPoint = new Vector3(from.x, from.y, -from.z);
            var point = new Vector3(target.x, target.y, -target.z) - fromPoint;

            var cosX = (float)Math.Cos(rot.z * P);
            var cosY = (float)Math.Cos(rot.y * P);
            var cosZ = (float)Math.Cos(rot.z * P);
            var sinX = (float)Math.Sin(rot.x * P);
            var sinY = (float)Math.Sin(rot.y * P);
            var sinZ = (float)Math.Sin(rot.z * P);

            matrix[2, 0] = -cosX * sinY;
            matrix[2, 1] = sinX;
            matrix[2, 2] = cosX * cosY;

            var z = matrix[2, 0] * point.x + matrix[2, 1] * point.y + matrix[2, 2] * point.z;
            // If behind camera.
            if (-z < 0) {return false;}

            matrix[1, 0] = cosY * sinZ + cosZ * sinX * sinY;
            matrix[1, 1] = cosZ * cosX;
            matrix[1, 2] = sinZ * sinY - cosZ * cosY * sinX;

            var y = matrix[1, 0] * point.x + matrix[1, 1] * point.y + matrix[1, 2] * point.z;

            matrix[0, 0] = cosZ * cosY - sinZ * sinX * sinY;
            matrix[0, 1] = -cosX * sinZ;
            matrix[0, 2] = cosZ * sinY + cosY * sinZ * sinX;

            var x = matrix[0, 0] * point.x + matrix[0, 1] * point.y + matrix[0, 2] * point.z;
            
            point = new Vector3(x, -y, -z);

            var screenX = focalLength * point.x / point.z + 960;
            var screenY = focalLength * point.y / point.z + 540;

            vector.X = screenX;
            vector.Y = screenY;

            return true;
        }
    }
}