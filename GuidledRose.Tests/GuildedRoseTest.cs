using FluentAssertions;
using GuildedRose;

namespace GuidledRose.Tests;

public class GuildedRoseTest
{
    [Fact]
    public void foo()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        GildedRose app = new GildedRose(Items);
        app.UpdateQuality();
        Items[0].Name.Should().Be("fixme");
    }
}