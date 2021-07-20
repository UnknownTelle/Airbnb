using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airbnb
{
    public partial class AirBnb : Form
    {
        public static AirBnb keepList = null;
        public AirBnb()
        {
            InitializeComponent();
            keepList = this;
            AirBnbLoad();
        }

        public void AirBnbLoad()
        {
            SetUp();
        }

        private void SetUp()
        {
            //There an error when adding new rows of data, when making this again maybe use a catch statment
            StreamReader fileInput = new StreamReader("MaxFile.txt");
            Data.districtList = new District[0];
            
            while (!fileInput.EndOfStream)
            {

                //Add New Items to array
                Data.propertyList = new Property[0];
                Data.neighbourhoodList = new Neighbourhood[0];

                //Put District into an array
                string disName = fileInput.ReadLine();
                int disNum = Convert.ToInt32(fileInput.ReadLine());

                //Put Neighbourhood into an array connect to a District
                Neighbourhood[] allNeighbourhood = new Neighbourhood[disNum];
                for (int i = 0; i < disNum; i++)
                {
                    string neighName;
                    int neighNum;

                    neighName = fileInput.ReadLine();
                    neighNum = Convert.ToInt32(fileInput.ReadLine());

                    //Put Property into an array connected to the correct Neighbourhood
                    Property[] newProp = new Property[neighNum];
                    for (int j = 0; j < neighNum; j++)
                    {
                        string proID, proName, hostID, hostName, proHost, proLat,
                            proLong, proRoom, proPrice, proNight, proDay;

                        proID = fileInput.ReadLine();
                        proName = fileInput.ReadLine();
                        hostID = fileInput.ReadLine();
                        hostName = fileInput.ReadLine();
                        proHost = fileInput.ReadLine();
                        proLat = fileInput.ReadLine();
                        proLong = fileInput.ReadLine();
                        proRoom = fileInput.ReadLine();
                        proPrice = fileInput.ReadLine();
                        proNight = fileInput.ReadLine();
                        proDay = fileInput.ReadLine();

                        newProp[j] = new Property(proID, proName, hostID, hostName, Convert.ToInt32(proHost), 
                            proLat, proLong, proRoom, Convert.ToDouble(proPrice), proNight, proDay);
                        Data.propertyList = newProp;

                    }

                    int neighCurrentSize = Data.neighbourhoodList.Length;
                    Array.Resize(ref Data.neighbourhoodList, neighCurrentSize + 1);
                    Data.neighbourhoodList[neighCurrentSize] = allNeighbourhood[i] = new Neighbourhood(neighName, neighNum, Data.propertyList);


                    Data.neighbourhoodList = allNeighbourhood;
                }
                District tempDist = new District(disName, disNum, Data.neighbourhoodList);
                int maxDistrict = Data.districtList.Length;
                Array.Resize(ref Data.districtList, maxDistrict + 1);
                Data.districtList[maxDistrict] = tempDist;
            }
           
            fileInput.Close();

            //Shows Districts in a ListBox
            foreach (District i in Data.districtList)
            {
                lstDistrict.Items.Add(i.getDistrictName());
            }
        }
        //Shows in the listBox
        private void showNeighbourhood(int whichDistrict)
        {
            lstNeighbourhood.Items.Clear();
            foreach (Neighbourhood n in Data.districtList[whichDistrict].getNeighbourhoodList())
            {
                lstNeighbourhood.Items.Add(n.getNbhName());
            }
        }
        private void showProperty(int whichNeighbourhood)
        {
            lstProperty.Items.Clear();
            foreach (Property p in Data.neighbourhoodList[whichNeighbourhood].getPropertyList())
            {
                lstProperty.Items.Add(p.getPName());
            }
        }
        //Allow the connection from District ListBox to Neighbourhood ListBox
        private void lstDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            int disID = lstDistrict.SelectedIndex;
            District tempDist = Data.districtList[disID];
            Data.neighbourhoodList = tempDist.getNeighbourhoodList();
            showNeighbourhood(disID);

            //Display District Info in textboxs.
            txtDisNmae.Text = tempDist.getDistrictName();
            txtNNunber.Text = tempDist.getNumberNeighbourhoods().ToString();

            //Clear Property List 
            lstProperty.Items.Clear();
            //Clear Neighbourhood Info
            txtNName.Clear();
            txtPNumber.Clear();
            //Clear Property Info
            txtPID.Clear();
            txtPName.Clear();
            txtHID.Clear();
            txtHName.Clear();
            txtNOP.Clear();
            txtLat.Clear();
            txtLong.Clear();
            txtRType.Clear();
            txtRPrice.Clear();
            txtMinNN.Clear();
            txtN360.Clear();

        }
        //Allows the connection from Neighbourhood ListBox and then Property ListBox
        private void lstNeighbourhood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int neighID = lstNeighbourhood.SelectedIndex;
            Neighbourhood tempNeigh = Data.neighbourhoodList[neighID];
            Data.propertyList = tempNeigh.getPropertyList();
            showProperty(neighID);

            //set negighbourhood Textboxes
            txtNName.Text = tempNeigh.getNbhName();
            txtPNumber.Text = tempNeigh.getNumberProperties().ToString();
        }
        //Shows Property into its ListBox
        private void lstProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int proID = lstProperty.SelectedIndex;
            Property tempProperty = Data.propertyList[proID];

            //set Property textboxs
            txtPID.Text = tempProperty.getPID().ToString();
            txtPName.Text = tempProperty.getPName();
            txtHID.Text = tempProperty.getHostId().ToString();
            txtHName.Text = tempProperty.getHostName();
            txtNOP.Text = tempProperty.getPropertyNumber().ToString();
            txtLat.Text = tempProperty.getLatitude();
            txtLong.Text = tempProperty.getLongitude();
            txtRType.Text = tempProperty.getRoomType();
            txtRPrice.Text = tempProperty.getPrice().ToString();
            txtMinNN.Text = tempProperty.getMinNoNights().ToString();
            txtN360.Text = tempProperty.getAvailability365().ToString();

        }
        //Clear Text boxs
        private void btnClearD_Click(object sender, EventArgs e)
        {
            txtDisNmae.Text = "";
            txtNNunber.Text = "";
        }

        private void bntClearN_Click(object sender, EventArgs e)
        {
            txtNName.Text = "";
            txtPNumber.Text = "";
        }

        private void bntClearP_Click(object sender, EventArgs e)
        {
            txtPID.Text = "";
            txtPName.Text = "";
            txtHID.Text = "";
            txtHName.Text = "";
            txtNOP.Text = "";
            txtLat.Text = "";
            txtLong.Text = "";
            txtRType.Text = "";
            txtRPrice.Text = "";
            txtMinNN.Text = "";
            txtN360.Text = "";
        }

        //ADD New items to the array

        //Add District
        private void btnAddD_Click_1(object sender, EventArgs e)
        {
            string[] fileAdd = File.ReadAllLines("MaxFile.txt");
            using (var stream = new StreamWriter("MaxFile.txt"))
            {
                for (int i = 0; i <= fileAdd.Length - 1; i++)
                {
                    stream.WriteLine(fileAdd[i]);
                }
                stream.WriteLine(txtDisNmae.Text);
                stream.WriteLine("0");
               
            }

            lstDistrict.Items.Clear();
            AirBnbLoad();
            lstDistrict.SelectedIndex = 0;
        }
        //ADD Negighbourhood
        private void bntAddN_Click(object sender, EventArgs e)
        {
            string[] fileAdd = File.ReadAllLines("MaxFile.txt");
            string disAdd = txtDisNmae.Text;
            using (var stream = new StreamWriter("MaxFile.txt"))
            {
                for (int i = 0; i <= fileAdd.Length - 1; i++)
                {
                    stream.WriteLine(fileAdd[i]);

                    if (fileAdd[i] == disAdd)
                    {
                        i += 1;
                        stream.WriteLine((Convert.ToInt32(fileAdd[i]) + 1).ToString());
                        stream.WriteLine(txtNName.Text);
                        stream.WriteLine(txtPNumber.Text);
                    }
                }
            }
            lstDistrict.Items.Clear();
            AirBnbLoad();
            lstDistrict.SelectedIndex = 0;
        }
        //ADD Property
        private void btnAddP_Click(object sender, EventArgs e)
        {
            string[] fileAdd = File.ReadAllLines("MaxFile.txt");
            bool ifDis = false;
            bool ifNeigh = false;
            bool ifLineSkip = false;
            using (var stream = new StreamWriter("MaxFile.txt"))
            {
                for (int i = 0; i <= fileAdd.Length - 1; i++)
                {
                    if (!ifLineSkip)
                    {
                        stream.WriteLine(fileAdd[i]);
                    }
                    ifLineSkip = false;
                    if (fileAdd[i] == txtDisNmae.Text)
                    {
                        ifDis = true;
                    }
                    if (fileAdd[i] == txtNName.Text)
                    {
                        ifNeigh = true;
                    }
                    if (ifDis && ifNeigh)
                    {
                        ifLineSkip = true;
                        ifDis = false;
                        ifNeigh = false;

                        stream.WriteLine(Convert.ToInt32(fileAdd[i + 1]) + 1);

                        stream.WriteLine(txtPID.Text);
                        stream.WriteLine(txtPName.Text);
                        stream.WriteLine(txtHID.Text);
                        stream.WriteLine(txtHName.Text);
                        stream.WriteLine(txtNOP.Text);
                        stream.WriteLine(txtLat.Text);
                        stream.WriteLine(txtLong.Text);
                        stream.WriteLine(txtRType.Text);
                        stream.WriteLine(txtRPrice.Text);
                        stream.WriteLine(txtMinNN.Text);
                        stream.WriteLine(txtN360.Text);
                        
                    }
                }
            }
            lstDistrict.Items.Clear();
            AirBnbLoad();
            lstDistrict.SelectedIndex = 0;
        }
        //Edit Text Box and Save

        //Edit District
        private void bntEditD_Click(object sender, EventArgs e)
        {
            bool Skip = false;
            string[] fileDelete = File.ReadAllLines("MaxFile.txt");
            using (var s = new StreamWriter("MaxFile.txt"))
            {
                for (int i = 0; i <= fileDelete.Length - 1; i++)
                {
                    Skip = false;
                    if (fileDelete[i] == lstDistrict.SelectedItem.ToString())
                    {
                        Skip = true;
                    }
                    if (Skip)
                    {
                        s.WriteLine(txtDisNmae.Text);
                    }
                    else if (!Skip)
                    {
                        s.WriteLine(fileDelete[i]);
                    }
                }
            }
            lstDistrict.Items.Clear();
            AirBnbLoad();
            lstDistrict.SelectedIndex = 0;
        }
        //Edit Negighbourhood
        private void bntEditN_Click(object sender, EventArgs e)
        {
            bool Skip = false;
            string[] fileDelete = File.ReadAllLines("MaxFile.txt");
            using (var s = new StreamWriter("MaxFile.txt"))
            {
                for (int i = 0; i <= fileDelete.Length - 1; i++)
                {
                    Skip = false;
                    if (fileDelete[i] == lstNeighbourhood.SelectedItem.ToString())
                    {
                        Skip = true;
                    }
                    if (Skip)
                    {
                        s.WriteLine(txtNName.Text);
                    }
                    else if (!Skip)
                    {
                        s.WriteLine(fileDelete[i]);
                    }
                }
            }
            lstDistrict.Items.Clear();
            AirBnbLoad();
            lstDistrict.SelectedIndex = 0;
        }
    }
}

