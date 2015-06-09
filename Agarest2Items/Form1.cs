using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;


namespace Agarest2Items
{

    public partial class Form1 : Form
    {

        #region FIELDS


        Form2 aboutForm = new Form2();


        /*
        584
613		625
634		638
851		860
902		920
958
        */

        List<byte[]> items = new List<byte[]>();
        byte[] item = new byte[164];
        readonly byte[] nil = new byte[164];
        byte[] all;


        byte[] ida = new byte[2];
        ushort id = 0;


        byte[] maxSkills;

        private static readonly int INVENTORY = 0x4F50370;
        private static readonly int ARTS_SKILLS = 0x4F8C460;




        #endregion FIELDS


        // types num3, (num4)
        // weapon = 1
        // armor = 2
        // accessory = 3
        //


        public Form1()
        {

            InitializeComponent();

            //try
            //{
            //    File.WriteAllBytes(Application.StartupPath + "\\data.cem",
            //        temp);
            //}
            //catch (Exception)
            //{

            //}

            maxSkills = Enumerable.Repeat((byte)0xff, 188).ToArray();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*

            CreateWeapons(29, 259);
            CreateArmor(260, 331);
            CreateAccessories(332, 372);

            //CreateWeapons(391, 423);
            //CreateArmor(424, 433);
            //CreateItems(434, 436);


            CreateItems(551, 616);
            CreateItems(626, 633);
            CreateItems(639, 850);
            CreateItems(861, 901);
            CreateItems(921, 958);
            CreateItems(971, 1022);
            CreateItems(1031, 1039);

            CreateBooks(1071, 1140);

            CreateBooks(1291, 1329);
            CreateBooks(1341, 1519);

            CreateBooks(3351, 3398);
            */


            Process proc = null;

            try
            {
                proc = Process.GetProcessesByName("Agarest2").FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Run Agarest 2 and load a game.", "Error", MessageBoxButtons.OK);
                return;
            }


            IntPtr handle = OpenProcess(ProcessAccessFlags.All, false, (int)proc.Id);



            ProcessModuleCollection procmcol = proc.Modules;
            ProcessModule procm = null;


            foreach (ProcessModule found in procmcol)
                if (found.ModuleName == "Agarest2.exe")
                {
                    procm = found;
                    break;
                }

            if (procm == null) return;


            int nag = 0;
            int offset = ARTS_SKILLS;/*
            byte[] num = new byte[1];


            while (!overwriteCheckbox.Checked)
            {

                ReadProcessMemory(
                handle,
                procm.BaseAddress + offset,
                num,
                1,
                ref nag);

                if (num[0] == 0) break;


                offset += 0xA4;

            }


            all = items.SelectMany(a => a).ToArray();


            if (!WriteProcessMemory(
                handle,
                procm.BaseAddress + offset,
                all,
                (uint)all.Length,
                out nag))
            {
                // fail
            }


            items.Clear();

            */
            //CreateArts(1146, 1154);
            //CreateArts(1181, 1265);
            CreateArts(1141, 1290);
            CreateSkills(2226, 2279);
            CreateSkills(2284, 2294);


            all = items.SelectMany(a => a).ToArray();

            offset = ARTS_SKILLS;


            if (!WriteProcessMemory(
                handle,
                procm.BaseAddress + offset,
                all,
                (uint)all.Length,
                out nag))
            {
                // fail
            }



            CloseHandle(handle);


            Close();

        }


        private void CreateWeapons(ushort min, ushort max, bool maxed = false)
        {

            id = min;
            item = nil;


            while (id <= max)
            {

                item[0] = 0x63;
                item[4] = 0x05;
                item[8] = 0x0f;
                item[9] = 0x27;

                ida = BitConverter.GetBytes(id);

                item[12] = ida[0];
                item[13] = ida[1];

                item[28] = 0x01;



                item[112] = 0x0f;
                item[113] = 0x27;

                item[116] = 0x0f;
                item[117] = 0x27;

                item[120] = 0x0f;
                item[121] = 0x27;

                item[124] = 0x0f;
                item[125] = 0x27;

                item[128] = 0x0f;
                item[129] = 0x27;

                item[132] = 0x0f;
                item[133] = 0x27;


                item[136] = 0x9f;
                item[137] = 0x86;
                item[138] = 0x01;

                item[140] = 0x9f;
                item[141] = 0x86;
                item[142] = 0x01;

                item[144] = 0x9f;
                item[145] = 0x86;
                item[146] = 0x01;

                item[148] = 0x9f;
                item[149] = 0x86;
                item[150] = 0x01;

                item[152] = 0x9f;
                item[153] = 0x86;
                item[154] = 0x01;

                item[156] = 0x9f;
                item[157] = 0x86;
                item[158] = 0x01;


                item[160] = 0xe7;
                item[161] = 0x03;


                byte[] temp = new byte[164];

                Array.Copy(item, temp, item.Length);
                items.Add(temp);
                id++;

            }

        }

