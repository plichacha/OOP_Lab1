using System;

namespace VirtualItemShop
{
    public class VirtualItem
    {
        public string name;
        public ItemRarity rarity = ItemRarity.COMMON;
        public double price;
        public int durability;
        public bool isTradable;
        private int usesCount = 0;
        private DateTime createdDate;

        public void SetCreatedDate()
        {
            createdDate = DateTime.Now;
        }

        public DateTime GetCreatedDate()
        {
            return createdDate;
        }

        public bool Use()
        {
            if (durability < 10) return false;
            durability -= 10;
            usesCount++;
            return true;
        }

        public bool Repair(int amount)
        {
            if (durability == 100) return false;
            if (amount <= 0) return false;
            durability += amount;
            if (durability > 100) durability = 100;
            return true;
        }

        public int GetUsesCount()
        {
            return usesCount;
        }

        public bool Enchant()
        {
            if (rarity == ItemRarity.MYTHIC) return false;
            rarity++;
            return true;
        }

        public double CalculateSellPrice()
        {
            double rarityMultiplier = 1 + (int)rarity * 0.5;
            double durabilityFactor = durability / 100.0;
            return Math.Round(price * rarityMultiplier * durabilityFactor, 2);
        }
    }
}