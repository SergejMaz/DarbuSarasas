﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarbuSarasas.Models
{
    class TodoModel : INotifyPropertyChanged
    {
        public DateTime CreatioDate { get; set; } = DateTime.Now;

        private bool _isDone;
        private string _text;

        [JsonProperty(PropertyName = "creationData1")]

        public bool IsDone
        {
            get { return _isDone; }
            set 
            {
                if (_isDone == value)
                    return;
                
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }
        [JsonProperty(PropertyName = "creationData")]
        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {            
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            

        }


    }
}
