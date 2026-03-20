using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("UnitTests")]

namespace Knapsack
{
    internal class Problem
    {
        public int N { get; set; }//liczba przedmiotów
        public List<Item> Items { get; set; } = new List<Item>();//lista przedmiotów


        public Problem(int n, int seed)//konstruktor, który generuje n przedmiotów na podstawie zadanego seeda
        {
            N = n;
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                Items.Add(new Item
                {
                    Id = i,
                    Value = random.Next(1, 11), 
                    Weight = random.Next(1, 11)
                });
            }
        }

        public Result Solve(int capacity)
        {
            
            var sortedItems = Items.OrderByDescending(x => x.Ratio).ToList();
            Result result = new Result();

            foreach (var item in sortedItems)
            {
                if (result.TotalWeight + item.Weight <= capacity)
                {
                    result.ItemIds.Add(item.Id);
                    result.TotalWeight += item.Weight;
                    result.TotalValue += item.Value;
                }
            }
            return result;
        }

        public override string ToString() //zwracanie stringa z informacjami o wszystkich przedmiotach, ich id, wartości i wadze
        {
            string output = "";
            foreach (var item in Items)
            {
                output += $"no: {item.Id} v: {item.Value} w: {item.Weight}\n";
            }
            return output;
        }
    }
}