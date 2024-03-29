﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeeOpen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        public Detail()
        {
            InitializeComponent();
        }

        private async void Liquid_OnClicked(object sender, EventArgs e)
        {
            var pResult = await UserDialogs.Instance.PromptAsync(new PromptConfig
            {
                InputType = InputType.Name,
                OkText = "Εξουσιοδώτηση",
                Title = "Εισάγετε το όνομα χρήστη του ατόμου που θέλετε να εξουσιοδωτήσετε"
            });

            String id=generateID ();
            UserDialogs.Instance.Alert("Το ID ψήφου είναι " + id+"\n Η επιβεβαίωση στάλθκε στην δνση Ηλ-ταχυδρομειου");
        }

        

        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        private void Confirm_OnClicked(object sender, EventArgs e)
        {
            String id = generateID();
            UserDialogs.Instance.Alert("Το ID ψήφου είναι " + id + "\n Η επιβεβαίωση στάλθκε στην δνση Ηλ-ταχυδρομειου");
        }
    }
}