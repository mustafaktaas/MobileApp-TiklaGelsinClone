using GraphqlTiklaGelsin.İService;
using GraphqlTiklaGelsin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlTiklaGelsin.Service
{
    public class FoodService : IFoodService
    {
        public List<FoodItems> GetFoodItems()
        {
            List<FoodItems> foodItems = new List<FoodItems>()
                {
                new FoodItems()
                {
                  FoodItemID=1,
                  FoodItemName="Besiktas Menu",
                  Price=50,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/besiktas_menusu_9512ad21ee.webp",
                  CategoryID=1,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=2,
                  FoodItemName="Fenerbahce Menu",
                  Price=50,
                  Rating=5,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/fenerbahce_menusu_0673f3eeb8.webp",
                  CategoryID=1,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=3,
                  FoodItemName="Galatasasray Menu",
                  Price=50,
                  Rating=1,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/galatasaray_menusu_3edf139175.webp",
                  CategoryID=1,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=4,
                  FoodItemName="Whopper Menu",
                  Price=32,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/whopper_menu_ba9e718e4a.webp",
                  CategoryID=1,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=5,
                  FoodItemName="Evde Kal Seçmeli Menu",
                  Price=45,
                  Rating=8,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/evde_kal_secmeli_menu_cc9e360a9b.webp",
                  CategoryID=1,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=6,
                  FoodItemName="3 lü Whopper Fırsatı",
                  Price=45,
                  Rating=7,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/3lu_whopper_firsati_a2b31411bc.webp",
                  CategoryID=1,
                  RestaurantID=1
                },

                new FoodItems()
                {
                  FoodItemID=7,
                  FoodItemName="BK Algida Menusu",
                  Price=45,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/burger_king_algida_menusu_855faca085.webp",
                  CategoryID=2,
                  RestaurantID=1
                },

                new FoodItems()
                {
                  FoodItemID=8,
                  FoodItemName="Sultan Menu Kampanyası",
                  Price=70,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/sultan_menu_kampanyasi_d8f1f612f5.webp",
                  CategoryID=2,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=9,
                  FoodItemName="Karışık Lezzzet Kova Menü",
                  Price=30,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/karisik_lezzet_kova_menu_2758390806.webp",
                  CategoryID=2,
                  RestaurantID=1
                },
                 new FoodItems()
                {
                  FoodItemID=10,
                  FoodItemName="Kahve + Tatlı Kampanyası",
                  Price=12,
                  Rating=9,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/kahve_tatli_kampanyasi_6b2febd166.webp",
                  CategoryID=2,
                  RestaurantID=1
                },
                  new FoodItems()
                {
                  FoodItemID=11,
                  FoodItemName="Big Royale Kampanyası",
                  Price=45,
                  Rating=7,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/big_royale_kampanyasi_8c1ed1de38.webp",
                  CategoryID=2,
                  RestaurantID=1
                },
                   new FoodItems()
                {
                  FoodItemID=12,
                  FoodItemName="Kral İkili",
                  Price=40,
                  Rating=4,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/kral_ikili_7c3bef5114.webp",
                  CategoryID=2,
                  RestaurantID=1
                },
                       new FoodItems()
                {
                  FoodItemID=13,
                  FoodItemName="Etli Master Burger",
                  Price=28,
                  Rating=8,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/etli_master_burger_bfbede9152.webp",
                  CategoryID=3,
                  RestaurantID=1
                },
                           new FoodItems()
                {
                  FoodItemID=14,
                  FoodItemName="Pastırmalı Whopper",
                  Price=29,
                  Rating=5,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/pastirmali_whopper_349e55c87f.webp",
                  CategoryID=3,
                  RestaurantID=1
                },
                               new FoodItems()
                {
                  FoodItemID=15,
                  FoodItemName="Barbeko Burger",
                  Price=23,
                  Rating=7,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/barbeko_burger_8bd5d54f47.webp",
                  CategoryID=3,
                  RestaurantID=1
                },
                                   new FoodItems()
                {
                  FoodItemID=16,
                  FoodItemName="Texas Smokehouse Burger",
                  Price=30,
                  Rating=10,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/texas_smokehouse_burger_bbaf4383e6.webp",
                  CategoryID=3,
                  RestaurantID=1
                },
                                       new FoodItems()
                {
                  FoodItemID=17,
                  FoodItemName="Big King XXL",
                  Price=36,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/big_king_xxl_8528060c02.webp",
                  CategoryID=3,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=18,
                  FoodItemName="Kids Cheese",
                  Price=15,
                  Rating=2,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/kids_cheese_89028ff373.webp",
                  CategoryID=3,
                  RestaurantID=1
                },

                   new FoodItems()
                {
                  FoodItemID=19,
                  FoodItemName="Kids Hamburger Menu",
                  Price=26,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/kids_hamburger_menu_36b608ae0f.webp",
                  CategoryID=4,
                  RestaurantID=1
                },

                      new FoodItems()
                {
                  FoodItemID=20,
                  FoodItemName="Kids Cheese Menu",
                  Price=28,
                  Rating=4,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/kids_cheese_menu_8beb058251.webp",
                  CategoryID=4,
                  RestaurantID=1
                },

                         new FoodItems()
                {
                  FoodItemID=21,
                  FoodItemName="Tavuklu Kids Menu",
                  Price=25,
                  Rating=5,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/tavuklu_kids_menu_6b1b2b547f.webp",
                  CategoryID=4,
                  RestaurantID=1
                },

                            new FoodItems()
                {
                  FoodItemID=22,
                  FoodItemName="Kids Chicken TendeRS Menu",
                  Price=25,
                  Rating=8,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/kids_chicken_tenders_menu_ac0e59de60.webp",
                  CategoryID=4,
                  RestaurantID=1
                },

                new FoodItems()
                {
                  FoodItemID=23,
                  FoodItemName="Tavuklu Kids Cheese Menu",
                  Price=27,
                  Rating=7,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/tavuklu_kids_cheese_menu_7c8e659829.webp",
                  CategoryID=4,
                  RestaurantID=1
                },
                 new FoodItems()
                {
                  FoodItemID=24,
                  FoodItemName="Hot Wrap",
                  Price=17,
                  Rating=9,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/hot_wrap_676371a30f.webp",
                  CategoryID=5,
                  RestaurantID=1
                },

                  new FoodItems()
                {
                  FoodItemID=25,
                  FoodItemName="Kin Delight Izgara Tavuklu Salata",
                  Price=19,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/king_delight_izgara_tavuklu_salata_dfdc990fae.webp",
                  CategoryID=5,
                  RestaurantID=1
                },

                   new FoodItems()
                {
                  FoodItemID=26,
                  FoodItemName="Kin Delight Ton Balıklı Salata",
                  Price=20,
                  Rating=2,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/king_delight_ton_balikli_salata_3042df2682.webp",
                  CategoryID=5,
                  RestaurantID=1
                },

                    new FoodItems()
                {
                  FoodItemID=27,
                  FoodItemName="Kin Delight Akdeniz Salata",
                  Price=18,
                  Rating=3,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/king_delight_akdeniz_salata_4dfa96c50c.webp",
                  CategoryID=5,
                  RestaurantID=1
                },

                new FoodItems()
                {
                  FoodItemID=28,
                  FoodItemName="Mini Salata",
                  Price=13,
                  Rating=1,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/mini_salata_5b5df523ef.webp",
                  CategoryID=5,
                  RestaurantID=1
                },

                 new FoodItems()
                {
                  FoodItemID=29,
                  FoodItemName="Chicken Wings(6'lı)",
                  Price=14,
                  Rating=7,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/chicken_wings_6li_bcadac8691.webp",
                  CategoryID=6,
                  RestaurantID=1
                },
                  new FoodItems()
                {
                  FoodItemID=30,
                  FoodItemName="Chicken Wings(8'lı)",
                  Price=17,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/chicken_wings_8li_4a881c2b97.webp",
                  CategoryID=6,
                  RestaurantID=1
                },
                   new FoodItems()
                {
                  FoodItemID=31,
                  FoodItemName="Chicken TendeRS(6'lı)",
                  Price=12,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/chicken_tenders_6li_f9aea99d94.webp",
                  CategoryID=6,
                  RestaurantID=1
                },
                    new FoodItems()
                {
                  FoodItemID=32,
                  FoodItemName="Chicken TendeRS(9'lı)",
                  Price=15,
                  Rating=9,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/chicken_tenders_9lu_b50c7be6fb.webp",
                  CategoryID=6,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=33,
                  FoodItemName="Çıtır Peynir(9'lu)",
                  Price=15,
                  Rating=10,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/citir_peynir_9lu_102a7d6740.webp",
                  CategoryID=6,
                  RestaurantID=1
                },
                 new FoodItems()
                {
                  FoodItemID=34,
                  FoodItemName="Sade Kruvasan",
                  Price=8,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/sade_kruvasan_c6f81b89eb.webp",
                  CategoryID=7,
                  RestaurantID=1
                },

                  new FoodItems()
                {
                  FoodItemID=35,
                  FoodItemName="Vişneli Tatlı",
                  Price=5,
                  Rating=4,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/visneli_tatli_6fc41d0986.webp",
                  CategoryID=7,
                  RestaurantID=1
                },

                   new FoodItems()
                {
                  FoodItemID=36,
                  FoodItemName="Tiramusu",
                  Price=10,
                  Rating=8,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/tiramisu_e350d97831.webp",
                  CategoryID=7,
                  RestaurantID=1
                },

                    new FoodItems()
                {
                  FoodItemID=37,
                  FoodItemName="Mekik",
                  Price=2,
                  Rating=4,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/mekik_c9d773dc52.webp",
                  CategoryID=7,
                  RestaurantID=1
                },

                     new FoodItems()
                {
                  FoodItemID=38,
                  FoodItemName="Sundae",
                  Price=5,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/sundae_c1da2c81e8.webp",
                  CategoryID=7,
                  RestaurantID=1
                },

                new FoodItems()
                {
                  FoodItemID=39,
                  FoodItemName="Mozaik Pasta",
                  Price=11,
                  Rating=8,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/mozaik_pasta_54435ce161.webp",
                  CategoryID=7,
                  RestaurantID=1
                },
                   new FoodItems()
                {
                  FoodItemID=40,
                  FoodItemName="Ketçap",
                  Price=1,
                  Rating=8,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/ketcap_32f8f33054.webp",
                  CategoryID=8,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=41,
                  FoodItemName="Mayonez",
                  Price=1,
                  Rating=8,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/mayonez_7a3b2a35ae.webp",
                  CategoryID=8,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=42,
                  FoodItemName="Acı Sos",
                  Price=1,
                  Rating=7,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/Aci_Sos_e487edfab1",
                  CategoryID=8,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=43,
                  FoodItemName="Barbekü Sos",
                  Price=2,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/barbeku_sos_0d9ac14f0e.webp",
                  CategoryID=8,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=44,
                  FoodItemName="Ranch Sos",
                  Price=2,
                  Rating=7,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/ranch_sos_44aa846c8b.webp",
                  CategoryID=8,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=45,
                  FoodItemName="Buffalo Sos",
                  Price=2,
                  Rating=9,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/buffalo_sos_83b747af5c.webp",
                  CategoryID=8,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=46,
                  FoodItemName="Coca-Cola(33 cl)",
                  Price=6,
                  Rating=9,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/coca_cola_33_cl_0453581cf2.webp",
                  CategoryID=9,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=47,
                  FoodItemName="Fanta(33 cl)",
                  Price=6,
                  Rating=4,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/fanta_33_cl_18b4533b1c.webp",
                  CategoryID=9,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=48,
                  FoodItemName="Sprite(33 cl)",
                  Price=6,
                  Rating=5,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/sprite_33_cl_8db301fab6.webp",
                  CategoryID=9,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=49,
                  FoodItemName="Fuse Tea(33 cl)",
                  Price=6,
                  Rating=6,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/fuse_tea_limon_33_cl_85682890c3.webp",
                  CategoryID=9,
                  RestaurantID=1
                },
                new FoodItems()
                {
                  FoodItemID=50,
                  FoodItemName="Ayran(300 ml)",
                  Price=5,
                  Rating=8,
                  ImageUrl="https://d3vkdqr0qjxhag.cloudfront.net/burger-king/ayran_buyuk_300_ml_360d163b9c.webp",
                  CategoryID=9,
                  RestaurantID=1
                },





                };
            return foodItems;
        }
    }
}
