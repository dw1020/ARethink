using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace America_Rethink.Objects
{
    public class Page
    {
        /// <summary>
        /// Gets or sets the page identifier.
        /// </summary>
        /// <value>The page identifier.</value>
        [Column("PageID")]
        public string PageID { get; set; } = "";

        /// <summary>
        /// Gets or sets the page name.
        /// </summary>
        /// <value>The page name.</value>
        [Column("PageName")]
        public string Name { get; set; } = "";

        /// <summary>
        /// Gets or sets the page type.
        /// </summary>
        /// <value>The page type.</value>
        [Column("PageType")]
        public string Type { get; set; } = "";

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        [Column("URL")]
        public string URL { get; set; } = "";

        /// <summary>
        /// Gets or sets the last updated by.
        /// </summary>
        /// <value>The last updated by.</value>
        [Column("LastUpdatedBy")]
        public string LastUpdatedBy { get; set; } = "";

        /// <summary>
        /// Gets or sets the last updated date.
        /// </summary>
        /// <value>The last updated date.</value>
        [Column("LastUpdatedDate")]
        public DateTime LastUpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>The created by.</value>
        [Column("CreatedBy")]
        public string CreatedBy { get; set; } = "";

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>The created date.</value>
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the active from.
        /// </summary>
        /// <value>The active from.</value>
        [Column("ActiveFrom")]
        public DateTime ActiveFrom { get; set; } = new DateTime(1900, 01, 01, 00, 00, 00);

        /// <summary>
        /// Gets or sets the active to.
        /// </summary>
        /// <value>The active to.</value>
        [Column("ActiveTo")]
        public DateTime ActiveTo { get; set; } = new DateTime(1900, 01, 01, 00, 00, 00);

        public Page()
        {

           

        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:America_Rethink.Objects.Page"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:America_Rethink.Objects.Page"/>.</returns>
        public override string ToString()
        {
            string str = PageID + "    " + PageName + "    " + URL + "    " + LastUpdatedBy + "    " +
                LastUpdatedDate.ToString() + "    " + CreatedBy + "    " + CreatedDate.ToString() + "    " + ActiveFrom.ToString() +
                               "    " + ActiveFrom.ToString() + "    " + ActiveTo.ToString() + "    " + isActive();
            return str;
        }

        /// <summary>
        /// Checks to see if the current page is active.
        /// </summary>
        /// <returns><c>true</c>, if the current date is within the active date range, <c>false</c> if it is not within the active date range.</returns>
        public bool IsActive()
        {
            var now = DateTime.Now;
            var defaultDate = new DateTime(1900, 01, 01, 00, 00, 00);

            //Determine if the page is active
            if ((ActiveFrom >= now && ActiveTo <= now) ||
               (ActiveFrom == defaultDate && ActiveTo <= now) ||
               (ActiveFrom == defaultDate && ActiveTo == defaultDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
