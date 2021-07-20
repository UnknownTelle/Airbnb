using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb
{
    class Property
    {
        private string pID;
        private string pName;
        private string hostID;
        private string hostName;
        private int propertyNumber;
        private string latitude;
        private string longitude;
        private string roomType;
        private double price;
        private string minNoNights;
        private string availability365;

        public Property(string thePID, string thePName, string theHostId,
            string theHostName, int thePropertyNumber, string theLatitude,
            string theLongitude, string theRoomType, double thePrice,
            string theMinNoNights, string theAvailability365)
        {
            pID = thePID;
            pName = thePName;
            hostID = theHostId;
            hostName = theHostName;
            propertyNumber = thePropertyNumber;
            latitude = theLatitude;
            longitude = theLongitude;
            roomType = theRoomType;
            price = thePrice;
            minNoNights = theMinNoNights;
            availability365 = theAvailability365;
        }
        //end constructor

        //get method
        public string getPID()
        {
            return pID;
        }
        public string getPName()
        {
            return pName;
        }
        public string getHostId()
        {
            return hostID;
        }
        public string getHostName()
        {
            return hostName;
        }
        public int getPropertyNumber()
        {
            return propertyNumber;
        }
        public string getLatitude()
        {
            return latitude;
        }
        public string getLongitude()
        {
            return longitude;
        }
        public string getRoomType()
        {
            return roomType;
        }
        public double getPrice()
        {
            return price;
        }
        public string getMinNoNights()
        {
            return minNoNights;
        }
        public string getAvailability365()
        {
            return availability365;
        }

        // set methods
        public void setPID(string inPID)
        {
            pID = inPID;
        }
        public void setPName(string inPName)
        {
            pName = inPName;
        }
        public void setHostId(string inHostId)
        {
            hostID = inHostId;
        }
        public void setHostName(string inHostName)
        {
            hostName = inHostName;
        }
        public void setPropertyNumber(int inPropertyNumber)
        {
            propertyNumber = inPropertyNumber;
        }
        public void setLatitude(string inLatitude)
        {
            latitude = inLatitude;
        }
        public void setLongitude(string inLongitude)
        {
            longitude = inLongitude;
        }
        public void setRoomType(string inRoomType)
        {
            roomType = inRoomType;
        }
        public void setPrice(double inPrice)
        {
            price = inPrice;
        }
        public void setMinNoNights(string inMinNoNights)
        {
            minNoNights = inMinNoNights;
        }
        public void setAvailability365(string inAvailability365)
        {
            availability365 = inAvailability365;
        }
    }

}

