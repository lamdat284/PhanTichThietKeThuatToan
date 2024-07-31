using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiToanBalo_CoSoLuong
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>
        {
            new Item { Value = 60, Weight = 10, Quantity = 2 },
            new Item { Value = 100, Weight = 20, Quantity = 1 },
            new Item { Value = 120, Weight = 30, Quantity = 3 }
        };

            int capacity = 50;

            var result = GreedyKnapsack(capacity, items);
            double maxValue = result.TotalValue;

            Console.WriteLine("Maximum value in Knapsack = " + maxValue);
            foreach (var item in result.ItemDetails)
            {
                Console.WriteLine($"Item with Value {item.Value} and Weight {item.Weight} - Quantity Taken: {item.QuantityTaken}");
            }

            Console.ReadKey();
        }

        public class Item
        {
            public int Value { get; set; }
            public int Weight { get; set; }
            public int Quantity { get; set; } // Property for quantity
            public double Ratio { get { return (double)Value / Weight; } }
        }

        public class KnapsackResult
        {
            public double TotalValue { get; set; }
            public List<ItemDetails> ItemDetails { get; set; } = new List<ItemDetails>();
        }

        public class ItemDetails
        {
            public int Value { get; set; }
            public int Weight { get; set; }
            public int QuantityTaken { get; set; }
        }

        public static KnapsackResult GreedyKnapsack(int capacity, List<Item> items)
        {
            // Sort items by value-to-weight ratio in descending order
            items.Sort((x, y) => y.Ratio.CompareTo(x.Ratio));

            double totalValue = 0;
            int currentWeight = 0;

            var result = new KnapsackResult();

            foreach (var item in items)
            {
                if (currentWeight + item.Weight <= capacity)
                {
                    // Calculate number of items that can be taken
                    int maxItemCount = Math.Min(item.Quantity, (capacity - currentWeight) / item.Weight);
                    currentWeight += maxItemCount * item.Weight;
                    totalValue += maxItemCount * item.Value;

                    result.ItemDetails.Add(new ItemDetails
                    {
                        Value = item.Value,
                        Weight = item.Weight,
                        QuantityTaken = maxItemCount
                    });
                }
                else
                {
                    // Add the fractional part of the item if the knapsack is not full
                    int remainingWeight = capacity - currentWeight;
                    double fraction = (double)remainingWeight / item.Weight;
                    totalValue += fraction * item.Value;

                    result.ItemDetails.Add(new ItemDetails
                    {
                        Value = item.Value,
                        Weight = item.Weight,
                        QuantityTaken = (int)Math.Floor(fraction * item.Quantity)
                    });

                    break;
                }
            }

            result.TotalValue = totalValue;
            return result;
        }
    }
}
