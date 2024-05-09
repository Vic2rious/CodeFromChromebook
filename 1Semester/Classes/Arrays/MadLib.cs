//Victor Ivanov 11/6

using System;

public class MadLib_VictorIvanov {
  public static void Main (string[] args){


    string[] Noun = {
        "tentacle",
        "bagpipe",
        "black Magic",
        "rainbow pants",
        "wifi router",
        "body heat",
        "swordfish",
        "russian friend Boris",
        "architecture blueprint",
        "love"
      };


    string[] FirstName = {
      "Douglass",
      "Kiara",
      "Michael",
      "Harry",
      "Murph",
      "Mowgli",
      "Madonna",
      "Britney",
      "Tu-Morrow",
      "Tokyo"
    };

    string[] LastName = {
      "Dunn",
      "Brooks",
      "Jordan",
      "Jackson",
      "Spears",
      "Beaver",
      "Bottom",
      "Fox",
      "Paprika",
      "London"
    };

    string[] Pet = {
      "otter",
      "stallion",
      "panther",
      "dung beetle",
      "fawn",
      "ape",
      "hyena",
      "seal",
      "chinchilla",
      "dromedary"
    };

    string[] PetName = {
      "Speedy",
      "Cupcake",
      "Muffin",
      "Popsicle",
      "Captian Hottie Pants",
      "Hubba Bubba",
      "Papito",
      "Chica",
      "Snowflake",
      "Dreamgirl"
    };

    string[] CityName = {
      "Gotham Village",
      "Bacon Falls",
      "Small Foot City",
      "Oniontown",
      "Dinkytown",
      "Greasyland",
      "Missipissi",
      "Old York",
      "Plain City",
      "Dunn's Village"
    };

    string[] Adjective = {
      "tactical",
      "hydraulic",
      "lizard-like",
      "freaky",
      "provoking",
      "bloodsucking",
      "wannabe",
      "melodramatic",
      "sacrificial",
      "hotheaded"
    };

    string[] VerbWithIng = {
      "morphing",
      "burning down",
      "digging up",
      "flying",
      "bouncing",
      "fading",
      "firebombing",
      "rattling",
      "singing",
      "hustling"
    };



    string name = FirstName[d10()] + " " + LastName[d10()];
    string pet = Adjective[d10()] + " " + PetName[d10()];

    Console.WriteLine("The name was " + name + ". The look was determined.");
    Console.WriteLine("It was the usual death-cold night at " + CityName[d10()] + ".");
    Console.WriteLine("Today was the day " + name + " had to face his old, old nemesis...");
    Console.WriteLine("The all mighty " + pet + ".");
    Console.WriteLine("it was a fearless and devastating " + Pet[d10()] + ", ready to obliviate any uninvited guests.");
    Console.WriteLine("Its biggest secret weapon at disposal: its " + Noun[d10()] + ".");
    Console.WriteLine("Before you know it, you would be " + VerbWithIng[d10()] + " your way straight to hell.");
    Console.WriteLine("Will " + name + " defeat the omnipotent " + pet + " or will he crumble under the pressure?");
    Console.WriteLine("Only one way to find out, subscribe to www.VictorIvanovVeryNiceStories.com to read the full story.");

  }

  public static int d10() {
    Random rnd = new Random();
    return rnd.Next(10);
  }
}
