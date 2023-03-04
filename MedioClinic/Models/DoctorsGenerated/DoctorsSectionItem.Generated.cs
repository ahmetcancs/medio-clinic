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

[assembly: RegisterDocumentType(DoctorsSectionItem.CLASS_NAME, typeof(DoctorsSectionItem))]

namespace CMS.DocumentEngine.Types.MC
{
    /// <summary>
    /// Represents a content item of type DoctorsSectionItem.
    /// </summary>
    public partial class DoctorsSectionItem : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "MC.DoctorsSectionItem";


        /// <summary>
        /// The instance of the class that provides extended API for working with DoctorsSectionItem fields.
        /// </summary>
        private readonly DoctorsSectionItemFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// DoctorsSectionItemID.
        /// </summary>
        [DatabaseIDField]
        public int DoctorsSectionItemID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("DoctorsSectionItemID"), 0);
            }
            set
            {
                SetValue("DoctorsSectionItemID", value);
            }
        }


        /// <summary>
        /// Image.
        /// </summary>
        [DatabaseField]
        public string Image
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Image"), @"");
            }
            set
            {
                SetValue("Image", value);
            }
        }


        /// <summary>
        /// Title.
        /// </summary>
        [DatabaseField]
        public string Title
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Title"), @"");
            }
            set
            {
                SetValue("Title", value);
            }
        }


        /// <summary>
        /// Description.
        /// </summary>
        [DatabaseField]
        public string Description
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Description"), @"");
            }
            set
            {
                SetValue("Description", value);
            }
        }


        /// <summary>
        /// Badge.
        /// </summary>
        [DatabaseField]
        public bool Badge
        {
            get
            {
                return ValidationHelper.GetBoolean(GetValue("Badge"), true);
            }
            set
            {
                SetValue("Badge", value);
            }
        }


        /// <summary>
        /// Button.
        /// </summary>
        [DatabaseField]
        public string Button
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Button"), @"");
            }
            set
            {
                SetValue("Button", value);
            }
        }


        /// <summary>
        /// ButtonTitle.
        /// </summary>
        [DatabaseField]
        public string ButtonTitle
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ButtonTitle"), @"");
            }
            set
            {
                SetValue("ButtonTitle", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with DoctorsSectionItem fields.
        /// </summary>
        [RegisterProperty]
        public DoctorsSectionItemFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with DoctorsSectionItem fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class DoctorsSectionItemFields : AbstractHierarchicalObject<DoctorsSectionItemFields>
        {
            /// <summary>
            /// The content item of type DoctorsSectionItem that is a target of the extended API.
            /// </summary>
            private readonly DoctorsSectionItem mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="DoctorsSectionItemFields" /> class with the specified content item of type DoctorsSectionItem.
            /// </summary>
            /// <param name="instance">The content item of type DoctorsSectionItem that is a target of the extended API.</param>
            public DoctorsSectionItemFields(DoctorsSectionItem instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// DoctorsSectionItemID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.DoctorsSectionItemID;
                }
                set
                {
                    mInstance.DoctorsSectionItemID = value;
                }
            }


            /// <summary>
            /// Image.
            /// </summary>
            public string Image
            {
                get
                {
                    return mInstance.Image;
                }
                set
                {
                    mInstance.Image = value;
                }
            }


            /// <summary>
            /// Title.
            /// </summary>
            public string Title
            {
                get
                {
                    return mInstance.Title;
                }
                set
                {
                    mInstance.Title = value;
                }
            }


            /// <summary>
            /// Description.
            /// </summary>
            public string Description
            {
                get
                {
                    return mInstance.Description;
                }
                set
                {
                    mInstance.Description = value;
                }
            }


            /// <summary>
            /// Badge.
            /// </summary>
            public bool Badge
            {
                get
                {
                    return mInstance.Badge;
                }
                set
                {
                    mInstance.Badge = value;
                }
            }


            /// <summary>
            /// Button.
            /// </summary>
            public string Button
            {
                get
                {
                    return mInstance.Button;
                }
                set
                {
                    mInstance.Button = value;
                }
            }


            /// <summary>
            /// ButtonTitle.
            /// </summary>
            public string ButtonTitle
            {
                get
                {
                    return mInstance.ButtonTitle;
                }
                set
                {
                    mInstance.ButtonTitle = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="DoctorsSectionItem" /> class.
        /// </summary>
        public DoctorsSectionItem() : base(CLASS_NAME)
        {
            mFields = new DoctorsSectionItemFields(this);
        }

        #endregion
    }
}