List<string> videoGames = new List<string> { "Fortnite", "Warzone", "Apex", "Rocket League", "Minecraft" };

videoGames.OrderBy(x => x.Length).ToList().ForEach(game => Console.WriteLine(game));


