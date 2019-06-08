using System;
using System.Collections.Generic;
using Turfa.Models;

namespace Turfa.ViewModels
{
    public class HomePageVM
    {
        public List<item> SweetsList { set; get; }
        public List<item> SoursList { set; get; }
        public List<item> HealthyList { set; get; }

        public HomePageVM()
        {
            SweetsList = new List<item>();
            FillSweets();

            SoursList = new List<item>();
            FillSours();

            HealthyList = new List<item>();
            FillHealthy();
        }

        private void FillSweets()
        {
            item SweetOne = new item("4 Flavors Cheesecake", "Quatra_Flavors.JPG", "90 SR", "0504650003", "Cheesecake with four flavors of your choice. Two Sizes Avaliable, Small 90 SR, Big 110 SR", "Turfa@turfa.com", 21.553458, 39.167130);
            SweetsList.Add(SweetOne);

            item SweetTwo = new item("Double Flavor Cheesecake", "Double_Flavor_Chesecake.JPG", "90 SR", "0504650003", "Cheesecake with four flavors of your choice. Two Sizes Avaliable, Small 90 SR, Big 110 SR", "Turfa@turfa.com", 21.553458, 39.167130);
            SweetsList.Add(SweetTwo);

            item SweetThree = new item("Choclate Cake", "Choclate_Cake.HEIC", "110 SR", "0504650003", "Cheesecake with four flavors of your choice. Two Sizes Avaliable", "Turfa@turfa.com", 21.553458, 39.167130);
            SweetsList.Add(SweetThree);

            item SweetFour = new item("Desert Cake", "Desert_Cake.JPG", "70 SR", "0504650003", "Cheesecake with four flavors of your choice. Two Sizes Avaliable", "Turfa@turfa.com", 21.553458, 39.167130);
            SweetsList.Add(SweetFour);

            item SweetFive = new item("Mini Cheesecake", "Mini_Chesecake.JPG", "40 SR", "0504650003", "Cheesecake with four flavors of your choice. Two Sizes Avaliable", "Turfa@turfa.com", 21.553458, 39.167130);
            SweetsList.Add(SweetFive);

            item SweetSix = new item("Mini Desert Cake", "Mini_Desert_Cake.HEIC", "40 SR", "0504650003", "Cheesecake with four flavors of your choice. Two Sizes Avaliable", "Turfa@turfa.com", 21.553458, 39.167130);
            SweetsList.Add(SweetSix);

        }

        private void FillSours()
        {
            item SourOne = new item("Cheese Pastry", "Chese_Pastry.JPG", "2 SR", "0504650003", "Cheesecake with four flavors of your choice. Two Sizes Avaliable", "Turfa@turfa.com", 21.553458, 39.167130);
            SoursList.Add(SourOne);

            item SourTwo = new item("Flafil Cake", "Flafil_Cake.HEIC", "55 SR", "0504650003", "Cheesecake with four flavors of your choice. Two Sizes Avaliable", "Turfa@turfa.com", 21.553458, 39.167130);
            SoursList.Add(SourTwo);

        }

        private void FillHealthy()
        {
            item HealthyOne = new item("Granula", "Granula.JPG", " ", "0504650003", "Avaliable three sizes, Small 30 SR, Mediuem 50 SR, Big 60 SR", "Turfa@turfa.com", 21.553458, 39.167130);
            HealthyList.Add(HealthyOne);

        }
    }
}
