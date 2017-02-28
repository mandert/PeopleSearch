using PeopleSearchDatabase.Models;

namespace PeopleSearchDatabase.Migrations
{
    using System.Data.Entity.Migrations;
    
    internal sealed class Configuration : DbMigrationsConfiguration<PeopleSearch>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PeopleSearch context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            using (Methods methods = new Methods(context, 10))
            {
                Person person0 = new Person()
                {
                    FirstName = "Malcolm",
                    LastName = "Singleton",
                    Age = 35,
                    Interests = "Jogging, Birdwatching, Horseback riding, Rugby league football, Knitting, Whale watching, Blacksmithing, Jewelry making, Climbing, Hooping, Baseball, Color guard, Base jumping, Auto racing, and Darts.",
                    PictureUrl = "https://photos.peterhurley.com/sites/default/files/photos/2015/03/30/william%C2%A9peterhurley.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "79006 Prairie St N",
                        StreetLine2 = "Apt 88170",
                        City = "Somerset",
                        State = "PA",
                        Zip = "15501"
                    }
                };
                methods.AddPersonWithAddress(person0);

                Person person1 = new Person()
                {
                    FirstName = "Genesis",
                    LastName = "Holman",
                    Age = 40,
                    Interests = "Beach volleyball, Knitting, Australian rules football, Poi, Skimboarding, Darts, Air sports, Hiking, Larping, Blacksmithing, Golfing, Driving, Hunting, Blacksmithing, Electronics, Archery, Scouting, Baseball, Sea glass collecting, and Insect collecting.",
                    PictureUrl = "https://www.stayathomemum.com.au/cache/860x380-0/wp-content/uploads/2016/03/Alexis-Bledel-CelebHealthy_com-e1458614938577.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "2149 Regent Dr",
                        StreetLine2 = "PO Box 1969",
                        City = "Fpo",
                        State = "AE",
                        Zip = "9621"
                    }
                };
                methods.AddPersonWithAddress(person1);

                Person person2 = new Person()
                {
                    FirstName = "Galen",
                    LastName = "Hutchinson",
                    Age = 31,
                    Interests = "Taekwondo, Baseball, Vintage cars, Sea glass collecting, Glassblowing, Trainspotting, Cycling, Creative writing, Metal detecting, Parkour, Lacrosse, Rappelling, Beekeeping, Animal fancy, Tatting, Dance, Curling, and Reading.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/83/5a/56/835a564ecadfdc02aaabcc577cbc037e.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "34624 Edgewood Cir",
                        StreetLine2 = "Apt 38280",
                        City = "Starke",
                        State = "FL",
                        Zip = "32091"
                    }
                };
                methods.AddPersonWithAddress(person2);

                Person person3 = new Person()
                {
                    FirstName = "Charisse",
                    LastName = "Kramer",
                    Age = 28,
                    Interests = "Flying disc, Airsoft, Paintball, and Cabaret.",
                    PictureUrl = "http://www.maxbrandinphotography.com/wp-content/uploads/2013/06/B0C1271_WEB_Crop_LosAngeles_Kids_Actor_Headshots.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "68423 Walter St",
                        StreetLine2 = "PO Box 17758",
                        City = "Spring valley",
                        State = "WI",
                        Zip = "54767"
                    }
                };
                methods.AddPersonWithAddress(person3);

                Person person4 = new Person()
                {
                    FirstName = "Houston",
                    LastName = "Cole",
                    Age = 47,
                    Interests = "Skimboarding, Roller skating, Knife throwing, Flag football, Die-cast toy, Horseback riding, Boxing, Cross-stitch, Coloring, Breakdancing, Aircraft spotting, Herping, Sea glass collecting, Metal detecting, Whale watching, Fishkeeping, and Shortwave listening.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/236x/09/ef/99/09ef999928ff6571cb9d76d7e4285911.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "89489 Dem Con Dr",
                        StreetLine2 = "Apt 17671",
                        City = "Topeka",
                        State = "KS",
                        Zip = "66605"
                    }
                };
                methods.AddPersonWithAddress(person4);

                Person person5 = new Person()
                {
                    FirstName = "Earline",
                    LastName = "Irwin",
                    Age = 41,
                    Interests = "Mahjong, and Volleyball.",
                    PictureUrl = "https://www.stayathomemum.com.au/cache/860x380-0/wp-content/uploads/2016/03/Alexis-Bledel-CelebHealthy_com-e1458614938577.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "23487 Boulder Pointe",
                        StreetLine2 = "",
                        City = "Omaha",
                        State = "NE",
                        Zip = "68144"
                    }
                };
                methods.AddPersonWithAddress(person5);

                Person person6 = new Person()
                {
                    FirstName = "Emmitt",
                    LastName = "Frazier",
                    Age = 30,
                    Interests = "Speed skating, Knife making, Seashell collecting, Watching television, Comic book collecting, Foreign language learning, Kayaking, Sand art, Graffiti, Soccer, Knapping, and Brazilian jiu-jitsu.",
                    PictureUrl = "https://static1.squarespace.com/static/571127b455598628154efb9b/572a3f4127d4bd1977b9608d/572a419cab48deecfc04f6fb/1462387104838/creative-dating-headshot-dramatic-lighting.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "42027 Roundhouse Cir S",
                        StreetLine2 = "Apt 17209",
                        City = "Tchula",
                        State = "MS",
                        Zip = "39169"
                    }
                };
                methods.AddPersonWithAddress(person6);

                Person person7 = new Person()
                {
                    FirstName = "Joanna",
                    LastName = "Johnson",
                    Age = 36,
                    Interests = "Book restoration, Plastic embedding, Amateur radio, Scuba diving, Model building, Crossword puzzles, Tour skating, Jewelry making, and Lego building.",
                    PictureUrl = "http://meggyhaitrang.com/wp-content/uploads/2012/12/Meggy-Alternate-Headshot.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "90224 Tyrone Dr S",
                        StreetLine2 = "PO Box 46989",
                        City = "Harrisville",
                        State = "OH",
                        Zip = "43974"
                    }
                };
                methods.AddPersonWithAddress(person7);

                Person person8 = new Person()
                {
                    FirstName = "Alphonso",
                    LastName = "Alvarez",
                    Age = 25,
                    Interests = "Video game collecting, Acting, Poker, Surfing, Speed skating, Writing, Pigeon racing, and Speed skating.",
                    PictureUrl = "https://pbs.twimg.com/media/BjD44BBCUAARinE.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "24259 Charismatic Dr",
                        StreetLine2 = "Apt 6576",
                        City = "Breeding",
                        State = "KY",
                        Zip = "42715"
                    }
                };
                methods.AddPersonWithAddress(person8);

                Person person9 = new Person()
                {
                    FirstName = "Melba",
                    LastName = "Adams",
                    Age = 28,
                    Interests = "Traveling, Jogging, Baseball, Mineral collecting, Equestrianism, Juggling, Fishkeeping, Book collecting, Climbing, Stone collecting, Kitesurfing, Volleyball, Photography, and Surfing.",
                    PictureUrl = "http://www.maxbrandinphotography.com/wp-content/uploads/2013/06/B0C1271_WEB_Crop_LosAngeles_Kids_Actor_Headshots.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "17345 Old Carriage Rd",
                        StreetLine2 = "",
                        City = "Tacoma",
                        State = "WA",
                        Zip = "98445"
                    }
                };
                methods.AddPersonWithAddress(person9);

                Person person10 = new Person()
                {
                    FirstName = "Anthony",
                    LastName = "Dale",
                    Age = 41,
                    Interests = "Meteorology, Auto audiophilia, Lacrosse, Antiquities, Jogging, Gardening, Board games, Vintage cars, Listening to music, Candle making, Skateboarding, Table tennis, Radio-controlled car racing, Volleyball, Skiing, Birdwatching, Auto audiophilia, Quilting, and Lacrosse.",
                    PictureUrl = "https://photos.peterhurley.com/sites/default/files/photos/2015/03/30/william%C2%A9peterhurley.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "3775 Berkshire Cir",
                        StreetLine2 = "Apt 60644",
                        City = "Spring garden",
                        State = "AL",
                        Zip = "36275"
                    }
                };
                methods.AddPersonWithAddress(person10);

                Person person11 = new Person()
                {
                    FirstName = "Etsuko",
                    LastName = "Humphrey",
                    Age = 45,
                    Interests = "Deep web, Skiing, Baseball, Leather crafting, Surfing, Whale watching, Dance, Watching movies, Gaming (tabletop games and role-playing games), and Metal detecting.",
                    PictureUrl = "http://5146-presscdn-25-73.pagely.netdna-cdn.com/wp-content/uploads/2012/12/headshot-headshots-actor-headshots-actors-headshots-london-michael-wharely-137.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "63466 County Road 14",
                        StreetLine2 = "Apt 33130",
                        City = "Somerset",
                        State = "KY",
                        Zip = "42501"
                    }
                };
                methods.AddPersonWithAddress(person11);

                Person person12 = new Person()
                {
                    FirstName = "Dan",
                    LastName = "Miller",
                    Age = 49,
                    Interests = "Judo, Graffiti, Scuba diving, Hunting, Gymnastics, Baseball, and Juggling.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/b1/79/39/b17939a084e26d4415edcd3bde70f4db.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "66628 Jocko Ct",
                        StreetLine2 = "PO Box 94408",
                        City = "Union city",
                        State = "NJ",
                        Zip = "7087"
                    }
                };
                methods.AddPersonWithAddress(person12);

                Person person13 = new Person()
                {
                    FirstName = "Jaleesa",
                    LastName = "Carr",
                    Age = 36,
                    Interests = "Motor sports, Record collecting, Vintage cars, Chess, Freestyle football, Knife throwing, Trainspotting, Vintage cars, Cooking, Stone skipping, Web surfing, Fossil hunting, Breakdancing, and Volleyball.",
                    PictureUrl = "http://www.jordanmatter.com/images/Tara_Westwood.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "88583 Mooers Ave",
                        StreetLine2 = "PO Box 47811",
                        City = "Columbus",
                        State = "OH",
                        Zip = "43085"
                    }
                };
                methods.AddPersonWithAddress(person13);

                Person person14 = new Person()
                {
                    FirstName = "Elliott",
                    LastName = "Saunders",
                    Age = 28,
                    Interests = "Mountain biking, Singing, Slacklining, Stone skipping, Color guard, Slacklining, Climbing, Lacrosse, and Puzzles.",
                    PictureUrl = "https://static1.squarespace.com/static/571127b455598628154efb9b/572a3f4127d4bd1977b9608d/572a419cab48deecfc04f6fb/1462387104838/creative-dating-headshot-dramatic-lighting.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "46979 Tiflawn Ct",
                        StreetLine2 = "Apt 51135",
                        City = "Hatton",
                        State = "ND",
                        Zip = "58240"
                    }
                };
                methods.AddPersonWithAddress(person14);

                Person person15 = new Person()
                {
                    FirstName = "Adah",
                    LastName = "Campbell",
                    Age = 33,
                    Interests = "Skateboarding, Foreign language learning, Coin collecting, Chess, Tennis, Philately, Motor sports, Comic book collecting, Homebrewing, Herping, Rugby, Baseball, Lockpicking, Scouting, Pet, Taekwondo, and Weightlifting.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/8c/ea/f5/8ceaf526c1586f79db47cc80b2da7664.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "56190 Adams St S",
                        StreetLine2 = "Apt 22956",
                        City = "Sacramento",
                        State = "CA",
                        Zip = "95824"
                    }
                };
                methods.AddPersonWithAddress(person15);

                Person person16 = new Person()
                {
                    FirstName = "Bret",
                    LastName = "Wright",
                    Age = 43,
                    Interests = "High-powered rocketry, Movie and movie memorabilia collecting, and Coloring.",
                    PictureUrl = "https://2d3z3x4e2xrx130kvm2hxdsp-wpengine.netdna-ssl.com/wp-content/uploads/2015/04/kalama_epstein_084r.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "65203 Hauer Trail",
                        StreetLine2 = "PO Box 58459",
                        City = "Paris",
                        State = "TX",
                        Zip = "75461"
                    }
                };
                methods.AddPersonWithAddress(person16);

                Person person17 = new Person()
                {
                    FirstName = "Marianna",
                    LastName = "Bender",
                    Age = 39,
                    Interests = "Road biking, Shooting sport, Mineral collecting, Association football, Hunting, and Disc golf.",
                    PictureUrl = "http://www.maxbrandinphotography.com/wp-content/uploads/2013/06/B0C1271_WEB_Crop_LosAngeles_Kids_Actor_Headshots.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "82766 Parkway Ave",
                        StreetLine2 = "PO Box 67471",
                        City = "Newburg",
                        State = "ND",
                        Zip = "58762"
                    }
                };
                methods.AddPersonWithAddress(person17);

                Person person18 = new Person()
                {
                    FirstName = "Steve",
                    LastName = "Doyle",
                    Age = 40,
                    Interests = "Shooting, Sand art, Skiing, Seashell collecting, Acting, Ultimate disc, Fishkeeping, Hooping, Beach volleyball, Kite flying, Observation hobbies, Bodybuilding, Shooting sport, Drawing, Badminton, Kart racing, and Tennis.",
                    PictureUrl = "http://www.imageworksnyc.com/images/NYC%20Headshots.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "78742 Steve Dr",
                        StreetLine2 = "Apt 33660",
                        City = "Memphis",
                        State = "TN",
                        Zip = "38101"
                    }
                };
                methods.AddPersonWithAddress(person18);

                Person person19 = new Person()
                {
                    FirstName = "Alease",
                    LastName = "Emerson",
                    Age = 36,
                    Interests = "Skimboarding, Art collecting, Cosplaying, Board sports, Hiking/backpacking, Chess, Curling, Field hockey, Mineral collecting, Marbles, Lego building, Rock balancing, and Knitting.",
                    PictureUrl = "http://www.eb-img.com/wp-content/grand-media/image/EB-img.Actors.Headshots.Acting.Spotlight.London.Portraits2_0035.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "34986 Hampton Ln",
                        StreetLine2 = "Apt 27969",
                        City = "Reno",
                        State = "NV",
                        Zip = "89570"
                    }
                };
                methods.AddPersonWithAddress(person19);

                Person person20 = new Person()
                {
                    FirstName = "Frankie",
                    LastName = "Trujillo",
                    Age = 49,
                    Interests = "Road biking, Australian rules football, Meteorology, Sand art, Table tennis, Homebrewing, Gunsmithing, Basketball, Exhibition drill, Letterboxing, Handball, Woodworking, Orienteering, Badminton, Horseback riding, and Watching television.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/83/5a/56/835a564ecadfdc02aaabcc577cbc037e.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "48494 Larkspur Ct",
                        StreetLine2 = "",
                        City = "Duck creek village",
                        State = "UT",
                        Zip = "84762"
                    }
                };
                methods.AddPersonWithAddress(person20);

                Person person21 = new Person()
                {
                    FirstName = "Jae",
                    LastName = "Padilla",
                    Age = 27,
                    Interests = "Reading, Mountain biking, Scrapbooking, Sailing, Slacklining, Rugby league football, Drama, Animal fancy, Kart racing, Cheerleading, and Beach volleyball.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/3e/ea/c3/3eeac35304e9a9aef990eef8a7d39f57.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "55038 Clearview Dr",
                        StreetLine2 = "PO Box 96909",
                        City = "Alpine",
                        State = "TN",
                        Zip = "38543"
                    }
                };
                methods.AddPersonWithAddress(person21);

                Person person22 = new Person()
                {
                    FirstName = "Neal",
                    LastName = "Acevedo",
                    Age = 49,
                    Interests = "Flying, Collection hobbies, Rugby league football, Skateboarding, Fencing, Climbing, Model aircraft, Ice skating, Flying disc, 3d printing, Kayaking, Skimboarding, Insect collecting, Gongoozling, Element collecting, Gongoozling, and Shopping.",
                    PictureUrl = "https://pbs.twimg.com/media/BjD44BBCUAARinE.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "72262 Crossings Blvd",
                        StreetLine2 = "Apt 5725",
                        City = "Baltimore",
                        State = "MD",
                        Zip = "21223"
                    }
                };
                methods.AddPersonWithAddress(person22);

                Person person23 = new Person()
                {
                    FirstName = "Lakisha",
                    LastName = "Monroe",
                    Age = 31,
                    Interests = "People watching, Element collecting, and Weightlifting.",
                    PictureUrl = "http://www.cidermill-photography.co.uk/wp-content/uploads/2012/10/bristol-actors-headshot-101.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "46479 Madison St S",
                        StreetLine2 = "",
                        City = "Faxon",
                        State = "OK",
                        Zip = "73540"
                    }
                };
                methods.AddPersonWithAddress(person23);

                Person person24 = new Person()
                {
                    FirstName = "Lauren",
                    LastName = "Fleming",
                    Age = 36,
                    Interests = "Skateboarding, Crocheting, Boxing, Vintage cars, Drama, Board games, Tatting, Magic, Climbing, Baseball, Rappelling, Birdwatching, Amateur radio, and Beekeeping.",
                    PictureUrl = "https://cdn.photographyproject.com.au/wp-content/uploads/2013/04/corporate-headshot.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "19124 Rock Pl",
                        StreetLine2 = "",
                        City = "Saint johnsbury center",
                        State = "VT",
                        Zip = "5863"
                    }
                };
                methods.AddPersonWithAddress(person24);

                Person person25 = new Person()
                {
                    FirstName = "Maybelle",
                    LastName = "Moses",
                    Age = 40,
                    Interests = "Card collecting, and Skydiving.",
                    PictureUrl = "http://5146-presscdn-25-73.pagely.netdna-cdn.com/wp-content/uploads/2012/12/headshot-headshots-actor-headshots-actors-headshots-london-michael-wharely-137.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "6095 Clary Ct",
                        StreetLine2 = "PO Box 55085",
                        City = "Savannah",
                        State = "GA",
                        Zip = "31407"
                    }
                };
                methods.AddPersonWithAddress(person25);

                Person person26 = new Person()
                {
                    FirstName = "Rafael",
                    LastName = "Powers",
                    Age = 26,
                    Interests = "Comic book collecting, Vacation, Rock climbing, Wikipedia editing, Stand-up comedy, Wood carving, Stand-up comedy, Rock balancing, Gongoozling, Beekeeping, Archery, Blacksmithing, Golfing, Bridge, Debate, Hiking, Fashion, and Kabaddi.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/b1/79/39/b17939a084e26d4415edcd3bde70f4db.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "55852 5th Ave E",
                        StreetLine2 = "Apt 54064",
                        City = "Montgomery",
                        State = "AL",
                        Zip = "36191"
                    }
                };
                methods.AddPersonWithAddress(person26);

                Person person27 = new Person()
                {
                    FirstName = "Marx",
                    LastName = "Hardy",
                    Age = 43,
                    Interests = "Australian rules football, Antiquities, Outdoor hobbies, Vehicle restoration, Nordic skating, Handball, Coffee roasting, Volleyball, and Volleyball.",
                    PictureUrl = "http://5146-presscdn-25-73.pagely.netdna-cdn.com/wp-content/uploads/2012/12/headshot-headshots-actor-headshots-actors-headshots-london-michael-wharely-137.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "81842 Alysheba Rd",
                        StreetLine2 = "PO Box 33318",
                        City = "Dublin",
                        State = "OH",
                        Zip = "43017"
                    }
                };
                methods.AddPersonWithAddress(person27);

                Person person28 = new Person()
                {
                    FirstName = "Elliott",
                    LastName = "Shepard",
                    Age = 49,
                    Interests = "Candle making, Crocheting, Sketching, Hiking/backpacking, Table tennis, Shooting, and Chess.",
                    PictureUrl = "https://photos.smugmug.com/Headshots/Mens-Headshots/i-MmGB3B4/0/L/Alexandre%20Lysiak%202-L.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "9861 Ormond Dr",
                        StreetLine2 = "PO Box 59241",
                        City = "Dodge center",
                        State = "MN",
                        Zip = "55927"
                    }
                };
                methods.AddPersonWithAddress(person28);

                Person person29 = new Person()
                {
                    FirstName = "Corrin",
                    LastName = "Calderon",
                    Age = 29,
                    Interests = "Baton twirling.",
                    PictureUrl = "http://michaelhelms.com/blog/wp-content/uploads/2012/04/G74651.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "69335 Regent Ln",
                        StreetLine2 = "",
                        City = "Charlotte",
                        State = "NC",
                        Zip = "28234"
                    }
                };
                methods.AddPersonWithAddress(person29);

                Person person30 = new Person()
                {
                    FirstName = "Lowell",
                    LastName = "Wheeler",
                    Age = 44,
                    Interests = "Yo-yoing, Cheerleading, and Watching television.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/83/5a/56/835a564ecadfdc02aaabcc577cbc037e.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "95481 17th Ave E",
                        StreetLine2 = "Apt 422",
                        City = "Lindsay",
                        State = "MT",
                        Zip = "59339"
                    }
                };
                methods.AddPersonWithAddress(person30);

                Person person31 = new Person()
                {
                    FirstName = "Sandee",
                    LastName = "Doyle",
                    Age = 46,
                    Interests = "Baton twirling, Genealogy, Table football, Foreign language learning, Leather crafting, Field hockey, Walking, Juggling, and Motor sports.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/0a/4d/51/0a4d515909206bae146e8fec63f16e0d.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "9232 Hillside Ct",
                        StreetLine2 = "PO Box 8372",
                        City = "Munfordville",
                        State = "KY",
                        Zip = "42765"
                    }
                };
                methods.AddPersonWithAddress(person31);

                Person person32 = new Person()
                {
                    FirstName = "Alvin",
                    LastName = "Barnett",
                    Age = 33,
                    Interests = "Machining, Ice hockey, Insect collecting, Lacemaking, Ice skating, Table tennis, Kitesurfing, Candle making, Magic, Model aircraft, Knapping, Astronomy, Soapmaking, Scuba diving, Urban exploration, Figure skating, Birdwatching, Auto racing, and Satellite watching.",
                    PictureUrl = "http://www.jimmyimage.uk/wp-content/uploads/2016/03/HEADSHOTS-Jimmy-Image-Bristol-Headshot-Commercial-Photographer-Photography-Actor-Professional-Corporate-Product-Packshot8.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "26452 Prairie Ct S",
                        StreetLine2 = "Apt 41032",
                        City = "Lorain",
                        State = "OH",
                        Zip = "44052"
                    }
                };
                methods.AddPersonWithAddress(person32);

                Person person33 = new Person()
                {
                    FirstName = "Shirlee",
                    LastName = "Booth",
                    Age = 48,
                    Interests = "Indoors, Cricket, Kitesurfing, Foreign language learning, Snowboarding, Sea glass collecting, Archery, Action figure, Leather crafting, Origami, Sketching, Vintage cars, Action figure, and Hiking/backpacking.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/8c/ea/f5/8ceaf526c1586f79db47cc80b2da7664.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "33878 Heritage Dr E",
                        StreetLine2 = "PO Box 83843",
                        City = "Washington",
                        State = "DC",
                        Zip = "20537"
                    }
                };
                methods.AddPersonWithAddress(person33);

                Person person34 = new Person()
                {
                    FirstName = "Theo",
                    LastName = "Callahan",
                    Age = 46,
                    Interests = "Flying disc, Collection hobbies, and Drama.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/fe/73/da/fe73da812d53fc31b97ba9702b82b839.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "22068 Woodland Ct",
                        StreetLine2 = "",
                        City = "Charlotte",
                        State = "NC",
                        Zip = "28204"
                    }
                };
                methods.AddPersonWithAddress(person34);

                Person person35 = new Person()
                {
                    FirstName = "Mora",
                    LastName = "Pugh",
                    Age = 27,
                    Interests = "Snowboarding, Cheerleading, Knife throwing, Beach volleyball, Speed skating, American football, Orienteering, Baseball, Animal fancy, and Climbing.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/8c/ea/f5/8ceaf526c1586f79db47cc80b2da7664.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "58709 Mark Ct",
                        StreetLine2 = "",
                        City = "Skokie",
                        State = "IL",
                        Zip = "60077"
                    }
                };
                methods.AddPersonWithAddress(person35);

                Person person36 = new Person()
                {
                    FirstName = "Cedrick",
                    LastName = "Rivers",
                    Age = 27,
                    Interests = "Record collecting, Fishkeeping, Speed skating, Camping, Insect collecting, Freestyle football, Crocheting, Lacrosse, Netball, Surfing, Fishing, Marbles, Weightlifting, Knife making, Indoors, Bridge, and Acting.",
                    PictureUrl = "http://www.headshots-newyork.com/photos/unlimited_headshot_example_4.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "71533 Mound St",
                        StreetLine2 = "PO Box 61899",
                        City = "Scenery hill",
                        State = "PA",
                        Zip = "15360"
                    }
                };
                methods.AddPersonWithAddress(person36);

                Person person37 = new Person()
                {
                    FirstName = "Desiree",
                    LastName = "Hardy",
                    Age = 41,
                    Interests = "Satellite watching, Playing musical instruments, Freestyle football, Gaming (tabletop games and role-playing games), Listening to music, Water sports, Airsoft, Surfing, and Video gaming.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/8c/ea/f5/8ceaf526c1586f79db47cc80b2da7664.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "5491 Hamilton Ln",
                        StreetLine2 = "Apt 5420",
                        City = "Hatley",
                        State = "WI",
                        Zip = "54440"
                    }
                };
                methods.AddPersonWithAddress(person37);

                Person person38 = new Person()
                {
                    FirstName = "Calvin",
                    LastName = "Bright",
                    Age = 43,
                    Interests = "Mushroom hunting/mycology, Breakdancing, Seashell collecting, Curling, Kombucha brewing, Watching television, Horseback riding, Astrology, Computer programming, Scouting, Reading, Drawing, Climbing, Soapmaking, Origami, Video gaming, Tennis, and Beekeeping.",
                    PictureUrl = "http://www.davidwerfelmann.com/wordpress/wp-content/uploads/2014/04/Werfelmann-Headshot-Front1.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "70757 Liberty St",
                        StreetLine2 = "PO Box 51941",
                        City = "Philadelphia",
                        State = "PA",
                        Zip = "19148"
                    }
                };
                methods.AddPersonWithAddress(person38);

                Person person39 = new Person()
                {
                    FirstName = "Leatha",
                    LastName = "Morrow",
                    Age = 46,
                    Interests = "Racquetball, Animal fancy, Birdwatching, Video game collecting, Fencing, Skateboarding, Orienteering, Reading, Flying, Outdoor hobbies, Rugby league football, and Whittling.",
                    PictureUrl = "http://5146-presscdn-25-73.pagely.netdna-cdn.com/wp-content/uploads/2012/12/headshot-headshots-actor-headshots-actors-headshots-london-michael-wharely-137.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "12865 Secretariat Dr",
                        StreetLine2 = "Apt 76002",
                        City = "Los angeles",
                        State = "CA",
                        Zip = "90065"
                    }
                };
                methods.AddPersonWithAddress(person39);

                Person person40 = new Person()
                {
                    FirstName = "Oliver",
                    LastName = "Soto",
                    Age = 31,
                    Interests = "Playing musical instruments, Crossword puzzles, Seashell collecting, Element collecting, Water sports, Sculpting, Do it yourself, and Macrame.",
                    PictureUrl = "http://www.davidwerfelmann.com/wordpress/wp-content/uploads/2014/04/Werfelmann-Headshot-Front1.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "97628 Liberty St",
                        StreetLine2 = "",
                        City = "Riverside",
                        State = "CA",
                        Zip = "92504"
                    }
                };
                methods.AddPersonWithAddress(person40);

                Person person41 = new Person()
                {
                    FirstName = "Sallie",
                    LastName = "Olsen",
                    Age = 43,
                    Interests = "Art collecting, Fishkeeping, Bowling, Roller derby, Paintball, Speed skating, Volleyball, Candle making, Rappelling, Writing, Equestrianism, Airsoft, Volleyball, Mahjong, Auto racing, Metal detecting, Association football, Jewelry making, and Breakdancing.",
                    PictureUrl = "http://www.davidnoles.com/wp/wp-content/uploads/2013/10/headshots-nyc-new-york-city_sara-149.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "97784 Oxford Rd N",
                        StreetLine2 = "Apt 81654",
                        City = "Sycamore",
                        State = "GA",
                        Zip = "31790"
                    }
                };
                methods.AddPersonWithAddress(person41);

                Person person42 = new Person()
                {
                    FirstName = "Derrick",
                    LastName = "Villarreal",
                    Age = 46,
                    Interests = "Sculpting, Cabaret, Australian rules football, Handball, Roller skating, Beach volleyball, Learning, Amateur radio, Dancing, Animal fancy, Meteorology, and Kart racing.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/83/5a/56/835a564ecadfdc02aaabcc577cbc037e.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "84763 Sycamore Cir",
                        StreetLine2 = "Apt 90717",
                        City = "Parsonsburg",
                        State = "MD",
                        Zip = "21849"
                    }
                };
                methods.AddPersonWithAddress(person42);

                Person person43 = new Person()
                {
                    FirstName = "Winnifred",
                    LastName = "Farrell",
                    Age = 31,
                    Interests = "Figure skating, Blacksmithing, Outdoors, Flower arranging, Equestrianism, People watching, Stamp collecting, Rock balancing, Fossil hunting, Sand art, Outdoors, Origami, Dance, Singing, Mineral collecting, Action figure, Stand-up comedy, Basketball, and Glassblowing.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/8c/ea/f5/8ceaf526c1586f79db47cc80b2da7664.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "91143 Eagle Creek Blvd",
                        StreetLine2 = "Apt 91131",
                        City = "Havensville",
                        State = "KS",
                        Zip = "66432"
                    }
                };
                methods.AddPersonWithAddress(person43);

                Person person44 = new Person()
                {
                    FirstName = "Brice",
                    LastName = "Delacruz",
                    Age = 42,
                    Interests = "Rugby, Lockpicking, Rugby league football, Roller skating, and Quilting.",
                    PictureUrl = "https://cdn.photographyproject.com.au/wp-content/uploads/2013/04/corporate-headshot.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "63269 Ann Pl",
                        StreetLine2 = "",
                        City = "Brooklyn",
                        State = "NY",
                        Zip = "11220"
                    }
                };
                methods.AddPersonWithAddress(person44);

                Person person45 = new Person()
                {
                    FirstName = "Quinn",
                    LastName = "Gibson",
                    Age = 37,
                    Interests = "Jogging, Drawing, and Metalworking.",
                    PictureUrl = "http://www.cidermill-photography.co.uk/wp-content/uploads/2012/10/bristol-actors-headshot-101.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "89418 145th St W",
                        StreetLine2 = "Apt 78702",
                        City = "Windsor",
                        State = "CT",
                        Zip = "6095"
                    }
                };
                methods.AddPersonWithAddress(person45);

                Person person46 = new Person()
                {
                    FirstName = "Kenneth",
                    LastName = "Benson",
                    Age = 40,
                    Interests = "Foreign language learning, Baton twirling, Motor sports, Mountaineering, Inline skating, Kart racing, Action figure, Ultimate disc, Traveling, Crocheting, and Video gaming.",
                    PictureUrl = "https://photos.peterhurley.com/sites/default/files/photos/2015/03/30/william%C2%A9peterhurley.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "23923 Brookhaven Dr",
                        StreetLine2 = "",
                        City = "Pattersonville",
                        State = "NY",
                        Zip = "12137"
                    }
                };
                methods.AddPersonWithAddress(person46);

                Person person47 = new Person()
                {
                    FirstName = "Araceli",
                    LastName = "Hardin",
                    Age = 44,
                    Interests = "Triathlon, Whittling, Air sports, Kayaking, Comic book collecting, Debate, Fishkeeping, Base jumping, Surfing, Knapping, Magic, Deep web, Knife throwing, Road biking, Reading, Genealogy, and Basketball.",
                    PictureUrl = "http://michaelhelms.com/blog/wp-content/uploads/2012/04/G74651.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "52254 Jocko Ct",
                        StreetLine2 = "PO Box 39654",
                        City = "Austin",
                        State = "TX",
                        Zip = "78714"
                    }
                };
                methods.AddPersonWithAddress(person47);

                Person person48 = new Person()
                {
                    FirstName = "Calvin",
                    LastName = "Parrish",
                    Age = 41,
                    Interests = "3d printing, Badminton, Rafting, Flower arranging, Cosplaying, Electronics, Origami, Jogging, Horseback riding, Sand art, Lapidary, Deltiology (postcard collecting), Amateur radio, Woodworking, Taxidermy, Bodybuilding, and Skydiving.",
                    PictureUrl = "http://www.itercanada.com/wp-content/uploads/2015/01/corporate-headshot.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "62615 Hennes Ave",
                        StreetLine2 = "",
                        City = "Elmhurst",
                        State = "NY",
                        Zip = "11380"
                    }
                };
                methods.AddPersonWithAddress(person48);

                Person person49 = new Person()
                {
                    FirstName = "Juliet",
                    LastName = "Cline",
                    Age = 30,
                    Interests = "Aircraft spotting, Skateboarding, and Skiing.",
                    PictureUrl = "http://jeffellingson.net/cms/filemanager/1042v2.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "95015 Hartley Blvd N",
                        StreetLine2 = "",
                        City = "Los olivos",
                        State = "CA",
                        Zip = "93441"
                    }
                };
                methods.AddPersonWithAddress(person49);

                Person person50 = new Person()
                {
                    FirstName = "Eddie",
                    LastName = "Ochoa",
                    Age = 26,
                    Interests = "Shooting sport, Water sports, Baton twirling, Creative writing, Hunting, Archery, Mahjong, Baton twirling, Horseback riding, Polo, Fishing, Outdoor hobbies, Wood carving, Color guard, Radio-controlled car racing, and Homebrewing.",
                    PictureUrl = "http://traviscurryphotography.com/wp-content/uploads/2015/07/Actor-Headshots-GerardC-Travis-Curry-02.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "76031 Dominion Ave",
                        StreetLine2 = "",
                        City = "Canton",
                        State = "OH",
                        Zip = "44704"
                    }
                };
                methods.AddPersonWithAddress(person50);

                Person person51 = new Person()
                {
                    FirstName = "Bernice",
                    LastName = "Shelton",
                    Age = 34,
                    Interests = "Hiking/backpacking, Inline skating, Ice skating, Ice hockey, Auto audiophilia, Leather crafting, Mahjong, Candle making, Fishing, Record collecting, Boxing, Macrame, Archery, Candle making, Photography, Astrology, Tai chi, and Metalworking.",
                    PictureUrl = "http://jeffellingson.net/cms/filemanager/1042v2.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "26538 Pheasant Run St",
                        StreetLine2 = "PO Box 49796",
                        City = "Manito",
                        State = "IL",
                        Zip = "61546"
                    }
                };
                methods.AddPersonWithAddress(person51);

                Person person52 = new Person()
                {
                    FirstName = "Franklyn",
                    LastName = "Mack",
                    Age = 29,
                    Interests = "Dowsing, Quilting, Herping, Vehicle restoration, Acting, Shooting sport, Billiards, Slacklining, People watching, Yo-yoing, and Dowsing.",
                    PictureUrl = "http://www.imageworksnyc.com/images/NYC%20Headshots.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "94565 Sussex Ct",
                        StreetLine2 = "Apt 54541",
                        City = "Loretto",
                        State = "MN",
                        Zip = "55599"
                    }
                };
                methods.AddPersonWithAddress(person52);

                Person person53 = new Person()
                {
                    FirstName = "Lelia",
                    LastName = "Ratliff",
                    Age = 47,
                    Interests = "Kite flying, Australian rules football, Bird watching, Cross-stitch, Juggling, Sculling or rowing, Couponing, Vintage cars, Meteorology, Geocaching, Surfing, Parkour, Stone skipping, and Antiquities.",
                    PictureUrl = "http://michaelhelms.com/blog/wp-content/uploads/2012/04/G74651.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "17917 E Mound St",
                        StreetLine2 = "Apt 86510",
                        City = "Meridian",
                        State = "ID",
                        Zip = "83646"
                    }
                };
                methods.AddPersonWithAddress(person53);

                Person person54 = new Person()
                {
                    FirstName = "Rubin",
                    LastName = "Francis",
                    Age = 28,
                    Interests = "People watching, Hooping, Kayaking, Bridge, and Board games.",
                    PictureUrl = "http://www.imageworksnyc.com/images/NYC%20Headshots.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "76195 County Road 14",
                        StreetLine2 = "PO Box 27975",
                        City = "Cisne",
                        State = "IL",
                        Zip = "62823"
                    }
                };
                methods.AddPersonWithAddress(person54);

                Person person55 = new Person()
                {
                    FirstName = "Zella",
                    LastName = "Kirby",
                    Age = 29,
                    Interests = "Whale watching, Leather crafting, Tatting, Quilting, and High-powered rocketry.",
                    PictureUrl = "http://eugenephotographer.com/wp-content/uploads/2013/01/acting-headshots-eugene-oregon.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "90141 Anton Way",
                        StreetLine2 = "PO Box 34050",
                        City = "Veblen",
                        State = "SD",
                        Zip = "57270"
                    }
                };
                methods.AddPersonWithAddress(person55);

                Person person56 = new Person()
                {
                    FirstName = "Michael",
                    LastName = "Guy",
                    Age = 37,
                    Interests = "Antiquing, Playing musical instruments, Lockpicking, Radio-controlled car racing, and Disc golf.",
                    PictureUrl = "http://www.jimmyimage.uk/wp-content/uploads/2016/03/HEADSHOTS-Jimmy-Image-Bristol-Headshot-Commercial-Photographer-Photography-Actor-Professional-Corporate-Product-Packshot8.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "88787 Karner Dr",
                        StreetLine2 = "Apt 95877",
                        City = "Cross plains",
                        State = "WI",
                        Zip = "53528"
                    }
                };
                methods.AddPersonWithAddress(person56);

                Person person57 = new Person()
                {
                    FirstName = "Tomeka",
                    LastName = "Snow",
                    Age = 37,
                    Interests = "Volleyball, Swimming, Kite flying, Genealogy, Metal detecting, and Machining.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/0a/4d/51/0a4d515909206bae146e8fec63f16e0d.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "92518 Parkview Ct",
                        StreetLine2 = "",
                        City = "Saint paul",
                        State = "MN",
                        Zip = "55107"
                    }
                };
                methods.AddPersonWithAddress(person57);

                Person person58 = new Person()
                {
                    FirstName = "Alfredo",
                    LastName = "Mccarthy",
                    Age = 39,
                    Interests = "Stand-up comedy, Model aircraft, Footbag, Philately, Australian rules football, Soccer, Breakdancing, Baton twirling, Martial arts, Jewelry making, and Taxidermy.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/b1/79/39/b17939a084e26d4415edcd3bde70f4db.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "35097 Ashbourne Cir",
                        StreetLine2 = "Apt 69517",
                        City = "Riverton",
                        State = "IA",
                        Zip = "51650"
                    }
                };
                methods.AddPersonWithAddress(person58);

                Person person59 = new Person()
                {
                    FirstName = "Kourtney",
                    LastName = "Parker",
                    Age = 43,
                    Interests = "Reading, Freestyle football, Brazilian jiu-jitsu, Ice skating, and Shooting.",
                    PictureUrl = "http://www.jordanmatter.com/images/Tara_Westwood.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "50997 11th Ave",
                        StreetLine2 = "Apt 47315",
                        City = "Santa rosa",
                        State = "CA",
                        Zip = "95401"
                    }
                };
                methods.AddPersonWithAddress(person59);

                Person person60 = new Person()
                {
                    FirstName = "Craig",
                    LastName = "Mcbride",
                    Age = 38,
                    Interests = "Embroidery.",
                    PictureUrl = "https://pbs.twimg.com/media/BjD44BBCUAARinE.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "50918 Dublin Ln",
                        StreetLine2 = "",
                        City = "Shortsville",
                        State = "NY",
                        Zip = "14548"
                    }
                };
                methods.AddPersonWithAddress(person60);

                Person person61 = new Person()
                {
                    FirstName = "Carin",
                    LastName = "Keller",
                    Age = 40,
                    Interests = "Singing, Shooting, Roller skating, Sewing, Billiards, Do it yourself, and Rock balancing.",
                    PictureUrl = "http://www.floankah.com/actressnyc/wp-content/uploads/2015/12/FloAnkah_15JM-01_web.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "84939 Downing Ave",
                        StreetLine2 = "PO Box 14734",
                        City = "Stringtown",
                        State = "OK",
                        Zip = "74569"
                    }
                };
                methods.AddPersonWithAddress(person61);

                Person person62 = new Person()
                {
                    FirstName = "Elvin",
                    LastName = "Navarro",
                    Age = 37,
                    Interests = "Fashion, Baseball, Meteorology, Urban exploration, Antiquing, Fossil hunting, Skydiving, Drawing, Fashion, Disc golf, and Surfing.",
                    PictureUrl = "http://www.jimmyimage.uk/wp-content/uploads/2015/01/HEADSHOTS-jimmy-image-commercial-photographer-bristol-headshots-portraits-product22.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "60962 Sibley St S",
                        StreetLine2 = "Apt 90559",
                        City = "Fresno",
                        State = "CA",
                        Zip = "93705"
                    }
                };
                methods.AddPersonWithAddress(person62);

                Person person63 = new Person()
                {
                    FirstName = "Lucretia",
                    LastName = "Buck",
                    Age = 41,
                    Interests = "Outdoors, Sculling or rowing, Coloring, Aircraft spotting, Lacrosse, Rugby league football, Bowling, Mahjong, Fantasy sports, Marbles, Cosplaying, Volleyball, Airsoft, Fashion, Woodworking, Leather crafting, Philately, Fishkeeping, and Bird watching.",
                    PictureUrl = "http://eugenephotographer.com/wp-content/uploads/2013/01/acting-headshots-eugene-oregon1.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "67141 Berkshire Ln",
                        StreetLine2 = "PO Box 63254",
                        City = "Moclips",
                        State = "WA",
                        Zip = "98562"
                    }
                };
                methods.AddPersonWithAddress(person63);

                Person person64 = new Person()
                {
                    FirstName = "Kent",
                    LastName = "Boone",
                    Age = 31,
                    Interests = "Listening to music, Snowboarding, and Netball.",
                    PictureUrl = "http://traviscurryphotography.com/wp-content/uploads/2015/07/Actor-Headshots-GerardC-Travis-Curry-02.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "83798 Naumkeag St N",
                        StreetLine2 = "",
                        City = "Anaheim",
                        State = "CA",
                        Zip = "92801"
                    }
                };
                methods.AddPersonWithAddress(person64);

                Person person65 = new Person()
                {
                    FirstName = "Wendie",
                    LastName = "Small",
                    Age = 29,
                    Interests = "Cricket, Book restoration, Puzzles, Flower arranging, Chess, Fishing, Running, Fossil hunting, Bus spotting, Competition hobbies, Singing, Art collecting, Yoga, Shopping, Knife throwing, Crocheting, and Seashell collecting.",
                    PictureUrl = "http://www.maxbrandinphotography.com/wp-content/uploads/2013/06/B0C1271_WEB_Crop_LosAngeles_Kids_Actor_Headshots.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "1749 Naumkeag St N",
                        StreetLine2 = "Apt 63075",
                        City = "Houston",
                        State = "TX",
                        Zip = "77230"
                    }
                };
                methods.AddPersonWithAddress(person65);

                Person person66 = new Person()
                {
                    FirstName = "Reyes",
                    LastName = "Valentine",
                    Age = 44,
                    Interests = "Outdoors, Cabaret, Playing musical instruments, Tatting, Kart racing, and Sculling or rowing.",
                    PictureUrl = "http://www.jimmyimage.uk/wp-content/uploads/2015/01/HEADSHOTS-jimmy-image-commercial-photographer-bristol-headshots-portraits-product22.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "86853 County Highway 16",
                        StreetLine2 = "PO Box 82550",
                        City = "Hallie",
                        State = "KY",
                        Zip = "41821"
                    }
                };
                methods.AddPersonWithAddress(person66);

                Person person67 = new Person()
                {
                    FirstName = "Vida",
                    LastName = "Stafford",
                    Age = 47,
                    Interests = "Cross-stitch, Gardening, Water sports, Running, Surfing, Action figure, Skiing, Paintball, Drama, Sewing, Bodybuilding, Foreign language learning, and Movie and movie memorabilia collecting.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/8c/ea/f5/8ceaf526c1586f79db47cc80b2da7664.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "20181 Groveland Way",
                        StreetLine2 = "PO Box 18648",
                        City = "Tampa",
                        State = "FL",
                        Zip = "33661"
                    }
                };
                methods.AddPersonWithAddress(person67);

                Person person68 = new Person()
                {
                    FirstName = "Victor",
                    LastName = "Farmer",
                    Age = 28,
                    Interests = "Lacrosse, Die-cast toy, Birdwatching, Bodybuilding, and Outdoors.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/b1/79/39/b17939a084e26d4415edcd3bde70f4db.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "97091 S Cretex Ave",
                        StreetLine2 = "",
                        City = "Westtown",
                        State = "NY",
                        Zip = "10998"
                    }
                };
                methods.AddPersonWithAddress(person68);

                Person person69 = new Person()
                {
                    FirstName = "Yessenia",
                    LastName = "Fuentes",
                    Age = 43,
                    Interests = "Hiking, Pigeon racing, Gardening, Plastic embedding, Cheerleading, and Scouting.",
                    PictureUrl = "https://www.stayathomemum.com.au/cache/860x380-0/wp-content/uploads/2016/03/Alexis-Bledel-CelebHealthy_com-e1458614938577.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "63909 Sakpe Dr",
                        StreetLine2 = "Apt 8836",
                        City = "Phoenix",
                        State = "AZ",
                        Zip = "85036"
                    }
                };
                methods.AddPersonWithAddress(person69);

                Person person70 = new Person()
                {
                    FirstName = "Garland",
                    LastName = "Sanders",
                    Age = 49,
                    Interests = "Electronics, Creative writing, Bowling, Digital arts, Fossil hunting, Yo-yoing, Mountaineering, Sculpting, Mushroom hunting/mycology, Triathlon, Observation hobbies, and Surfing.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/ff/4a/4a/ff4a4a64f29506da954024440720616d.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "38226 Hawthorne Cir",
                        StreetLine2 = "",
                        City = "Lincoln",
                        State = "NE",
                        Zip = "68520"
                    }
                };
                methods.AddPersonWithAddress(person70);

                Person person71 = new Person()
                {
                    FirstName = "Dannette",
                    LastName = "Day",
                    Age = 30,
                    Interests = "Outdoor hobbies, Tai chi, Knife making, Crocheting, Rock balancing, Skateboarding, Trainspotting, Cabaret, and Nordic skating.",
                    PictureUrl = "http://i.imgur.com/tlx5fFM.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "25004 Pierce St S",
                        StreetLine2 = "",
                        City = "Los angeles",
                        State = "CA",
                        Zip = "90074"
                    }
                };
                methods.AddPersonWithAddress(person71);

                Person person72 = new Person()
                {
                    FirstName = "Jimmie",
                    LastName = "Holden",
                    Age = 32,
                    Interests = "Competition hobbies, Blacksmithing, Cross-stitch, Kabaddi, Macrame, Marbles, Knitting, Amateur radio, Stamp collecting, Plastic embedding, Lockpicking, Shopping, Orienteering, Hooping, Outdoors, Deltiology (postcard collecting), Mineral collecting, Ghost hunting, and Jogging.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/fe/73/da/fe73da812d53fc31b97ba9702b82b839.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "83956 Yorkshire Ln",
                        StreetLine2 = "",
                        City = "Brownsburg",
                        State = "VA",
                        Zip = "24415"
                    }
                };
                methods.AddPersonWithAddress(person72);

                Person person73 = new Person()
                {
                    FirstName = "Lavonia",
                    LastName = "Holloway",
                    Age = 38,
                    Interests = "Tai chi, Observation hobbies, Playing musical instruments, Cheerleading, Rock balancing, Mountaineering, Knapping, Sculling or rowing, Candle making, Rock climbing, Poi, Gaming (tabletop games and role-playing games), Dancing, Rugby, Gaming (tabletop games and role-playing games), Table football, Debate, and Gongoozling.",
                    PictureUrl = "http://www.cidermill-photography.co.uk/wp-content/uploads/2012/10/bristol-actors-headshot-101.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "77923 Swallowtail Dr",
                        StreetLine2 = "",
                        City = "Montrose",
                        State = "SD",
                        Zip = "57048"
                    }
                };
                methods.AddPersonWithAddress(person73);

                Person person74 = new Person()
                {
                    FirstName = "Jerrell",
                    LastName = "Powell",
                    Age = 36,
                    Interests = "Cricket, Radio-controlled car racing, Rock balancing, Philately, Roller skating, Fossil hunting, Netball, 3d printing, Philately, Archery, Kitesurfing, Flag football, Sculling or rowing, Macrame, Microscopy, Outdoors, Jogging, Inline skating, and Badminton.",
                    PictureUrl = "http://www.jimmyimage.uk/wp-content/uploads/2016/03/HEADSHOTS-Jimmy-Image-Bristol-Headshot-Commercial-Photographer-Photography-Actor-Professional-Corporate-Product-Packshot8.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "96269 135th St",
                        StreetLine2 = "",
                        City = "Anaheim",
                        State = "CA",
                        Zip = "92815"
                    }
                };
                methods.AddPersonWithAddress(person74);

                Person person75 = new Person()
                {
                    FirstName = "Veta",
                    LastName = "Boyer",
                    Age = 41,
                    Interests = "Martial arts, Mineral collecting, Astrology, Skateboarding, Cricket, Trainspotting, Fishkeeping, Squash, Fishkeeping, Stone skipping, Knitting, and Drawing.",
                    PictureUrl = "http://i.imgur.com/tlx5fFM.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "3468 Homestead St",
                        StreetLine2 = "",
                        City = "New laguna",
                        State = "NM",
                        Zip = "87038"
                    }
                };
                methods.AddPersonWithAddress(person75);

                Person person76 = new Person()
                {
                    FirstName = "Elijah",
                    LastName = "Strong",
                    Age = 26,
                    Interests = "Cosplaying, Photography, Knife throwing, Flag football, Martial arts, Mahjong, Graffiti, Gymnastics, Astronomy, Singing, Taekwondo, Taekwondo, and Urban exploration.",
                    PictureUrl = "http://www.itercanada.com/wp-content/uploads/2015/01/corporate-headshot.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "2614 Spruce St",
                        StreetLine2 = "",
                        City = "Pittsburgh",
                        State = "PA",
                        Zip = "15236"
                    }
                };
                methods.AddPersonWithAddress(person76);

                Person person77 = new Person()
                {
                    FirstName = "Kimberli",
                    LastName = "Weiss",
                    Age = 41,
                    Interests = "Snowboarding, Rappelling, Mahjong, Reading, Color guard, Poi, Tatting, Outdoor hobbies, Philately, Fantasy sports, Geocaching, Debate, Cycling, Topiary, and Racquetball.",
                    PictureUrl = "http://www.davidnoles.com/wp/wp-content/uploads/2013/10/headshots-nyc-new-york-city_sara-149.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "801 Grove Pl",
                        StreetLine2 = "PO Box 39002",
                        City = "Eau claire",
                        State = "WI",
                        Zip = "54702"
                    }
                };
                methods.AddPersonWithAddress(person77);

                Person person78 = new Person()
                {
                    FirstName = "Erick",
                    LastName = "Carter",
                    Age = 27,
                    Interests = "Speed skating, Beach volleyball, Stone collecting, Aircraft spotting, Badminton, Bridge, Worldbuilding, Tennis, Running, Sketching, Martial arts, Table tennis, Ice skating, Do it yourself, Antiquing, and Kitesurfing.",
                    PictureUrl = "https://2d3z3x4e2xrx130kvm2hxdsp-wpengine.netdna-ssl.com/wp-content/uploads/2015/04/kalama_epstein_084r.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "37254 Rye Ct",
                        StreetLine2 = "PO Box 5826",
                        City = "Arnolds park",
                        State = "IA",
                        Zip = "51331"
                    }
                };
                methods.AddPersonWithAddress(person78);

                Person person79 = new Person()
                {
                    FirstName = "Lucinda",
                    LastName = "York",
                    Age = 28,
                    Interests = "Deltiology (postcard collecting), Auto audiophilia, and Nordic skating.",
                    PictureUrl = "http://www.davidnoles.com/wp/wp-content/uploads/2013/10/headshots-nyc-new-york-city_sara-149.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "37868 Washington Ct",
                        StreetLine2 = "PO Box 77558",
                        City = "Hutchinson",
                        State = "PA",
                        Zip = "15640"
                    }
                };
                methods.AddPersonWithAddress(person79);

                Person person80 = new Person()
                {
                    FirstName = "Wesley",
                    LastName = "Bentley",
                    Age = 25,
                    Interests = "Quilling, Wikipedia editing, Judo, Metalworking, Table tennis, Blacksmithing, Cheerleading, and Hooping.",
                    PictureUrl = "http://www.headshots-newyork.com/photos/unlimited_headshot_example_4.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "21582 Preserve Ct",
                        StreetLine2 = "Apt 99021",
                        City = "Lewisville",
                        State = "IN",
                        Zip = "47352"
                    }
                };
                methods.AddPersonWithAddress(person80);

                Person person81 = new Person()
                {
                    FirstName = "Shamika",
                    LastName = "Pitts",
                    Age = 32,
                    Interests = "Astronomy, Knife throwing, Gongoozling, Macrame, Knife throwing, Beekeeping, Scuba diving, Juggling, Jukskei, Fishing, Cryptography, and Video game collecting.",
                    PictureUrl = "http://www.floankah.com/actressnyc/wp-content/uploads/2015/12/FloAnkah_15JM-01_web.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "89618 Sage Ct",
                        StreetLine2 = "PO Box 38156",
                        City = "Saint augustine",
                        State = "FL",
                        Zip = "32086"
                    }
                };
                methods.AddPersonWithAddress(person81);

                Person person82 = new Person()
                {
                    FirstName = "Giuseppe",
                    LastName = "Brooks",
                    Age = 31,
                    Interests = "Microscopy, Auto audiophilia, Hiking, Antiquities, Color guard, Candle making, Movie and movie memorabilia collecting, Brazilian jiu-jitsu, Lapidary, Volleyball, and Jogging.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/83/5a/56/835a564ecadfdc02aaabcc577cbc037e.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "22003 Balinese St",
                        StreetLine2 = "Apt 78700",
                        City = "Chesapeake",
                        State = "OH",
                        Zip = "45619"
                    }
                };
                methods.AddPersonWithAddress(person82);

                Person person83 = new Person()
                {
                    FirstName = "Teri",
                    LastName = "Keith",
                    Age = 43,
                    Interests = "Shopping, Worldbuilding, Gunsmithing, and Singing.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/d9/bc/ec/d9bcec9f571ef85b0cba39bffad7f95a.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "1937 Park Pl",
                        StreetLine2 = "PO Box 79259",
                        City = "Pleasant hill",
                        State = "TN",
                        Zip = "38578"
                    }
                };
                methods.AddPersonWithAddress(person83);

                Person person84 = new Person()
                {
                    FirstName = "Guy",
                    LastName = "Rhodes",
                    Age = 28,
                    Interests = "Metal detecting, Sailing, Slacklining, Metalworking, Flying disc, Slacklining, Knitting, Crossword puzzles, Macrame, and Roller skating.",
                    PictureUrl = "https://photos.peterhurley.com/sites/default/files/photos/2015/03/30/william%C2%A9peterhurley.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "67624 Old Carriage Ct",
                        StreetLine2 = "PO Box 59455",
                        City = "Kelliher",
                        State = "MN",
                        Zip = "56650"
                    }
                };
                methods.AddPersonWithAddress(person84);

                Person person85 = new Person()
                {
                    FirstName = "Jolyn",
                    LastName = "Wilkerson",
                    Age = 38,
                    Interests = "Dancing, Dancing, Footbag, Kayaking, Woodworking, Fishing, Kayaking, and Rock climbing.",
                    PictureUrl = "http://5146-presscdn-25-73.pagely.netdna-cdn.com/wp-content/uploads/2012/12/headshot-headshots-actor-headshots-actors-headshots-london-michael-wharely-137.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "49635 Hennes Ave",
                        StreetLine2 = "PO Box 92370",
                        City = "Queen creek",
                        State = "AZ",
                        Zip = "85240"
                    }
                };
                methods.AddPersonWithAddress(person85);

                Person person86 = new Person()
                {
                    FirstName = "Harley",
                    LastName = "Doyle",
                    Age = 38,
                    Interests = "Animal fancy, Foreign language learning, Table tennis, Graffiti, Embroidery, Antiquing, and Learning.",
                    PictureUrl = "http://www.jimmyimage.uk/wp-content/uploads/2016/03/HEADSHOTS-Jimmy-Image-Bristol-Headshot-Commercial-Photographer-Photography-Actor-Professional-Corporate-Product-Packshot8.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "38826 Clover Ct",
                        StreetLine2 = "Apt 47407",
                        City = "Turner",
                        State = "OR",
                        Zip = "97392"
                    }
                };
                methods.AddPersonWithAddress(person86);

                Person person87 = new Person()
                {
                    FirstName = "Kerrie",
                    LastName = "Crosby",
                    Age = 44,
                    Interests = "Digital arts, Hiking, Singing, Field hockey, Stone skipping, Reading, Metal detecting, Bus spotting, Baton twirling, Handball, Sand art, Volleyball, and Judo.",
                    PictureUrl = "http://michaelhelms.com/blog/wp-content/uploads/2012/04/G74651.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "12132 Tyrone Dr S",
                        StreetLine2 = "",
                        City = "Baxley",
                        State = "GA",
                        Zip = "31515"
                    }
                };
                methods.AddPersonWithAddress(person87);

                Person person88 = new Person()
                {
                    FirstName = "Charles",
                    LastName = "Rutledge",
                    Age = 28,
                    Interests = "Freestyle football, Basketball, Deltiology (postcard collecting), Roller derby, Hiking, and Acting.",
                    PictureUrl = "https://photos.smugmug.com/NYC-Headshot-Photography/Acting/i-Mrcb7pF/0/XL/eric-krauss-headshots-172-Edit-4-XL.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "420 Berkshire Ct",
                        StreetLine2 = "Apt 16588",
                        City = "Evansville",
                        State = "IN",
                        Zip = "47734"
                    }
                };
                methods.AddPersonWithAddress(person88);

                Person person89 = new Person()
                {
                    FirstName = "Olinda",
                    LastName = "Lamb",
                    Age = 43,
                    Interests = "Photography, Rock balancing, Learning, Wikipedia editing, Collection hobbies, Sewing, Amateur radio, Sand art, Collection hobbies, Billiards, Auto racing, Book collecting, Disc golf, Yo-yoing, Lego building, Rafting, and Motor sports.",
                    PictureUrl = "http://www.jordanmatter.com/images/Tara_Westwood.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "15928 Pribyl Pond Ln",
                        StreetLine2 = "",
                        City = "Manhattan",
                        State = "MT",
                        Zip = "59741"
                    }
                };
                methods.AddPersonWithAddress(person89);

                Person person90 = new Person()
                {
                    FirstName = "Columbus",
                    LastName = "Walton",
                    Age = 37,
                    Interests = "Dancing, Gongoozling, Rock climbing, Playing musical instruments, and Camping.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/fe/73/da/fe73da812d53fc31b97ba9702b82b839.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "42320 Hwy 41",
                        StreetLine2 = "Apt 86559",
                        City = "West newton",
                        State = "MA",
                        Zip = "2465"
                    }
                };
                methods.AddPersonWithAddress(person90);

                Person person91 = new Person()
                {
                    FirstName = "Shonta",
                    LastName = "Phillips",
                    Age = 32,
                    Interests = "Rock climbing, Stone collecting, American football, Fossil hunting, and Triathlon.",
                    PictureUrl = "http://5146-presscdn-25-73.pagely.netdna-cdn.com/wp-content/uploads/2012/12/headshot-headshots-actor-headshots-actors-headshots-london-michael-wharely-137.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "44820 Belmont Ave Nw",
                        StreetLine2 = "Apt 38039",
                        City = "Carthage",
                        State = "SD",
                        Zip = "57323"
                    }
                };
                methods.AddPersonWithAddress(person91);

                Person person92 = new Person()
                {
                    FirstName = "Wilber",
                    LastName = "O'connor",
                    Age = 36,
                    Interests = "Cheerleading, Shopping, Coloring, Cross-stitch, Plastic embedding, and Origami.",
                    PictureUrl = "http://www.headshots-newyork.com/photos/unlimited_headshot_example_4.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "34433 70th St",
                        StreetLine2 = "PO Box 15121",
                        City = "Weyauwega",
                        State = "WI",
                        Zip = "54983"
                    }
                };
                methods.AddPersonWithAddress(person92);

                Person person93 = new Person()
                {
                    FirstName = "Lisabeth",
                    LastName = "Joseph",
                    Age = 26,
                    Interests = "Action figure, Skateboarding, Magic, Flying, Color guard, Basketball, Deep web, Writing, Baseball, Fishing, Reading, and Fishkeeping.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/3d/29/e2/3d29e2b0e318a01b08f52abc76ae6b9c.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "80550 Chateau Ave",
                        StreetLine2 = "PO Box 93090",
                        City = "West des moines",
                        State = "IA",
                        Zip = "50265"
                    }
                };
                methods.AddPersonWithAddress(person93);

                Person person94 = new Person()
                {
                    FirstName = "Dante",
                    LastName = "Lee",
                    Age = 29,
                    Interests = "Sculling or rowing.",
                    PictureUrl = "http://traviscurryphotography.com/wp-content/uploads/2015/07/Actor-Headshots-GerardC-Travis-Curry-02.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "43015 5th Ave E",
                        StreetLine2 = "",
                        City = "Pearlington",
                        State = "MS",
                        Zip = "39572"
                    }
                };
                methods.AddPersonWithAddress(person94);

                Person person95 = new Person()
                {
                    FirstName = "Marva",
                    LastName = "Morrow",
                    Age = 31,
                    Interests = "Slot car racing, Origami, Swimming, Inline skating, Photography, Homebrewing, Baseball, and Kabaddi.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/3d/29/e2/3d29e2b0e318a01b08f52abc76ae6b9c.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "74010 Tyrol Dr",
                        StreetLine2 = "",
                        City = "Minneapolis",
                        State = "MN",
                        Zip = "55441"
                    }
                };
                methods.AddPersonWithAddress(person95);

                Person person96 = new Person()
                {
                    FirstName = "Elisha",
                    LastName = "May",
                    Age = 34,
                    Interests = "Footbag, Volleyball, Mountain biking, Curling, Kombucha brewing, Rock balancing, Blacksmithing, Computer programming, Ice skating, and Dancing.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/736x/83/5a/56/835a564ecadfdc02aaabcc577cbc037e.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "36024 Whitetail Dr",
                        StreetLine2 = "Apt 95287",
                        City = "Wheatcroft",
                        State = "KY",
                        Zip = "42463"
                    }
                };
                methods.AddPersonWithAddress(person96);

                Person person97 = new Person()
                {
                    FirstName = "Elmira",
                    LastName = "Camacho",
                    Age = 25,
                    Interests = "Baton twirling, Figure skating, Shooting, Hunting, Gymnastics, Exhibition drill, Card collecting, Macrame, and Footbag.",
                    PictureUrl = "http://www.sharpfocusphoto.com/wp-content/uploads//2013/01/actor-headshot-7794.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "44271 Rosewood Cir",
                        StreetLine2 = "Apt 25442",
                        City = "Dallas",
                        State = "TX",
                        Zip = "75312"
                    }
                };
                methods.AddPersonWithAddress(person97);

                Person person98 = new Person()
                {
                    FirstName = "Jospeh",
                    LastName = "O'neil",
                    Age = 37,
                    Interests = "Glassblowing, Antiquing, Satellite watching, Deep web, Taxidermy, and Model aircraft.",
                    PictureUrl = "https://static1.squarespace.com/static/571127b455598628154efb9b/572a3f4127d4bd1977b9608d/572a419cab48deecfc04f6fb/1462387104838/creative-dating-headshot-dramatic-lighting.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "92109 Viola Ct",
                        StreetLine2 = "Apt 98706",
                        City = "Bondville",
                        State = "IL",
                        Zip = "61815"
                    }
                };
                methods.AddPersonWithAddress(person98);

                Person person99 = new Person()
                {
                    FirstName = "Vena",
                    LastName = "Fleming",
                    Age = 48,
                    Interests = "Homebrewing, Bowling, Letterboxing, and Record collecting.",
                    PictureUrl = "https://s-media-cache-ak0.pinimg.com/originals/8c/ea/f5/8ceaf526c1586f79db47cc80b2da7664.jpg",
                    Address = new Address()
                    {
                        StreetLine1 = "75708 3rd Ave N W",
                        StreetLine2 = "",
                        City = "Rushsylvania",
                        State = "OH",
                        Zip = "43347"
                    }
                };
                methods.AddPersonWithAddress(person99);
            }
        }
    }
}
