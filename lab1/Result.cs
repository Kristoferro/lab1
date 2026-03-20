using System.Text;

namespace Knapsack;

internal class Result
{
    public List<int> ItemIds { get; set; } = new(); //lista id przedmiotów, które zostały wybrane
    public int TotalValue { get; set; } //suma wartości wybranych przedmiotów
    public int TotalWeight { get; set; } //suma wag wybranych przedmiotów

    public override string ToString() //zwracanie stringa z informacjami o wybranych przedmiotach, ich łącznej wartości i wadze
    {
        return $"Items: {string.Join(", ", ItemIds)}\nTotal value: {TotalValue}\nTotal weight: {TotalWeight}";
    }
}