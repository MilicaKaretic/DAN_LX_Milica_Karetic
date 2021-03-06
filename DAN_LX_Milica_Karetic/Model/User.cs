﻿using DAN_LX_Milica_Karetic.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAN_LX_Milica_Karetic.Model
{
    public partial class tblUser : IDataErrorInfo
    {
        Validations validation = new Validations();

        /// <summary>
        /// Total amount of propertis we are checking
        /// </summary>
        static readonly string[] ValidatedProperties =
        {
            "JMBG",
            "Gender",
            "IDCard",
            "PhoneNumber",
            "LocationID"
        };

        /// <summary>
        /// Returns true if this object has no validation errors.
        /// </summary>
        public bool IsValid
        {
            get
            {
                foreach (string property in ValidatedProperties)
                {
                    // there is an error
                    if (this[property] != null)
                        return false;
                }

                return true;
            }
        }

        /// <summary>
        /// Checks if the inputs are incorrect
        /// </summary>
        public string Error
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Does validations on the property location
        /// </summary>
        /// <param name="propertyName">property we are checking</param>
        /// <returns>if the property is valid (null) or error (string)</returns>
        public string this[string propertyName]
        {
            get
            {
                string result = null;

                switch (propertyName)
                {
                    case "JMBG":
                        result = this.validation.JMBGChecker(JMBG, UserID);
                        break;

                    case "Gender":
                        result = this.validation.CannotBeEmpty(Gender);
                        break;

                    case "IDCard":
                        result = this.validation.IDCardChecker(IDCard, UserID);
                        break;

                    case "PhoneNumber":
                        result = this.validation.PhoneNumberChecker(PhoneNumber, UserID);
                        break;

                    case "LocationID":
                        result = this.validation.CannotBeZero(LocationID);
                        break;

                    default:
                        result = null;
                        break;
                }

                return result;
            }
        }
    }
}
