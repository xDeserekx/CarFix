using CarFixMP;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFix.CustomControls
{
    public class CustomButtons
    {
        static bool isMax, isFull = false;
        static Point oldLocation, defaultLocation;
        static Size oldSize, defaultSize;
        static void OperationMaximize(CarFixInfo carFixInfo)
        {
            carFixInfo.WindowState = FormWindowState.Normal;
            carFixInfo.Location = new Point(0, 0);
            carFixInfo.Size = new Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height);
        }

        public static void SetDefault(CarFixInfo carFixInfo)
        {
            oldLocation = defaultLocation = carFixInfo.Location;
            oldSize = defaultSize = carFixInfo.Size;
        }

        public static void Maximize(CarFixInfo carFixInfo)
        {
            if (isMax == false)
            {
                oldLocation = new Point(carFixInfo.Location.X, carFixInfo.Location.Y);
                oldSize = new Size(carFixInfo.Size.Width, carFixInfo.Size.Height);
                OperationMaximize(carFixInfo);
                isFull = false;
                isMax = true;
            }
            else
            {
                if (oldSize.Width >= SystemInformation.WorkingArea.Width | oldSize.Height >= SystemInformation.WorkingArea.Height)
                {
                    carFixInfo.Location = defaultLocation;
                    carFixInfo.Size = defaultSize;
                }
                else
                {
                    carFixInfo.Location = oldLocation;
                    carFixInfo.Size = oldSize;
                }
                isMax = isFull = false;
            }
        }

        public static void Minimize(CarFixInfo carFixInfo)
        {
            carFixInfo.WindowState=(carFixInfo.WindowState == FormWindowState.Maximized)? FormWindowState.Normal:FormWindowState.Minimized;
        }

        public static void Exit()
        {
            Application.Exit();
        }
    }
}
