namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    /// <summary>
    /// Configuration Class - Product Entity
    /// </summary>
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<Product> builder)
        { 
            var products = new List<Product>();
            var random = new Random();

            var names = Names();
            var cashRegisterNames = CashRegisterNames();
            var codes = Codes();
            var itemGroups = ItemGroups();

            for (int i = 0; i < 150; i++)
            {
                var purchasePrice = random.Next(1, 301);
                var salePrice = purchasePrice + 0.20M * purchasePrice;

                var product = new Product()
                {
                    Id = i + 1,
                    Name = names[i],
                    ArticleNumber = i + 1,
                    NomenclatureNumber = i + 1,
                    CashRegisterName = cashRegisterNames[i],
                    CodeForScales = codes[i],
                    Description = $"Description about product - {names[i]}",
                    ItemGroupId = itemGroups[i],
                    PurchasePrice = purchasePrice,
                    Quantity = random.Next(0, 201),
                    SalePrice = salePrice
                };

                products.Add(product);
            }

            builder.HasData(products);
        }

        private static List<string> Names()
            => new List<string>()
            {
                "Chocolate Chip Cookie Dough Ice Cream",
                "Vanilla Bean Ice Cream",
                "Strawberry Swirl Ice Cream",
                "Mint Chocolate Chip Ice Cream",
                "Cookies and Cream Ice Cream",
                "Rocky Road Ice Cream",
                "Neapolitan Ice Cream",
                "Butter Pecan Ice Cream",
                "Pistachio Ice Cream",
                "Salted Caramel Ice Cream",

                "Coca-Cola Classic",
                "Pepsi Cola",
                "Sprite Lemon-Lime Soda",
                "Fanta Orange Soda",
                "Mountain Dew Citrus Soda",
                "Dr. Pepper Soda",
                "Canada Dry Ginger Ale",
                "7UP Lemon-Lime Soda",
                "Root Beer Soda",
                "Red Bull Energy Drink",

                "Budweiser Lager Beer", 
                "Jack Daniel's Tennessee Whiskey",
                "Grey Goose Vodka",
                "Captain Morgan Spiced Rum",
                "Jose Cuervo Tequila",
                "Chardonnay White Wine",
                "Pinot Noir Red Wine",
                "Moet & Chandon Champagne",
                "Jameson Irish Whiskey",
                "Absolut Citron Vodka",

                "Whole Milk",
                "2% Reduced Fat Milk",
                "Skim Milk",
                "Chocolate Milk",
                "Half and Half Cream",
                "Heavy Cream",
                "Unsalted Butter",
                "Salted Butter",
                "Plain Yogurt",
                "Greek Yogurt",

                "Beef Hot Dogs",
                "Pork Breakfast Sausages",
                "Chicken Apple Sausages",
                "Italian Style Sausages",
                "Bratwurst Sausages",
                "Chorizo Sausages",
                "Andouille Sausages",
                "Kielbasa Sausages",
                "Vegan Plant-Based Sausages",
                "Maple Glazed Sausage Links",

                "Ultra Fresh Scented Laundry Detergent",
                "Fabric Softener Sheets",
                "Stain Remover Spray",
                "Color-Safe Bleach",
                "Liquid Fabric Softener",
                "Fragrance-Free Laundry Pods",
                "Wool Dryer Balls",
                "Oxygen Stain Remover",
                "Laundry Pre-Treatment Spray",
                "Delicate Wash Laundry Detergent",

                "Roasted Salted Mixed Nuts",
                "Honey Glazed Cashews",
                "Spicy Cajun Almonds",
                "BBQ Flavored Peanuts",
                "Chocolate Covered Hazelnuts",
                "Sea Salt Pistachios",
                "Smoked Almond Snack Mix",
                "Chili Lime Cashews",
                "Wasabi Soy Almonds",
                "Maple Pecan Trail Mix",

                "Premium Menthol Cigarettes",
                "Classic Tobacco Blend Cigarettes",
                "Slims Light Cigarettes",
                "Menthol Gold Cigarettes",
                "Full Flavor Cigarettes",
                "Menthol Silver Cigarettes",
                "Ultra Light Cigarettes",
                "Regular Filtered Cigarettes",
                "Menthol Blue Cigarettes",
                "Menthol Green Cigarettes",

                "Whole Wheat Sandwich Bread",
                "French Baguette",
                "Artisanal Sourdough Loaf",
                "Multigrain Bread",
                "Rye Bread",
                "Gluten-Free White Bread",
                "Cinnamon Raisin Bread",
                "Italian Ciabatta Loaf",
                "Pumpernickel Bread",
                "Bagels Assortment Pack",

                "Organic Gala Apples",
                "Fresh Strawberries",
                "Green Seedless Grapes",
                "Ripe Avocados",
                "Sweet Juicy Oranges",
                "Crisp Red Delicious Apples",
                "Fresh Raspberries",
                "Crisp Green Granny Smith Apples",
                "Juicy Clementines",
                "Organic Bananas",
                "Plump Blueberries",
                "Ripe Red Tomatoes",
                "Vibrant Red Bell Peppers",
                "Crisp Green Cucumbers",
                "Fresh Broccoli Crowns",
                "Sweet Juicy Peaches",
                "Crisp Iceberg Lettuce",
                "Ripe Yellow Bananas",
                "Fresh Spinach Leaves",
                "Crisp Carrots",
                "Fresh Lemons",
                "Ripe Mangos",
                "Sweet Red Cherries",
                "Crisp Celery Sticks",
                "Juicy Watermelon",
                "Green Zucchini Squash",
                "Sweet Pineapple Chunks",
                "Fresh Kiwi Fruit",
                "Crisp Radishes",
                "Ripe Honeydew Melon",
                "Fresh Green Beans",
                "Crisp Iceberg Lettuce",
                "Ripe Nectarines",
                "Sweet Red Grapes",
                "Crisp Yellow Squash",
                "Fresh Asparagus Spears",
                "Juicy Blackberries",
                "Ripe Apricots",
                "Sweet Strawberries",
                "Crisp Cauliflower Florets",
                "Ripe Papaya",
                "Fresh Artichokes",
                "Sweet Cantaloupe",
                "Ripe Pears",
                "Crisp Green Peas",
                "Juicy Grapefruit",
                "Ripe Plums",
                "Crisp Red Radishes",
                "Fresh Beets",
                "Sweet Red Peppers",
                "Ripe Tangerines",
                "Crisp Corn on the Cob",
                "Fresh Brussels Sprouts",
                "Ripe Lychees",
                "Crisp Bok Choy",
                "Juicy Pomegranates",
                "Ripe Persimmons",
                "Sweet Figs",
                "Crisp Jicama",
                "Fresh Baby Spinach",
            };  

        private static List<string> CashRegisterNames()
            => new List<string>()
            {
                "Chocolate Ice Cream",
                "Vanilla Ice Cream",
                "Strawberry Ice Cream",
                "Mint Ice Cream",
                "Cookies Ice Cream",
                "Rocky Ice Cream",
                "Neapolitan Ice Cream",
                "Butter Ice Cream",
                "Pistachio Ice Cream",
                "Salted Ice Cream",


                "Coca-Cola Classic",
                "Pepsi Cola",
                "Sprite Soda",
                "Fanta Soda",
                "Mountain Soda",
                "Dr. Pepper Soda",
                "Canada Ale",
                "7UP Lemon-Lime Soda",
                "Root Beer Soda",
                "Red Bull Drink",

                "Budweiser Beer",
                "Jack Whiskey",
                "Grey Goose Vodka",
                "Captain Rum",
                "Jose Tequila",
                "Chardonnay Wine",
                "Pinot Wine",
                "Moet & Chandon Champagne",
                "Jameson Whiskey",
                "Absolut Vodka",

                "Whole Milk",
                "2% Reduced Fat Milk",
                "Skim Milk",
                "Chocolate Milk",
                "Half and Half Cream",
                "Heavy Cream",
                "Unsalted Butter",
                "Salted Butter",
                "Plain Yogurt",
                "Greek Yogurt",

                "Beef Dogs",
                "Pork Sausages",
                "Chicken Sausages",
                "Italian Sausages",
                "Bratwurst Sausages",
                "Chorizo Sausages",
                "Andouille Sausages",
                "Kielbasa Sausages",
                "Vegan Sausages",
                "Maple Sausage",

                "Ultra Detergent",
                "Fabric Sheets",
                "Stain Spray",
                "Color-Safe Bleach",
                "Liquid Softener",
                "Fragrance-Free Pods",
                "Wool Balls",
                "Oxygen Remover",
                "Laundry Spray",
                "Delicate Detergent",

                "Roasted  Nuts",
                "Honey Cashews",
                "Spicy Almonds",
                "BBQ Peanuts",
                "Chocolate Hazelnuts",
                "Sea Pistachios",
                "Smoked Almond Snack Mix",
                "Chili Lime Cashews",
                "Wasabi Almonds",
                "Maple Pecan Trail Mix",

                "Premium Cigarettes",
                "Classic Blend Cigarettes",
                "Slims Cigarettes",
                "Menthol Cigarettes",
                "Full Cigarettes",
                "Menthol Cigarettes",
                "Ultra Cigarettes",
                "Regular Filtered Cigarettes",
                "Menthol Blue Cigarettes",
                "Menthol Green Cigarettes",

                "Whole Bread",
                "French Baguette",
                "Artisanal Loaf",
                "Multigrain Bread",
                "Rye Bread",
                "Gluten-Free Bread",
                "Cinnamon Bread",
                "Italian Loaf",
                "Pumpernickel Bread",
                "Bagels Pack",

                "Organic Gala Apples",
                "Fresh Strawberries",
                "Green Grapes",
                "Ripe Avocados",
                "Sweet Juicy Oranges",
                "Crisp Apples",
                "Fresh Raspberries",
                "Crisp Apples",
                "Juicy Clementines",
                "Organic Bananas",
                "Plump Blueberries",
                "Ripe Red Tomatoes",
                "Vibrant Red Bell Peppers",
                "Crisp Green Cucumbers",
                "Fresh Broccoli Crowns",
                "Sweet Juicy Peaches",
                "Crisp Iceberg Lettuce",
                "Ripe Yellow Bananas",
                "Fresh Spinach Leaves",
                "Crisp Carrots",
                "Fresh Lemons",
                "Ripe Mangos",
                "Sweet Red Cherries",
                "Crisp Celery Sticks",
                "Juicy Watermelon",
                "Green Zucchini Squash",
                "Sweet Pineapple Chunks",
                "Fresh Kiwi Fruit",
                "Crisp Radishes",
                "Ripe Honeydew Melon",
                "Fresh Green Beans",
                "Crisp Iceberg Lettuce",
                "Ripe Nectarines",
                "Sweet Grapes",
                "Crisp Squash",
                "Fresh Asparagus Spears",
                "Juicy Blackberries",
                "Ripe Apricots",
                "Sweet Strawberries",
                "Crisp Cauliflower Florets",
                "Ripe Papaya",
                "Fresh Artichokes",
                "Sweet Cantaloupe",
                "Ripe Pears",
                "Crisp Green Peas",
                "Juicy Grapefruit",
                "Ripe Plums",
                "Crisp Red Radishes",
                "Fresh Beets",
                "Sweet Red Peppers",
                "Ripe Tangerines",
                "Crisp Corn on the Cob",
                "Fresh Brussels Sprouts",
                "Ripe Lychees",
                "Crisp Bok Choy",
                "Juicy Pomegranates",
                "Ripe Persimmons",
                "Sweet Figs",
                "Crisp Jicama",
                "Fresh Baby Spinach",
            };

        private static List<int> Codes()
            => new List<int>()
            {
                0,0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,0,
                1,2,3,4,5,6,7,8,9,10,
                11,12,13,14,15,16,17,18,19,20,
                0,0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,0,
                0,0,0,0,0,0,0,0,0,0,
                21,22,23,24,25,26,27,28,29,30,
                31,32,33,34,35,36,37,38,39,40,
                41,42,43,44,45,46,47,48,49,50,
                51,52,53,54,55,56,57,58,59,60,
                61,62,63,64,65,66,67,68,69,70,
                71,72,73,74,75,76,77,78,79,80
            };

        private static List<int> ItemGroups()
            => new List<int>()
            {
                1,1,1,1,1,1,1,1,1,1,
                2,2,2,2,2,2,2,2,2,2,
                3,3,3,3,3,3,3,3,3,3,
                4,4,4,4,4,4,4,4,4,4,
                5,5,5,5,5,5,5,5,5,5,
                6,6,6,6,6,6,6,6,6,6,
                7,7,7,7,7,7,7,7,7,7,
                8,8,8,8,8,8,8,8,8,8,
                9,9,9,9,9,9,9,9,9,9,
                10,10,10,10,10,10,10,10,10,10,
                10,10,10,10,10,10,10,10,10,10,
                10,10,10,10,10,10,10,10,10,10,
                10,10,10,10,10,10,10,10,10,10,
                10,10,10,10,10,10,10,10,10,10,
                10,10,10,10,10,10,10,10,10,10
            };
    }
}
