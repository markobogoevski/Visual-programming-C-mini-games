﻿using PeopleViewer.Common;
using PersonDataReader.Service2;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PeopleViewer.Presentation2
{
    public class PeopleViewModel :INotifyPropertyChanged
    {
        protected ServiceReader DataReader;

        private IEnumerable<Person> _people;
        public IEnumerable<Person> People
        {
            get { return _people; }
            private set { _people = value; }
        }

        public PeopleViewModel()
        {
            DataReader = new ServiceReader();
        }

        public void RefreshPeople()
        {
            People = DataReader.GetPeople();
        }

        public void ClearPeople()
        {
            People = new List<Person>();
        }

        public string DataReaderType
        {
            get { return DataReader.GetType().ToString(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
