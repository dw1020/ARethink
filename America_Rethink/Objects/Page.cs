using System;
namespace America_Rethink.Objects
{
    public class Page
    {

        public string PageID { get; set; } = "";
        public string PageName { get; set; } = "";
        public string PageType { get; set; } = "";
        public string URL { get; set; } = "";
        public string LastUpdatedBy { get; set; } = "";
        public DateTime LastUpdatedDate { get; set; }
        public string CreatedBy { get; set; } = "";
        public DateTime CreatedDate { get; set; }
        public DateTime ActiveFrom { get; set; } 
        public DateTime ActiveTo { get; set; } 
        public bool isActive { get; }



        public Page()
        {

            var now = DateTime.Now;
            var defaultDate = new DateTime(1900, 01, 01, 00, 00, 00);

            //Determine if the page is active
            if ((ActiveFrom >= now && ActiveTo <= now) || 
               (ActiveFrom == defaultDate && ActiveTo <= now ) ||
               (ActiveFrom == defaultDate && ActiveTo == defaultDate)){
                isActive = true;
            }
            else
            {
                isActive = false;
            }

        }


    }
}
