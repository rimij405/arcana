/************************************************
 * IScreen.cs
 * 
 * Contains implementation for the Screen interface.
 ************************************************/

/////////////////////
// Using statements.
/////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Game.UI.Screens
{

    /// <summary>
    /// Defines the public data members and class references for each Screen type classes.
    /// </summary>
    public interface IScreen
    {

        #region Data Members
        
        /////////////////////
        // Public data fields.
        /////////////////////

        /// <summary>
        /// Determine if Screen object is initialized.
        /// </summary>
        bool m_initialized { get; set; }
        
        /// <summary>
        /// Determine if Screen object resources are loaded.
        /// </summary>
        bool m_loaded { get; set; }

        /// <summary>
        /// Screen resolution (x-axis).
        /// </summary>
        int m_screenResolutionX { get; set; }

        /// <summary>
        /// Screen resolution (y-axis).
        /// </summary>
        int m_screenResolutionY { get; set; }

        #endregion

        #region Service Methods
        
        /// <summary>
        /// Initialize this Screen object.
        /// </summary>
        void Initialize();
        
        /// <summary>
        /// Load this Screen object's resources.
        /// </summary>
        void Load();
        
        /// <summary>
        /// Update the stage on every frame.
        /// </summary>
        void Update(float delta);

        #endregion

        #region Mutator Methods

        // TODO: Stub.

        #endregion

        #region Accessors Methods

        // TODO: Stub.

        #endregion

    }
}
