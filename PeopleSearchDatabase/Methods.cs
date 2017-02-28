using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using PeopleSearchDatabase.Models;

namespace PeopleSearchDatabase
{
    /// <summary>
    /// A class to centralize the PeopleSearch add record logic.  This is needed due to the unique logic
    /// used for populating the PeopleNameLookup table.
    /// </summary>
    public class Methods : IDisposable
    {
        private IPeopleSearch _context;
        private int _commitFrequency;
        private int _processedRecords;
        private bool _disposed;
        private SafeHandle _handle;

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="context">Injected interface to avoid tight coupling and enable mocked objects for unit testing.</param>
        /// <param name="commitFrequency">The frequency in which records will be saved/committed.</param>
        public Methods(IPeopleSearch context, int commitFrequency)
        {
            _context = context;
            _commitFrequency = commitFrequency;
            _processedRecords = 0;
            _disposed = false;
            _handle = new SafeFileHandle(IntPtr.Zero, true);
        }

        /// <summary>
        /// Add Person to the PeopleSearch database.
        /// </summary>
        /// <param name="person">Person to add.</param>
        public void AddPersonWithAddress(Person person)
        {
            Person addedPerson = _context.AddPerson(person);
            AddPeopleNameLookup(addedPerson);
            _processedRecords++;

            if ((_processedRecords % _commitFrequency) == 0)
            {
                _context.ExecuteSaveChanges();  
            }
        }

        /// <summary>
        /// Centralized logic to add the appropriate PeopleNameLookup records. Ideally it would be nice to have this
        /// method be private (as it only needs to be accessible from the AddPersonWithAddress(Person person) method
        /// but it has been set as internal such that it can be unit tested.
        /// </summary>
        /// <param name="addedPerson">Person used to add the appropriate PeopleNameLookup records.</param>
        internal void AddPeopleNameLookup(Person addedPerson)
        {
            List<string> namesToAdd = new List<string>() {addedPerson.FirstName.Trim().ToLower(), addedPerson.LastName.Trim().ToLower()};

            foreach (string cleanedName in namesToAdd)
            {
                for (int namePartLength = 1; namePartLength <= cleanedName.Length; namePartLength++)
                {
                    int currentPosition = 0;
                    while (currentPosition + namePartLength <= cleanedName.Length)
                    {
                        PeopleNameLookup peopleNameLookup = new PeopleNameLookup()
                        {
                            NamePart = cleanedName.Substring(currentPosition, namePartLength),
                            NameStart = (currentPosition == 0),
                            Person = addedPerson
                        };

                        _context.AddPeopleNameLookup(peopleNameLookup);

                        currentPosition++;
                    }
                }
            }
        }

        /// <summary>
        /// Public implementation of Dispose pattern callable by consumers. 
        /// </summary>
        public void Dispose()
        {
            // Save any outstanding changes.
            _context.ExecuteSaveChanges();

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Protected implementation of Dispose pattern. 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _handle.Dispose();
                // Free any other managed objects here.
            }

            // Free any unmanaged objects here.
            _disposed = true;
        }
    }
}