        private void CreateArmor(ushort min, ushort max, bool maxed = false)
        {

            id = min;
            item = nil;


            while (id <= max)
            {

                item[0] = 0x63;
                item[4] = 0x05;

                ida = BitConverter.GetBytes(id);

                item[12] = ida[0];
                item[13] = ida[1];

                item[28] = 0x02;


                item[64] = 0x01;
                item[68] = 0x01;
                item[72] = 0x01;
                item[76] = 0x01;


                item[112] = 0x0f;
                item[113] = 0x27;

                item[116] = 0x0f;
                item[117] = 0x27;

                item[120] = 0x0f;
                item[121] = 0x27;

                item[124] = 0x0f;
                item[125] = 0x27;

                item[128] = 0x0f;
                item[129] = 0x27;

                item[132] = 0x0f;
                item[133] = 0x27;


                item[136] = 0x9f;
                item[137] = 0x86;
                item[138] = 0x01;

                item[140] = 0x9f;
                item[141] = 0x86;
                item[142] = 0x01;

                item[144] = 0x9f;
                item[145] = 0x86;
                item[146] = 0x01;

                item[148] = 0x9f;
                item[149] = 0x86;
                item[150] = 0x01;

                item[152] = 0x9f;
                item[153] = 0x86;
                item[154] = 0x01;

                item[156] = 0x9f;
                item[157] = 0x86;
                item[158] = 0x01;


                item[160] = 0xe7;
                item[161] = 0x03;


                byte[] temp = new byte[164];

                Array.Copy(item, temp, 164);
                items.Add(temp);
                id++;

            }

        }

        private void CreateAccessories(ushort min, ushort max, bool maxed = false)
        {

            id = min;
            item = nil;


            while (id <= max)
            {

                item[0] = 0x63;
                item[4] = 0x05;

                ida = BitConverter.GetBytes(id);

                item[12] = ida[0];
                item[13] = ida[1];

                item[28] = 0x03;


                item[64] = 0x01;
                item[68] = 0x01;
                item[72] = 0x01;
                item[76] = 0x01;


                item[112] = 0x0f;
                item[113] = 0x27;

                item[116] = 0x0f;
                item[117] = 0x27;

                item[120] = 0x0f;
                item[121] = 0x27;

                item[124] = 0x0f;
                item[125] = 0x27;

                item[128] = 0x0f;
                item[129] = 0x27;

                item[132] = 0x0f;
                item[133] = 0x27;


                item[136] = 0x9f;
                item[137] = 0x86;
                item[138] = 0x01;

                item[140] = 0x9f;
                item[141] = 0x86;
                item[142] = 0x01;

                item[144] = 0x9f;
                item[145] = 0x86;
                item[146] = 0x01;

                item[148] = 0x9f;
                item[149] = 0x86;
                item[150] = 0x01;

                item[152] = 0x9f;
                item[153] = 0x86;
                item[154] = 0x01;

                item[156] = 0x9f;
                item[157] = 0x86;
                item[158] = 0x01;


                item[160] = 0xe7;
                item[161] = 0x03;


                byte[] temp = new byte[164];

                Array.Copy(item, temp, 164);
                items.Add(temp);
                id++;

            }

        }

        private void CreateItems(ushort min, ushort max, bool maxed = false)
        {

            id = min;
            item = nil;


            while (id <= max)
            {

                item[0] = 0x63;
                item[4] = 0x01;

                item[8] = 0xff;
                item[9] = 0xff;
                item[10] = 0xff;
                item[11] = 0xff;

                ida = BitConverter.GetBytes(id);

                item[12] = ida[0];
                item[13] = ida[1];

                item[28] = 0x04;

                byte[] temp = new byte[164];

                Array.Copy(item, temp, 164);
                items.Add(temp);
                id++;

            }

        }

