using System;
using System.Runtime.Remoting.Messaging;
using System.Xml.Schema;

namespace WestWorldTycoon
{
    public class Tile
    {
        public enum Biome
        {
            SEA, MOUNTAIN, PLAIN
        }
        private Biome biome;
        private Building building;
        
        public Tile(Biome b)
        {
            building = null;
            biome = b;
        }

        
        public Tile(Tile tile)
        {
            // BONUS
            throw new NotImplementedException();
        }

        
        public bool Build(ref long money, Building.BuildingType type)
        {
            if (biome == Biome.PLAIN)
                return false;
            else if (type == Building.BuildingType.ATTRACTION && Attraction.BUILD_COST < money)
            {
                money -= Attraction.BUILD_COST;
                return true;
            }
            else if (type == Building.BuildingType.HOUSE && House.BUILD_COST < money)
            {
                money -= House.BUILD_COST;
                return true;
            }
            else if (type == Building.BuildingType.SHOP && Shop.BUILD_COST < money)
            {
                money -= Shop.BUILD_COST;
                return true;
            }
            else
                return false;
        }


        public bool Upgrade(ref long money)
        {
            if (money > )
        }
        
        
        public long GetHousing()
        {
            throw new NotImplementedException();
        }
        
        
        public long GetAttractiveness()
        {
            throw new NotImplementedException();
        }
        
        
        public long GetIncome(long population)
        {
            throw new NotImplementedException();
        }


        public bool Destroy()
        {
            // BONUS
            throw new NotImplementedException();
        }
        

        public Biome GetBiome
        {
            get { return biome; }
        }
    }
}