using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb
{
    class District
    {
        private string districtName;
        private double numberNeighbourhoods;
        private Neighbourhood[] neighbourhoodList = new Neighbourhood[0];

        public District(string theDistrictName, Double theNumberNeighbourhoods, Neighbourhood[] theNeighbourhoodList)
        {
            districtName = theDistrictName;
            numberNeighbourhoods = theNumberNeighbourhoods;
            neighbourhoodList = theNeighbourhoodList;
        } // end constructor

        //get method

        public string getDistrictName()
        {
            return districtName;
        }
        public double getNumberNeighbourhoods()
        {
            return numberNeighbourhoods;
        }
        public Neighbourhood[] getNeighbourhoodList()
        {
            return neighbourhoodList;
        }
        // set method
        public void setdistrictName(string inDisrictName)
        {
            districtName = inDisrictName;
        }
        public void setNumberNeighbourhoods(double inNumberNeighbourhoods)
        {
            numberNeighbourhoods = inNumberNeighbourhoods;
        }
        public void setNeighbourhoodList(Neighbourhood[] inNeighbourhoodList)
        {
            neighbourhoodList = inNeighbourhoodList;
        }

    }
}

