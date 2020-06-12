using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using Binarysharp.MemoryManagement;
using Binarysharp.MemoryManagement.Helpers;
using Binarysharp.MemoryManagement.Memory;

namespace NepHack
{
    public static class Program
    {
        public const string GameName    = "Megadimension Neptunia VIIR";
        public const string ProcessName = "v2r";

        public const int MaxCharacters   = 16;
        public const int MaxItems        = 4096;
        public const int MaxItemDataSize = 1886;
        public const int MaxEquipItems   = 9999;
        public const int MaxScouts       = 38;

        public const int ItemDataOffset      = -0xBF7CB7E;
        public const int CharacterOffset     = 0x2288;
        public const int ChallengeOffset     = 0x8D90;
        public const int MiscOffset          = 0xF6A4;
        public const int CharacterCalcOffset = 0x114930;
        public const int ItemOffset          = 0x1D058;
        public const int EquipOffset         = 0x2505C;
        public const int ScoutOffset         = 0xC7428;
        public const int NeplunkerOffset     = 0x44;

        public static MemorySharp Memory;

        public static IntPtr        BaseAddress = new IntPtr(0x14E82E8);
        public static RemotePointer ItemDataPointer;
        public static RemotePointer CharacterPointer;
        public static RemotePointer ChallengePointer;
        public static RemotePointer MiscPointer;
        public static RemotePointer ItemPointer;
        public static RemotePointer EquipPointer;
        public static RemotePointer ScoutPointer;

        public static IntPtr        NeplunkerBaseAddress        = new IntPtr(0x14F1F60);
        public static IntPtr        NeplunkerBaseAddressCurrent = IntPtr.Zero;
        public static RemotePointer NeplunkerPointer;

        public static EquipItem[] EquipItems = new EquipItem[MaxEquipItems];

        static Thread updateThread;

        [STAThread]
        static void Main()
        {
            try
            {
                Process process = ApplicationFinder.FromProcessName(ProcessName).First();

                if (process != null)
                {
                    Memory = new MemorySharp(process);

                    BaseAddress      = Memory[BaseAddress].Read<IntPtr>();
                    ItemDataPointer  = Memory[BaseAddress + ItemDataOffset, false];
                    CharacterPointer = Memory[BaseAddress + CharacterOffset, false];
                    ChallengePointer = Memory[BaseAddress + ChallengeOffset, false];
                    MiscPointer      = Memory[BaseAddress + MiscOffset, false];
                    ItemPointer      = Memory[BaseAddress + ItemOffset, false];
                    EquipPointer     = Memory[BaseAddress + EquipOffset, false];
                    ScoutPointer     = Memory[BaseAddress + ScoutOffset, false];

                    updateThread = new Thread(UpdateAddresses);
                    updateThread.Start();

                    for (int i = 0; i < MaxEquipItems; i++)
                        EquipItems[i] = new EquipItem();

                    Data.ParseItemData();
                    Data.ParseIDRanges();
                    Data.ParseParameters();
                    Data.ParseTraits();

                    // This is a stopgap fix to prevent some in-game CTDs and softlocks as reported by users in the tech forum
                    process.PriorityClass = ProcessPriorityClass.High;
                }
            }
            catch
            {
                MessageBox.Show($"Failed to attach to {GameName}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            updateThread.Abort();
        }

        static void UpdateAddresses()
        {
            while (true)
            {
                NeplunkerBaseAddressCurrent = Memory[NeplunkerBaseAddress].Read<IntPtr>();
                NeplunkerPointer            = Memory[NeplunkerBaseAddressCurrent + NeplunkerOffset, false];

                Thread.Sleep(10);
            }
        }
    }
}
