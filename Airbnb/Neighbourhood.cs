using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb
{
    class Neighbourhood
    {
        private string nbhName;
        private int numberProperties;
        private Property[] propertyList = new Property[0];

        public Neighbourhood(string theNbhName, int theNumberProperties, Property[] thePropertyList)
        {
            nbhName = theNbhName;
            numberProperties = theNumberProperties;
            propertyList = thePropertyList;
        }//end constructor

        //get method
        public string getNbhName()
        {
            return nbhName;
        }
        public int getNumberProperties()
        {
            return numberProperties;
        }
        public Property[] getPropertyList()
        {
            return propertyList;

        }

        //set method
        public void setNbhNumber(string inNbhNumber)
        {
            nbhName = inNbhNumber;
        }
        public void setNumberProperties(int inNumberProperties)
        {
            numberProperties = inNumberProperties;
        }
        public void setPropertieList(Property[] inPropertyList)
        {
            propertyList = inPropertyList;
        }
    }
}

