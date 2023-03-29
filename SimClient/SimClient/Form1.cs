using System;
using System.Windows.Forms;
using ACSharedMemory;
using System.IO.MemoryMappedFiles;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;


namespace SimClient
{
    public partial class Form1 : Form
    {
        AcData acData1;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        //Metodi Per estrarre dati 

        public struct AcData
        {
            public AcData(Physics p, ACSharedMemory.Graphics g, StaticInfo s, bool ready)
            {
                physics = p;
                graphics = g;
                staticInfo = s;
                readyInfo = ready;
            }
            public Physics physics { get; set; }
            public ACSharedMemory.Graphics graphics { get; set; }
            public StaticInfo staticInfo { get; set; }
            public bool readyInfo { get; set; }

        }
        //--------------------------------------
        //Method read mapped Files
        public AcData readMappedFile()
        {

            Physics p;
            Graphics g;
            StaticInfo i;
            

            AcData acData = new AcData(); ;

            MemoryMappedFile physicsMMF ;
            MemoryMappedFile graphicsMMF;
            MemoryMappedFile staticInfoMMF ;



            try {


                physicsMMF = MemoryMappedFile.OpenExisting("Local\\acpmf_physics");
                graphicsMMF = MemoryMappedFile.OpenExisting("Local\\acpmf_graphics");
                staticInfoMMF = MemoryMappedFile.OpenExisting("Local\\acpmf_static");


                //read physics
                using (var stream = physicsMMF.CreateViewStream())
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        var size = Marshal.SizeOf(typeof(Physics));
                        var bytes = reader.ReadBytes(size);
                        var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                        p = (Physics)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(Physics));
                        handle.Free();
                    }
                }

                //read graphics
                using (var stream = graphicsMMF.CreateViewStream())
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        var size = Marshal.SizeOf(typeof(ACSharedMemory.Graphics));
                        var bytes = reader.ReadBytes(size);
                        var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                        g = (ACSharedMemory.Graphics)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(ACSharedMemory.Graphics));
                        handle.Free();
                    }
                }

                //read static info
                using (var stream = staticInfoMMF.CreateViewStream())
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        var size = Marshal.SizeOf(typeof(StaticInfo));
                        var bytes = reader.ReadBytes(size);
                        var handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
                        i = (StaticInfo)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(StaticInfo));
                        handle.Free();
                    }
                }

                acData = new AcData(p, g, i, true);

               

            }
            catch (FileNotFoundException e) {
                DialogResult messageError = MessageBox.Show("Files not found", "Return", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (messageError == DialogResult.OK)
                {
                    
                }
            }


            return acData;

        }

        //-------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void updateData()
        {

            Task.Factory.StartNew(() =>
            {
                
                do
                {
                    acData1 = readMappedFile();
                    if (acData1.readyInfo == true)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {

                            //  Tachimetro
                            labelRpm.Text = acData1.physics.Rpms.ToString();
                            labelGear.Text = adjustGear(acData1.physics.Gear);
                            labelSpeedKmh.Text = ((int)acData1.physics.SpeedKmh).ToString() + "Km/h";

                            //tempi
                            labelBestLapTime.Text = acData1.graphics.BestTime;
                            labelLastLapTime.Text = acData1.graphics.LastTime;

                            //info gomme

                            //Front
                            labelFrontLeftPressure.Text = acData1.physics.WheelsPressure[0].ToString() + " PSI";
                            labelFrontLeftTemperature.Text = ((int)acData1.physics.TyreCoreTemperature[0]).ToString() + " °c";

                            labelFrontRightPressure.Text = acData1.physics.WheelsPressure[1].ToString() + " PSI";
                            labelFrontRightTemperature.Text = ((int)acData1.physics.TyreCoreTemperature[1]).ToString() + " °c";

                            //rear
                            labelRearLeftPressure.Text = acData1.physics.WheelsPressure[2].ToString() + " PSI";
                            labelRearLeftTemperature.Text = ((int)acData1.physics.TyreCoreTemperature[2]).ToString() + " °c";

                            labelRearRightPressure.Text = acData1.physics.WheelsPressure[3].ToString() + " PSI";
                            labelRearRightTemperature.Text = ((int)acData1.physics.TyreCoreTemperature[3]).ToString() + " °c";

                            labelMaxRPM.Text = "Max RPM: " + acData1.staticInfo.MaxRpm.ToString();


                        });
                        Thread.Sleep(10);
                    }
                } while (acData1.readyInfo == true);
            });
        }

        private string adjustGear(int gear) {

            string gearString = "";

            if ( gear  > 1 ) {
                gearString = (gear - 1).ToString();
            }
            if (gear == 0) {
                gearString = "R";
            }
            if (gear == 1) {
                gearString = "N";
            }

            return gearString;
        }
        

    }
}
