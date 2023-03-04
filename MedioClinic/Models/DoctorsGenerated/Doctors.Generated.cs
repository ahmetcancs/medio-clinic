﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.MC;

[assembly: RegisterDocumentType(Doctors.CLASS_NAME, typeof(Doctors))]

namespace CMS.DocumentEngine.Types.MC
{
    /// <summary>
    /// Represents a content item of type Doctors.
    /// </summary>
    public partial class Doctors : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "MC.Doctors";


        /// <summary>
        /// The instance of the class that provides extended API for working with Doctors fields.
        /// </summary>
        private readonly DoctorsFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// DoctorsID.
        /// </summary>
        [DatabaseIDField]
        public int DoctorsID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("DoctorsID"), 0);
            }
            set
            {
                SetValue("DoctorsID", value);
            }
        }


        /// <summary>
        /// Name.
        /// </summary>
        [DatabaseField]
        public string BaseName
        {
            get
            {
                return ValidationHelper.GetString(GetValue("BaseName"), @"");
            }
            set
            {
                SetValue("BaseName", value);
            }
        }


        /// <summary>
        /// Title.
        /// </summary>
        [DatabaseField]
        public string BaseTitle
        {
            get
            {
                return ValidationHelper.GetString(GetValue("BaseTitle"), @"");
            }
            set
            {
                SetValue("BaseTitle", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with Doctors fields.
        /// </summary>
        [RegisterProperty]
        public DoctorsFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with Doctors fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class DoctorsFields : AbstractHierarchicalObject<DoctorsFields>
        {
            /// <summary>
            /// The content item of type Doctors that is a target of the extended API.
            /// </summary>
            private readonly Doctors mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="DoctorsFields" /> class with the specified content item of type Doctors.
            /// </summary>
            /// <param name="instance">The content item of type Doctors that is a target of the extended API.</param>
            public DoctorsFields(Doctors instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// DoctorsID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.DoctorsID;
                }
                set
                {
                    mInstance.DoctorsID = value;
                }
            }


            /// <summary>
            /// Name.
            /// </summary>
            public string BaseName
            {
                get
                {
                    return mInstance.BaseName;
                }
                set
                {
                    mInstance.BaseName = value;
                }
            }


            /// <summary>
            /// Title.
            /// </summary>
            public string BaseTitle
            {
                get
                {
                    return mInstance.BaseTitle;
                }
                set
                {
                    mInstance.BaseTitle = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="Doctors" /> class.
        /// </summary>
        public Doctors() : base(CLASS_NAME)
        {
            mFields = new DoctorsFields(this);
        }

        #endregion
    }
}