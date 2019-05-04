using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using Json;
namespace SuperDuck
{
    class SolidWorksController
    {
        private ISldWorks swApp;

        private ModelDoc2 openPart;
        
        private List<GlobalVariable> globals;

        private String configFile;

        public SolidWorksController(ISldWorks app)
        {
            globals = new List<GlobalVariable>();
            openPart = default(ModelDoc2);
            swApp = app;
            //string input = Interaction.InputBox("Enter the path of the JSON configuration file", SolidWorksMacro.appHeader, "Default", -1, -1);
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Choose JSON config tile",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "JSON files (*.json) | All files (*.*)",
                RestoreDirectory = true,
                
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                configFile = openFileDialog1.FileName;
            }
            using (StreamReader file = File.OpenText(configFile))
            {
            }
        }
    }
}
