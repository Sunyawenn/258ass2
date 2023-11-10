using assessment2.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace assessment2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Information()
        {
            List<syw> products = new List<syw>
            {
                new syw
                {
                    Name = "Tiananmen Square",
                    Type = "Scenic spot",
                    Description = "Tian'anmen is the main gate of the imperial city of Beijing in the Ming and Qing dynasties. It was built in the 15th year of Yongle of the Ming Dynasty (1417) and was originally named \"Chengtianmen\", which means \"Chengtianmen\".The designer was Kuai Xiang, a master of imperial architecture in Ming Dynasty. In 1651, it was renamed Tian 'anmen. It is composed of two parts, the tower and the tower, with white marble sumi seat, with a total height of 34.7 meters.Tian 'anmen Rostrum is 66 meters long and 37 meters wide. There are five gates under the city, and the middle gate is the largest, located on the central axis of the imperial city of Beijing, and in the past only the emperor could enter and exit from it.",
                    ImagePath = "/Content/Images/Tiananmen Square.jpg"
                },
                new syw
                {
                    Name = "Peking Duck",
                    Type = "Delicacy",
                    Description = "Beijing Roast duck is a famous dish in Beijing with a world reputation. It originated in the Southern and Northern Dynasties of China, and it was a famous dish in the court at that time.The material is high quality meat duck, fruit wood charcoal roast, red color, meat fat but not greasy, crispy inside tender.There are two main schools of Peking duck, and the most famous roast duck restaurant in Beijing is a representative of both. It is known as \"the world delicious\" for its red color, tender meat, mellow taste, fat but not greasy characteristics.Beijing roast duck is famous at home and abroad for its strict selection of ingredients, fine roasting techniques, unique flavor and diversified eating methods.",
                    ImagePath = "/Content/Images/Peking Duck.jpg"
                },
                new syw
                {
                    Name = "Peking Opera",
                    Type = "Culture",
                    Description = "Peking Opera, also known as Ping Opera and Beijing Opera, is one of the quintessence of China. The roles of Peking Opera are divided into Sheng, Dan, Jing, Chou, miscellaneous, Wu and Liu. The last three are no longer specialized. Singing, reading, doing and playing skills have their own characteristics. Peking Opera is widely broadcast throughout the country and has a wide influence. It is called \"national opera\". Peking Opera is an important form of expression of traditional Chinese culture, and its various artistic elements are symbolized as symbols of traditional Chinese culture.In May 2006, Peking Opera was approved by The State Council to be included in the first batch of national intangible cultural heritage list.",
                    ImagePath = "/Content/Images/Peking Opera.jpg"
                },
                new syw
                {
                    Name = "Forbidden City",
                    Type = "Scenic spot",
                    Description = "The Forbidden City is the imperial palace of the Ming and Qing dynasties of China, formerly known as the Forbidden City, located in the center of the central axis of Beijing. The Palace Museum began construction in the fourth year of Yongle (1406), based on the Nanjing Palace Museum, and was completed in the 18th year of Yongle (1420), becoming the imperial palace of 24 emperors of the Ming and Qing dynasties. The Forbidden City is 961 meters long from north to south and 753 meters wide from east to west. It is surrounded by walls 10 meters high and a moat 52 meters wide outside the walls. The Forbidden City has four gates, the Meridian Gate to the south, the Shenwu Gate to the north, the Donghua Gate to the east and the Xihua Gate to the west.",
                    ImagePath = "/Content/Images/Forbidden City.jpg"
                },
                new syw
                {
                    Name = "Noodles with bean paste",
                    Type = "Delicacy",
                    Description = "Zhajiang noodles, is a traditional Chinese characteristic pasta, known as one of the \"ten noodles in China\", for Beijing cuisine, the main materials are noodles, soy sauce, bean sprouts, cucumbers, etc., salty, sour and spicy taste, fresh and refreshing, strong.There is a lot of wheat in the north, so there are many types of pasta. But old Beijing fried sauce noodles is the king of our pasta. The ceremony of the old Beijing fried sauce noodles is very strong, the middle is placed with cold water soaked \"over the water\", the most central modulation of the fried sauce on the table, followed by some small spices, cucumbers, bean sprouts and so on. When you're done stirring, take a bite and you'll feel satisfied on the tip of your tongue.",
                    ImagePath = "/Content/Images/Noodles with bean paste.jpg"
                },
                 new syw
                {
                    Name = "Beiging Hutong",
                    Type = "Culture",
                    Description = "Beijing Hutong culture is not only the vein of the city, the traffic thoroughfare, it is the place of Beijing ordinary people's life, the important stage of the historical and cultural development of Beijing. Walking among them, there are places of interest everywhere, and the careful taste is like the encyclopedia of Beijing, and a brick and a tile in many hutongs have hundreds of years of history. From each large and small hutong courtyard, you can understand the life of Beijing citizens, including their lifestyle, life interest and neighborhood relations.Beijing Hutong is the product of long history, it reflects the face of Beijing history, is rich in content.",
                    ImagePath = "/Content/Images/Beiging Hutong.jpg"
                },
                  new syw
                {
                    Name = "The Summer Palace",
                    Type = "Scenic spot",
                    Description = "The Summer Palace, formerly known as the Garden of Clear Ripples, is located in the western suburbs of Beijing, 15 kilometers away from the city. It covers an area of 3.009 square kilometers, three-quarters of which is covered by water. Adjacent to the Old Summer Palace. It is a large landscape garden based on Kunming Lake and Wanshou Mountain, based on Hangzhou West Lake and drawing design techniques from Jiangnan gardens. It is also the most complete preserved royal palace and garden, known as the \"Royal Garden Museum\".In 2009, the Summer Palace was selected by the China World Record Association as the largest existing imperial garden in China.",
                    ImagePath = "/Content/Images/The Summer Palace.jpg"
                },
                   new syw
                {
                    Name = "Beijing Mutton Hotpot",
                    Type = "Delicacy",
                    Description = "Beijing Mutton Hotpot is a popular local dish that is enjoyed by both locals and tourists alike. It is a traditional hot pot dish that is cooked in a large copper pot filled with a fiery broth made with various spices and ingredients.  The dish typically consists of thinly sliced meats such as beef, lamb, and pork, as well as vegetables such as mushrooms, bamboo shoots, and bean sprouts.   Diners can cook their meats and vegetables to their liking in the boiling broth and then dip them in a variety of sauces such as sesame oil, garlic, and chili oil. Overall, Beijing's copper pot hot pot is a must-try for anyone visiting Beijing, offering a delicious and unique dining experience that is sure to leave a lasting impression.",
                    ImagePath = "/Content/Images/Beijing Mutton Hotpot.jpg"
                },
                    new syw
                {
                    Name = "Beijing shadow play",
                    Type = "Culture",
                    Description = "Beijing shadow puppetry, is a traditional form of Chinese theater that has been practiced for over a thousand years. It is a unique form of theater that uses handmade shadow puppets to tell stories through movement and music.   Each puppet representing a character in the story. The puppeteers manipulate the puppets by moving strings that are attached to the puppets, controlling their movements and expressions.            The puppets are then placed on a light box, and the puppeteers use a light source to cast the shadows of the puppets onto the screen.  The stories told in Beijing shadow puppetry cover a wide range of topics, including historical events, folk tales, and legends.  Beijing shadow puppetry is not only a unique form of entertainment, but it is also an important part of Chinese culture and history.",
                    ImagePath = "/Content/Images/Beijing shadow play.jpg"
                },
                     new syw
                {
                    Name = "The Great Wall",
                    Type = "Scenic spot",
                    Description = "The Great Wall of China is a series of fortifications built along the northern borders of China over a period of centuries. The Great Wall is composed of various materials, including brick, tamped earth, stone, and wood, and stretches over 13,000 miles (21,000 kilometers) in length.The Great Wall of China is one of the most iconic landmarks in the world and is a UNESCO World Heritage Site.   It was built to protect China from invasions by various nomadic groups from the north, including the Mongols and the Manchus.Overall, the Great Wall of China is a remarkable achievement of human ingenuity and perseverance.   It is a must-see destination for anyone traveling to China, offering a unique glimpse into China's rich cultural and historical heritage.",
                    ImagePath = "/Content/Images/The Great Wall.jpg"
                },
                      new syw
                {
                    Name = "Rock sugar gourd",
                    Type = "Delicacy",
                    Description = "Rock sugar gourd is a popular Chinese dessert that originated in the northern part of the country. It is a refreshing and sweet treat that is perfect for hot summer days.    To make the dessert, a stick is inserted into a haw (a type of fruit) and the fruit is then dipped into a sweet syrup made from sugar, water, and sometimes fruit juice. The haw is then frozen on a block of shaved ice, creating a delicious and crunchy treat.    In addition to haws, other fruits such as peaches, plums, and cherries can also be used to makeRock sugar gourd. The fruit is often dipped in a variety of flavors such as honey, sesame, or chocolate.  Overall, Rock sugar gourd is a delicious and refreshing dessert that is perfect for hot summer days. Its sweet and crunchy taste make it a favorite among both children and adults.",
                    ImagePath = "/Content/Images/Rock sugar gourd.jpg"
                }
            };
            return View(products);
}

        public static List<syw> GetProducts()
        {
            // 创建一个示例的产品列表
            var products = new List<syw>
        {
             new syw
                {
                    Name = "Tiananmen Square",
                    Type = "Scenic spot",
                    Description = "Tian'anmen is a large monumental gate located in the heart of Beijing, China.",
                    ImagePath = "/Content/Images/Tiananmen Square.jpg"
                },
                new syw
                {
                    Name = "Peking Duck",
                    Type = "Delicacy",
                    Description = "Beijing Roast duck is a famous Beijing dish with a world reputation, which originated in the Southern and Northern Dynasties of China.",
                    ImagePath = "/Content/Images/Peking Duck.jpg"
                },
                new syw
                {
                    Name = "Peking Opera",
                    Type = "Culture",
                    Description = "Peking Opera is one of the quintessence of China and the most influential opera in China.",
                    ImagePath = "/Content/Images/Peking Opera.jpg"
                },
                new syw
                {
                    Name = "Forbidden City",
                    Type = "Scenic spot",
                    Description = "The Imperial Palace of the Ming and Qing dynasties of China is located at the center of the central axis of Beijing.",
                    ImagePath = "/Content/Images/Forbidden City.jpg"
                },
                new syw
                {
                    Name = "Noodles with bean paste",
                    Type = "Delicacy",
                    Description = "Zhajiang noodles, a traditional Chinese characteristic pasta, is known as one of the \"Top ten noodles in China\".",
                    ImagePath = "/Content/Images/Noodles with bean paste.jpg"
                },
        };
            return products;
        }


        public ActionResult Contact()
         {
             ViewBag.Message = "Contact Us";
             return View();
        }

    }
}