        private void CreateBooks(ushort min, ushort max, bool maxed = false)
        {

            id = min;
            item = nil;


            while (id <= max)
            {

                item[0] = 0x01;
                item[4] = 0x01;

                item[8] = 0xff;
                item[9] = 0xff;
                item[10] = 0xff;
                item[11] = 0xff;

                ida = BitConverter.GetBytes(id);

                item[12] = ida[0];
                item[13] = ida[1];

                item[28] = 0x04;

                byte[] temp = new byte[164];

                Array.Copy(item, temp, 164);
                items.Add(temp);
                id++;

            }

        }

        private void CreateArts(ushort min, ushort max, bool maxed = false)
        {
            id = min;
            item = nil;


            while (id <= max)
            {

                item[0] = 0x01;
                item[4] = 0x01;

                item[8] = 0xff;
                item[9] = 0xff;
                item[10] = 0xff;
                item[11] = 0xff;

                ida = BitConverter.GetBytes(id);

                item[12] = ida[0];
                item[13] = ida[1];

                item[28] = 0x11;

                byte[] temp = new byte[164];

                Array.Copy(item, temp, 164);
                items.Add(temp);
                id++;

            }

        }

        private void CreateSkills(ushort min, ushort max, bool maxed = false)
        {

            id = min;
            item = nil;


            while (id <= max)
            {

                item[0] = 0x63;
                item[4] = 0x01;

                item[8] = 0xff;
                item[9] = 0xff;
                item[10] = 0xff;
                item[11] = 0xff;

                ida = BitConverter.GetBytes(id);

                item[12] = ida[0];
                item[13] = ida[1];

                item[24] = 0x01; // 1 or 2 or...
                item[28] = 0x06;

                byte[] temp = new byte[164];

                Array.Copy(item, temp, 164);
                items.Add(temp);
                id++;

            }
        }



        private bool IsValid(ushort id, ushort min, ushort max)
        {
            return
                (id >= 1 && id <= 29) ? false :
                (id >= 373 && id <= 390) ? false :
                (id >= 460 && id <= 472) ? false :
                (id >= 533 && id <= 550) ? false :
                (id >= 617 && id <= 625) ? false :
                (id >= 634 && id <= 638) ? false :
                (id >= 851 && id <= 860) ? false :
                (id >= 902 && id <= 920) ? false :
                (id >= 959 && id <= 970) ? false :
                (id >= 1023 && id <= 1030) ? false :
                (id >= 1040 && id <= 1070) ? false :
                (id >= 1141 && id <= 1145) ? false :
                (id >= 1155 && id <= 1180) ? false :
                (id >= 1267 && id <= 1290) ? false :
                (id >= 1330 && id <= 1340) ? false :
                (id >= 1520 && id <= 1540) ? false :
                (id == 1550) ? false :
                (id >= 1558 && id <= 1560) ? false :
                (id >= 1568 && id <= 1570) ? false :
                (id >= 1641 && id <= 1660) ? false :
                (id >= 1677) ? false : true;
        }


        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutForm.Show();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {


            int offset = (int)numericUpDown1.Value;


            Process proc = null;

            try
            {
                proc = Process.GetProcessesByName("Agarest2").FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Run Agarest 2 and load a game.", "Error", MessageBoxButtons.OK);
                return;
            }


            IntPtr handle = OpenProcess(ProcessAccessFlags.All, false, (int)proc.Id);



            ProcessModuleCollection procmcol = proc.Modules;
            ProcessModule procm = null;


            foreach (ProcessModule found in procmcol)
                if (found.ModuleName == "Agarest2.exe")
                {
                    procm = found;
                    break;
                }

            if (procm == null) return;


            int nag = 0;


            if (!WriteProcessMemory(
                handle,
                procm.BaseAddress + offset,
                maxSkills,
                (uint)maxSkills.Length,
                out nag))
            {
                // fail
            }


            CloseHandle(handle);

        }



        #region KERNEL32

        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }


        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint dwSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hProcess);

        #endregion KERNEL32

    }


}