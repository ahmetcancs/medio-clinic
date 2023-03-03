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

[assembly: RegisterDocumentType(HomeTopSection.CLASS_NAME, typeof(HomeTopSection))]

namespace CMS.DocumentEngine.Types.MC
{
    /// <summary>
    /// Represents a content item of type HomeTopSection.
    /// </summary>
    public partial class HomeTopSection : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "MC.HomeTopSection";


        /// <summary>
        /// The instance of the class that provides extended API for working with HomeTopSection fields.
        /// </summary>
        private readonly HomeTopSectionFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// HomeTopSectionID.
        /// </summary>
        [DatabaseIDField]
        public int HomeTopSectionID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("HomeTopSectionID"), 0);
            }
            set
            {
                SetValue("HomeTopSectionID", value);
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
        /// Gets an object that provides extended API for working with HomeTopSection fields.
        /// </summary>
        [RegisterProperty]
        public HomeTopSectionFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with HomeTopSection fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class HomeTopSectionFields : AbstractHierarchicalObject<HomeTopSectionFields>
        {
            /// <summary>
            /// The content item of type HomeTopSection that is a target of the extended API.
            /// </summary>
            private readonly HomeTopSection mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="HomeTopSectionFields" /> class with the specified content item of type HomeTopSection.
            /// </summary>
            /// <param name="instance">The content item of type HomeTopSection that is a target of the extended API.</param>
            public HomeTopSectionFields(HomeTopSection instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// HomeTopSectionID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.HomeTopSectionID;
                }
                set
                {
                    mInstance.HomeTopSectionID = value;
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
        /// Initializes a new instance of the <see cref="HomeTopSection" /> class.
        /// </summary>
        public HomeTopSection() : base(CLASS_NAME)
        {
            mFields = new HomeTopSectionFields(this);
        }

        #endregion
    }
}