using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
namespace America_Rethink.Models
{
    public class ContentItem
    {
        /// <summary>
        /// Gets or sets the ContentItem ID.
        /// </summary>
        /// <value>The Primary Key for the contentitem table.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the page identifier.
        /// </summary>
        /// <value>The parent page id.</value>
        public string PageID { get; set; }

        /// <summary>
        /// Gets or sets the content item type.
        /// </summary>
        /// <value>The type of content.</value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>The image associated with the content item.</value>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The meaningful content of the content item. This is data that usually ends up on the page.</value>
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets the last updated by.
        /// </summary>
        /// <value>The person that last updated the content item.</value>
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the sequence number.
        /// </summary>
        /// <value>This usually corresponds to the order of items on the page.</value>
        public int Seq { get; set; }

        /// <summary>
        /// Gets or sets the active from date.
        /// </summary>
        /// <value>The date that the content is supposed to start appearing.</value>
        public DateTime ActiveFrom { get; set; }

        /// <summary>
        /// Gets or sets the active to date.
        /// </summary>
        /// <value>The date that the content is supposed to stop appearing.</value>
        public DateTime ActiveTo { get; set; }

        /// <summary>
        /// Gets or sets the last updated date.
        /// </summary>
        /// <value>The date that the content item was last updated.</value>
        public DateTime LastUpdatedDate { get; set; }
    }
}