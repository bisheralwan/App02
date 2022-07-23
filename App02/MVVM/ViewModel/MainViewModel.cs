using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using App02.MVVM.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App02.Core;

namespace App02.MVVM.ViewModel
{
    class MainViewModel : ObservableObject 
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        /* Commands */
        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set { 
                _selectedContact = value;
                OnPropertyChanged();
            }
        }


        private string _message;

        public string Message
        {
            get { return _message; }
            set 
            { 
                _message = value;
                OnPropertyChanged();
            }
        }



        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });

                Message = "";
            });

            /*Messages.Add(new MessageModel
            {
                Username = "2022-07-20 11:39:12 AM" + "\nChris Hemsworth",
                UsernameColour = "#49aff",
                ImageSource = "https://upload.wikimedia.org/wikipedia/commons/e/e8/Chris_Hemsworth_by_Gage_Skidmore_2_%28cropped%29.jpg",
                Message = "\nHey Sara, wanna grab coffee at lunch?",
                //Time = DateTime.Now,
                isNativeOrigin = false,
                FirstMessage = true
            });*/

            Messages.Add(new MessageModel
            {
                Username = DateTime.Now + "\nMe",
                UsernameColour = "#49aff",
                ImageSource = "https://upload.wikimedia.org/wikipedia/commons/c/cc/Sara_Paxton_at_Mother_Goose_Parade%2C_2007_%28bright%29.jpg",
                Message = "",
                //Time = DateTime.Now,
                isNativeOrigin = false,
                FirstMessage = true
            });



            Contacts.Add(new ContactModel
            {
                Username = "Chris Hemsworth",
                ImageSource = "https://upload.wikimedia.org/wikipedia/commons/e/e8/Chris_Hemsworth_by_Gage_Skidmore_2_%28cropped%29.jpg",
                Messages = Messages
            });
        }
    } }
