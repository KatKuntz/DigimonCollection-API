using System;

namespace CardManager.Models
{
    class Set
    {
        public int SetId { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate
        {
            get
            {
                return releaseDate;
            }

            set
            {
                releaseDate = value.Date;
            }
        }

        private DateTime releaseDate;
    }
}
